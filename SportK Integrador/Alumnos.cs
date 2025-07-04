using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SportK_Integrador;

namespace SportK
{
    public partial class VentanaAlumnos : Form
    {
        // Cadena de conexión a la base de datos MySQL (ojo con poner datos sensibles aquí)
        private string connectionString = "server=127.0.0.1;port=3306;user id=root;password=Saido_0209;database=sportk;";
        private DataTable horariosDT; // Tabla para guardar horarios cargados desde BD

        public VentanaAlumnos()
        {
            InitializeComponent();
            // Aquí no hago nada extra, todo en Load
        }

        private void VentanaAlumnos_Load(object sender, EventArgs e)
        {
            // Grupos son fijos, no vienen de BD, los cargo manualmente
            SelectGrupo.Items.Clear();
            SelectGrupo.Items.AddRange(new object[] { "1", "2", "3" });
            SelectGrupo.SelectedIndex = 0; // Siempre selecciono el primero por defecto

            // ComboBox de deportes y sedes los lleno desde la base de datos
            LlenarComboBox("SELECT id_deporte, nombre_deporte FROM Deportes", SelectDeporte, "nombre_deporte", "id_deporte");
            LlenarComboBox("SELECT id_sede, nombre_sede FROM Sedes", SelectSede, "nombre_sede", "id_sede");

            // Después de llenar los combos, aseguro que tengan seleccionado el primero
            SelectDeporte.SelectedIndex = 0;
            SelectSede.SelectedIndex = 0;

            // Configuro la edad mínima que puede registrar (evitar valores inválidos)
            IntNumericEdad.Minimum = 5;
            IntNumericEdad.Value = 5; // Valor inicial que va a tener

            // Cargo horarios para llenar los combos de hora inicio y fin
            CargarHorarios();

            // Agrego evento para que cuando cambie la hora inicio, se actualice la hora fin
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        // Esta función es clave para llenar cualquier ComboBox desde una consulta SQL
        private void LlenarComboBox(string query, ComboBox comboBox, string displayMember, string valueMember)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = displayMember;
                    comboBox.ValueMember = valueMember;
                    comboBox.SelectedIndex = 0;  // Siempre selecciono el primero para evitar null
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al llenar {comboBox.Name}: {ex.Message}");
                    // Aquí estaría bueno manejar mejor errores, pero por ahora solo aviso
                }
            }
        }

        // Carga los horarios desde BD y llena comboBox1 con horas inicio únicas
        private void CargarHorarios()
        {
            string query = "SELECT hora_inicio, hora_fin FROM Horarios ORDER BY hora_inicio, hora_fin;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    horariosDT = new DataTable();
                    horariosDT.Load(reader);

                    // Aquí saco las horas de inicio únicas para comboBox1
                    var horasInicio = horariosDT.AsEnumerable()
                        .Select(row => row.Field<TimeSpan>("hora_inicio"))
                        .Distinct()
                        .OrderBy(t => t)
                        .ToList();

                    comboBox1.Items.Clear();
                    foreach (var hora in horasInicio)
                    {
                        comboBox1.Items.Add(hora.ToString(@"hh\:mm")); // formato hh:mm para mostrar
                    }
                    comboBox1.SelectedIndex = 0; // Por defecto selecciono la primera hora

                    // comboBox2 queda vacío y sin selección porque depende de comboBox1
                    comboBox2.Items.Clear();
                    comboBox2.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar horarios: " + ex.Message);
                    // Si falla la carga, el comboBox de horas no funcionará bien
                }
            }
        }

        // Evento para actualizar comboBox2 con horas fin que correspondan a la hora inicio seleccionada
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                // Si no hay selección en inicio, limpio y deshabilito fin
                comboBox2.Items.Clear();
                comboBox2.SelectedIndex = -1;
                return;
            }

            string horaSeleccionadaStr = comboBox1.SelectedItem.ToString();
            TimeSpan horaSeleccionada = TimeSpan.Parse(horaSeleccionadaStr);

            // Filtro los horarios que tienen la misma hora inicio que seleccioné
            var horasFin = horariosDT.AsEnumerable()
                .Where(row => row.Field<TimeSpan>("hora_inicio") == horaSeleccionada)
                .Select(row => row.Field<TimeSpan>("hora_fin"))
                .OrderBy(t => t)
                .ToList();

            comboBox2.Items.Clear();
            foreach (var hora in horasFin)
            {
                comboBox2.Items.Add(hora.ToString(@"hh\:mm")); // Mostrar hh:mm también en fin
            }
            comboBox2.SelectedIndex = 0; // Selecciono la primera hora fin posible
        }

        // Botón para guardar alumno en BD junto con su registro (horarios, deporte, sede, grupo)
        private void button2_Click(object sender, EventArgs e)
        {
            // Tomo valores del formulario
            string nombre = IntNombre.Text.Trim();
            string apellido = IntApellido.Text.Trim();
            int edad = (int)IntNumericEdad.Value;
            string nss = IntNumericNNS.Value.ToString();
            DateTime fechaRegistro = DateRegistro.Value;

            // Validaciones básicas para no guardar datos incompletos o inválidos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, ingresa nombre y apellido.");
                return; // No sigo si falta info
            }
            if (SelectDeporte.SelectedValue == null || SelectSede.SelectedValue == null || SelectGrupo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona grupo, deporte y sede.");
                return;
            }
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona hora de inicio y hora de fin.");
                return;
            }

            // Conversión de valores a tipos necesarios para la BD
            int idDeporte = Convert.ToInt32(SelectDeporte.SelectedValue);
            int idSede = Convert.ToInt32(SelectSede.SelectedValue);
            int grupo = Convert.ToInt32(SelectGrupo.SelectedItem);

            TimeSpan horaInicio = TimeSpan.Parse(comboBox1.SelectedItem.ToString());
            TimeSpan horaFin = TimeSpan.Parse(comboBox2.SelectedItem.ToString());

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Primero inserto el alumno y obtengo su ID para usar en Registro
                    string queryAlumno = @"
                        INSERT INTO Alumnos (nombre, apellido_paterno, edad, nss, fecha_registro, estatus) 
                        VALUES (@nombre, @apellido, @edad, @nss, @fecha, 'activo'); 
                        SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(queryAlumno, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@nss", nss);
                    cmd.Parameters.AddWithValue("@fecha", fechaRegistro);

                    int idAlumno = Convert.ToInt32(cmd.ExecuteScalar()); // Aquí tengo el id generado

                    // Ahora inserto en la tabla Registro, que vincula al alumno con deporte, sede y horario
                    string queryRegistro = @"
                        INSERT INTO Registro (id_alumno, id_deporte, id_sede, id_horario, hora_inicio, hora_fin) 
                        VALUES (@idAlumno, @idDeporte, @idSede, @idHorario, @horaInicio, @horaFin);";

                    MySqlCommand cmd2 = new MySqlCommand(queryRegistro, conn);
                    cmd2.Parameters.AddWithValue("@idAlumno", idAlumno);
                    cmd2.Parameters.AddWithValue("@idDeporte", idDeporte);
                    cmd2.Parameters.AddWithValue("@idSede", idSede);

                    // Ojo, aquí asigno el grupo como idHorario. Esto es raro, debería revisar si el idHorario es otro campo
                    cmd2.Parameters.AddWithValue("@idHorario", grupo);

                    cmd2.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd2.Parameters.AddWithValue("@horaFin", horaFin);

                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Alumno registrado correctamente.");
                LimpiarCampos(); // Limpio formulario para nuevo registro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                // Aquí atrapo cualquier fallo de BD o conexión
            }
        }

        // Limpia todos los campos para que quede listo para un nuevo registro
        private void LimpiarCampos()
        {
            IntNombre.Clear();
            IntApellido.Clear();
            IntNumericEdad.Value = 5;          // Reinicio edad a mínimo permitido
            IntNumericNNS.Value = IntNumericNNS.Minimum;
            DateRegistro.Value = DateTime.Now;
            SelectGrupo.SelectedIndex = 0;     // Selecciono grupo 1 por defecto
            SelectDeporte.SelectedIndex = 0;
            SelectSede.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;       // Hora inicio primera disponible
            comboBox2.SelectedIndex = 0;       // Hora fin correspondiente
        }

        // Botón para abrir la ventana donde se visualizan alumnos registrados
        private void btn_ViualizarRegistros(object sender, EventArgs e)
        {
            AlumnosTabla visualizarAlumnostabla = new AlumnosTabla();
            visualizarAlumnostabla.ShowDialog(); // Abro la ventana de visualización
        }

        // Estos métodos vacíos son para evitar errores si algún evento está conectado en el diseñador pero no se usa.
        // Mejor los dejo para que no explote la app.
        private void Logo_Esquineado(object sender, EventArgs e) { }
        private void Texto_Nombre(object sender, EventArgs e) { }
        private void Int_Nombre(object sender, EventArgs e) { }
        private void Texto_Apellido(object sender, EventArgs e) { }
        private void Int_Apellido(object sender, EventArgs e) { }
        private void Texto_Edad(object sender, EventArgs e) { }
        private void Int_Numeric_Edad(object sender, EventArgs e) { }
        private void Texto_Grupo(object sender, EventArgs e) { }
        private void Select_Grupo(object sender, EventArgs e) { }
        private void Texto_Deporte(object sender, EventArgs e) { }
        private void Select_Deporte(object sender, EventArgs e) { }
        private void Texto_Sede(object sender, EventArgs e) { }
        private void Select_Sede(object sender, EventArgs e) { }
        private void Texto_NNS(object sender, EventArgs e) { }
        private void Int_Numeric_NNS(object sender, EventArgs e) { }
        private void Texto_FechaRegistro(object sender, EventArgs e) { }
        private void Date_Registro(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

    }
}

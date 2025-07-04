using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportK
{
    public partial class AlumnosTabla : Form
    {
        // Variables globales (atributos)
        private string connectionString = "server=127.0.0.1;port=3306;user id=root;password=Saido_0209;database=sportk;";
        private DataTable deportesDT, sedesDT;  // Para llenar combos de deportes y sedes
        private bool cargando = false;          // Controla carga inicial para evitar recargas innecesarias

        // Constructor: inicializa componentes y carga datos iniciales
        public AlumnosTabla()
        {
            InitializeComponent();
            cargando = true;

            CargarGrupos();   // Método para llenar combo de grupos
            CargarDeportes(); // Método para cargar deportes desde BD
            CargarSedes();    // Método para cargar sedes desde BD

            cargando = false;
            CargarDatos();    // Método para cargar alumnos con filtros

            // Eventos para recargar datos al cambiar filtros
            comboGrupo.SelectedIndexChanged += Filtro_Changed;
            comboDeporte.SelectedIndexChanged += Filtro_Changed;

            // Configuración inicial del DataGridView
            dataGridAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAlumnos.MultiSelect = false;
            dataGridAlumnos.AllowUserToAddRows = false;
            dataGridAlumnos.ReadOnly = true;
        }

        // Método: llena comboGrupo con opciones fijas
        private void CargarGrupos()
        {
            comboGrupo.Items.AddRange(new object[] { "Todos", "1", "2", "3" });
            comboGrupo.SelectedIndex = 0;
        }

        // Método: carga datos de deportes desde la BD y agrega opción "Todos"
        private void CargarDeportes()
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand("SELECT id_deporte, nombre_deporte FROM Deportes", conn);
            deportesDT = new DataTable();
            deportesDT.Load(cmd.ExecuteReader());

            // Insertar opción para mostrar todos los deportes
            var filaTodos = deportesDT.NewRow();
            filaTodos["id_deporte"] = 0;
            filaTodos["nombre_deporte"] = "Todos";
            deportesDT.Rows.InsertAt(filaTodos, 0);

            comboDeporte.DataSource = deportesDT;
            comboDeporte.DisplayMember = "nombre_deporte";
            comboDeporte.ValueMember = "id_deporte";
        }

        // Método: carga datos de sedes desde la BD para usarlos luego en combos
        private void CargarSedes()
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand("SELECT id_sede, nombre_sede FROM Sedes", conn);
            sedesDT = new DataTable();
            sedesDT.Load(cmd.ExecuteReader());
        }

        // Método: carga y muestra datos en DataGridView según filtros seleccionados
        private void CargarDatos()
        {
            string filtroGrupo = comboGrupo.SelectedItem?.ToString();
            int filtroDeporte = Convert.ToInt32(comboDeporte.SelectedValue ?? 0);

            string query = @"
                SELECT A.id_alumno, A.nombre, A.apellido_paterno, A.edad, A.nss, A.fecha_registro, A.estatus,
                       R.id_deporte, D.nombre_deporte,
                       R.id_sede, S.nombre_sede,
                       CONCAT(TIME_FORMAT(R.hora_inicio, '%H:%i'), ' - ', TIME_FORMAT(R.hora_fin, '%H:%i')) AS Horario
                FROM Alumnos A
                JOIN Registro R ON A.id_alumno = R.id_alumno
                JOIN Deportes D ON R.id_deporte = D.id_deporte
                JOIN Sedes S ON R.id_sede = S.id_sede
                WHERE 1=1";  // Base para agregar filtros dinámicos

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand { Connection = conn };

            // Si hay filtro de grupo (diferente a "Todos") agrego condición
            if (filtroGrupo != "Todos" && int.TryParse(filtroGrupo, out int grupo))
            {
                query += " AND R.id_horario = @grupoFiltro";
                cmd.Parameters.AddWithValue("@grupoFiltro", grupo);
            }

            // Si filtro deporte distinto a "Todos" agrego condición
            if (filtroDeporte != 0)
            {
                query += " AND R.id_deporte = @deporteFiltro";
                cmd.Parameters.AddWithValue("@deporteFiltro", filtroDeporte);
            }

            cmd.CommandText = query;
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            dataGridAlumnos.DataSource = dt;

            // Ocultar columnas ID para limpiar visualización
            foreach (string col in new[] { "id_alumno", "id_deporte", "id_sede" })
                if (dataGridAlumnos.Columns.Contains(col))
                    dataGridAlumnos.Columns[col].Visible = false;

            // Remover columnas repetidas antes de agregar combos
            foreach (string col in new[] { "Sede", "nombre_sede" })
                if (dataGridAlumnos.Columns.Contains(col))
                    dataGridAlumnos.Columns.Remove(col);

            // Agrego columna combo para seleccionar Sede
            var comboSedeCol = new DataGridViewComboBoxColumn()
            {
                Name = "Sede",
                HeaderText = "Sede",
                DataSource = sedesDT.Copy(),
                ValueMember = "id_sede",
                DisplayMember = "nombre_sede",
                DataPropertyName = "id_sede",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                FlatStyle = FlatStyle.Flat
            };
            dataGridAlumnos.Columns.Add(comboSedeCol);

            // Remover columnas repetidas para deporte antes de combo
            foreach (string col in new[] { "Deporte", "nombre_deporte" })
                if (dataGridAlumnos.Columns.Contains(col))
                    dataGridAlumnos.Columns.Remove(col);

            // Agrego columna combo para seleccionar Deporte
            var comboDeporteCol = new DataGridViewComboBoxColumn()
            {
                Name = "Deporte",
                HeaderText = "Deporte",
                DataSource = deportesDT.Copy(),
                ValueMember = "id_deporte",
                DisplayMember = "nombre_deporte",
                DataPropertyName = "id_deporte",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                FlatStyle = FlatStyle.Flat
            };
            dataGridAlumnos.Columns.Add(comboDeporteCol);

            // La columna Horario es solo lectura
            if (dataGridAlumnos.Columns.Contains("Horario"))
                dataGridAlumnos.Columns["Horario"].ReadOnly = true;

            dataGridAlumnos.AutoResizeColumns();
        }

        // Evento: se activa cuando cambia filtro, recarga datos si ya terminó carga inicial
        private void Filtro_Changed(object sender, EventArgs e)
        {
            if (!cargando)
                CargarDatos();
        }

        // Método: activa modo edición en el DataGridView
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            dataGridAlumnos.ReadOnly = false;
            MessageBox.Show("Modo edición activado. Modifica y guarda cambios.");
        }

        // Método: guarda los cambios hechos en el DataGridView en la base de datos
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                foreach (DataGridViewRow row in dataGridAlumnos.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["id_alumno"].Value);
                    string nombre = row.Cells["nombre"].Value.ToString();
                    string apellido = row.Cells["apellido_paterno"].Value.ToString();
                    int edad = Convert.ToInt32(row.Cells["edad"].Value);
                    string nss = row.Cells["nss"].Value.ToString();
                    string estatus = row.Cells["estatus"].Value.ToString();
                    int idSede = Convert.ToInt32(row.Cells["id_sede"].Value);
                    int idDeporte = Convert.ToInt32(row.Cells["id_deporte"].Value);

                    // Actualizo tabla Alumnos
                    var updateAlumno = new MySqlCommand(@"
                        UPDATE Alumnos 
                        SET nombre = @nombre, apellido_paterno = @apellido, edad = @edad, nss = @nss, estatus = @estatus 
                        WHERE id_alumno = @id", conn);

                    updateAlumno.Parameters.AddWithValue("@nombre", nombre);
                    updateAlumno.Parameters.AddWithValue("@apellido", apellido);
                    updateAlumno.Parameters.AddWithValue("@edad", edad);
                    updateAlumno.Parameters.AddWithValue("@nss", nss);
                    updateAlumno.Parameters.AddWithValue("@estatus", estatus);
                    updateAlumno.Parameters.AddWithValue("@id", id);
                    updateAlumno.ExecuteNonQuery();

                    // Actualizo tabla Registro
                    var updateRegistro = new MySqlCommand(@"
                        UPDATE Registro 
                        SET id_deporte = @idDeporte, id_sede = @idSede 
                        WHERE id_alumno = @id", conn);

                    updateRegistro.Parameters.AddWithValue("@id", id);
                    updateRegistro.Parameters.AddWithValue("@idDeporte", idDeporte);
                    updateRegistro.Parameters.AddWithValue("@idSede", idSede);
                    updateRegistro.ExecuteNonQuery();
                }

                MessageBox.Show("Cambios guardados correctamente.");
                dataGridAlumnos.ReadOnly = true;
                CargarDatos(); // Refresco datos para mostrar cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void VisualizarAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
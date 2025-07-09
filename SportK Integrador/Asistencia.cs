using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportK_Integrador
{
    public partial class Asistencia : Form
    {
        MySqlConnection conex = new MySqlConnection("server=127.0.0.1;port=3306;user id=root;password=Saido_0209;database=sportk;");
        MySqlDataAdapter adaptador;
        public Asistencia()
        {
            InitializeComponent();
            CargarAsistencia();
            CargarDeportes();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            CargarAsistencia();
            MostrarTablas();
        }

        private void Texto_Grupo(object sender, EventArgs e)
        {

        }

        private void Texto_Deporte(object sender, EventArgs e)
        {

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void Combo_Deporte(object sender, EventArgs e)
        {
            string deportesSeleccionado = ComboDeporte.SelectedItem.ToString();
            FiltrarAlumnosPorDeporte(deportesSeleccionado);
        }

        private void Combo_Grupo(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }
        private void Data_Gried_Info(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarAsistencia()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            DataTable dt = new DataTable();
            adaptador = new MySqlDataAdapter("SELECT * FROM asistencias", conex);
            adaptador.Fill(dt);
            DataGridInfo.DataSource = dt;
            conex.Close();
        }

        private void MostrarTablas()
        {

        }

        private void CargarDeportes()
        {
            string query = "SELECT DISTINCT deportes FROM alumnos";

            MySqlCommand comando = new MySqlCommand(query, conex);

            try
            {
                conex.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ComboDeporte.Items.Add(reader["deportes"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conex.State == ConnectionState.Open)
                    conex.Close();
            }
        }
        private void FiltrarAlumnosPorDeporte(string deportes)
        {
            string query = "SELECT id, nombre, apellido, edad, deportes FROM alumnos WHERE deportes = @deportes";

            MySqlCommand comando = new MySqlCommand(query, conex);
            comando.Parameters.AddWithValue("@deportes", deportes);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            try
            {
                conex.Open();
                adaptador.Fill(tabla);
                DataGridInfo.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conex.State == ConnectionState.Open)
                    conex.Close();
            }
        }

    }
}

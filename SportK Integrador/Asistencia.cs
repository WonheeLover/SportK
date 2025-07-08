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
        public Asistencia()
        {
            InitializeComponent();
        }

        private string connectionString = "server=127.0.0.1;port=3306;user id=root;password=Saido_0209;database=sportk;";

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

        private void Como_Deporte(object sender, EventArgs e)
        {

        }

        private void Combo_Grupo(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void CargarAsistencia()
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = "SELECT * FROM Asistencia"; // Ajusta las columnas si es necesario
            var cmd = new MySqlCommand(query, conn);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void MostrarTablas()
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = "SHOW TABLES IN sportk";
            var cmd = new MySqlCommand(query, conn);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            // Aquí puedes manejar los datos obtenidos, por ejemplo, mostrar en un control.
        }
    }
}

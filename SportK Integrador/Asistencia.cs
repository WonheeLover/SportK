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
            conex.Open();
            DataTable dt = new DataTable();
            adaptador = new MySqlDataAdapter("SELECT * FROM asistencias", conex);
            adaptador.Fill(dt);
            DataGridInfo.DataSource = dt;
            conex.Close();
        }

        private void MostrarTablas()
        {

        }

        private void Data_Gried_Info(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

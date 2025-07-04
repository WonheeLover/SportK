namespace SportK
{
    public partial class Menu_Ventana : Form
    {
        public Menu_Ventana()
        {
            InitializeComponent();
        }

        private void Ventana_Principal(object sender, EventArgs e)
        {

        }

        private void btn_Alumnos_Click(object sender, EventArgs e)
        {
            VentanaAlumnos ventanaAlumnos = new VentanaAlumnos();
            ventanaAlumnos.ShowDialog(); // Muestra la ventana de alumnos como prioridad
        }

        private void btn_Asistencia_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_Pagos_Click(object sender, EventArgs e)
        {

        }
        private void btn_Deportes_Click(object sender, EventArgs e)
        {

        }
        private void btn_Sedes_Click(object sender, EventArgs e)
        {

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logo_Menu_Click(object sender, EventArgs e)
        {

        }

    }
}
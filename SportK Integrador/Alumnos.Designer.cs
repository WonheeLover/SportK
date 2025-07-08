namespace SportK
{
    partial class VentanaAlumnos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Logo = new PictureBox();
            TextoNombre = new Label();
            IntNombre = new TextBox();
            TextoApellido = new Label();
            IntApellido = new TextBox();
            TextoEdad = new Label();
            TextoGrupo = new Label();
            TextoDeporte = new Label();
            TextoSede = new Label();
            TextoNNS = new Label();
            TextoFechaRegistro = new Label();
            SelectGrupo = new ComboBox();
            SelectDeporte = new ComboBox();
            SelectSede = new ComboBox();
            DateRegistro = new DateTimePicker();
            IntNumericEdad = new NumericUpDown();
            IntNumericNNS = new NumericUpDown();
            BtnGuardar = new Button();
            BtnVizualizarRegistros = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntNumericEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntNumericNNS).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = SportK_Integrador.Properties.Resources.SportK_Logo_Final;
            Logo.Location = new Point(911, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(139, 79);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 26;
            Logo.TabStop = false;
            // 
            // TextoNombre
            // 
            TextoNombre.AutoSize = true;
            TextoNombre.Font = new Font("Segoe UI", 11F);
            TextoNombre.Location = new Point(337, 50);
            TextoNombre.Name = "TextoNombre";
            TextoNombre.Size = new Size(81, 25);
            TextoNombre.TabIndex = 1;
            TextoNombre.Text = "Nombre";
            TextoNombre.Click += Texto_Nombre;
            // 
            // IntNombre
            // 
            IntNombre.Cursor = Cursors.IBeam;
            IntNombre.Location = new Point(450, 50);
            IntNombre.Name = "IntNombre";
            IntNombre.Size = new Size(169, 27);
            IntNombre.TabIndex = 2;
            IntNombre.TextChanged += Int_Nombre;
            // 
            // TextoApellido
            // 
            TextoApellido.AutoSize = true;
            TextoApellido.Font = new Font("Segoe UI", 11F);
            TextoApellido.Location = new Point(337, 115);
            TextoApellido.Name = "TextoApellido";
            TextoApellido.Size = new Size(82, 25);
            TextoApellido.TabIndex = 3;
            TextoApellido.Text = "Apellido";
            TextoApellido.Click += Texto_Apellido;
            // 
            // IntApellido
            // 
            IntApellido.Cursor = Cursors.IBeam;
            IntApellido.Location = new Point(450, 115);
            IntApellido.Name = "IntApellido";
            IntApellido.Size = new Size(169, 27);
            IntApellido.TabIndex = 4;
            IntApellido.TextChanged += Int_Apellido;
            // 
            // TextoEdad
            // 
            TextoEdad.AutoSize = true;
            TextoEdad.Font = new Font("Segoe UI", 11F);
            TextoEdad.Location = new Point(337, 178);
            TextoEdad.Name = "TextoEdad";
            TextoEdad.Size = new Size(54, 25);
            TextoEdad.TabIndex = 6;
            TextoEdad.Text = "Edad";
            TextoEdad.Click += Texto_Edad;
            // 
            // TextoGrupo
            // 
            TextoGrupo.AutoSize = true;
            TextoGrupo.Font = new Font("Segoe UI", 11F);
            TextoGrupo.Location = new Point(337, 242);
            TextoGrupo.Name = "TextoGrupo";
            TextoGrupo.Size = new Size(65, 25);
            TextoGrupo.TabIndex = 7;
            TextoGrupo.Text = "Grupo";
            TextoGrupo.Click += Texto_Grupo;
            // 
            // TextoDeporte
            // 
            TextoDeporte.AutoSize = true;
            TextoDeporte.Font = new Font("Segoe UI", 11F);
            TextoDeporte.Location = new Point(337, 293);
            TextoDeporte.Name = "TextoDeporte";
            TextoDeporte.Size = new Size(80, 25);
            TextoDeporte.TabIndex = 8;
            TextoDeporte.Text = "Deporte";
            TextoDeporte.Click += Texto_Deporte;
            // 
            // TextoSede
            // 
            TextoSede.AutoSize = true;
            TextoSede.Font = new Font("Segoe UI", 11F);
            TextoSede.Location = new Point(337, 353);
            TextoSede.Name = "TextoSede";
            TextoSede.Size = new Size(53, 25);
            TextoSede.TabIndex = 9;
            TextoSede.Text = "Sede";
            TextoSede.Click += Texto_Sede;
            // 
            // TextoNNS
            // 
            TextoNNS.AutoSize = true;
            TextoNNS.Font = new Font("Segoe UI", 11F);
            TextoNNS.Location = new Point(337, 410);
            TextoNNS.Name = "TextoNNS";
            TextoNNS.Size = new Size(50, 25);
            TextoNNS.TabIndex = 10;
            TextoNNS.Text = "NNS";
            TextoNNS.Click += Texto_NNS;
            // 
            // TextoFechaRegistro
            // 
            TextoFechaRegistro.AutoSize = true;
            TextoFechaRegistro.Font = new Font("Segoe UI", 11F);
            TextoFechaRegistro.Location = new Point(337, 457);
            TextoFechaRegistro.Name = "TextoFechaRegistro";
            TextoFechaRegistro.Size = new Size(108, 50);
            TextoFechaRegistro.TabIndex = 11;
            TextoFechaRegistro.Text = "Fecha \r\nDe Registro";
            TextoFechaRegistro.Click += Texto_FechaRegistro;
            // 
            // SelectGrupo
            // 
            SelectGrupo.FormattingEnabled = true;
            SelectGrupo.Location = new Point(450, 242);
            SelectGrupo.Name = "SelectGrupo";
            SelectGrupo.Size = new Size(121, 28);
            SelectGrupo.TabIndex = 12;
            SelectGrupo.SelectedIndexChanged += Select_Grupo;
            // 
            // SelectDeporte
            // 
            SelectDeporte.FormattingEnabled = true;
            SelectDeporte.Location = new Point(450, 293);
            SelectDeporte.Name = "SelectDeporte";
            SelectDeporte.Size = new Size(121, 28);
            SelectDeporte.TabIndex = 13;
            SelectDeporte.SelectedIndexChanged += Select_Deporte;
            // 
            // SelectSede
            // 
            SelectSede.FormattingEnabled = true;
            SelectSede.Location = new Point(450, 353);
            SelectSede.Name = "SelectSede";
            SelectSede.Size = new Size(121, 28);
            SelectSede.TabIndex = 14;
            SelectSede.SelectedIndexChanged += Select_Sede;
            // 
            // DateRegistro
            // 
            DateRegistro.Location = new Point(450, 484);
            DateRegistro.Name = "DateRegistro";
            DateRegistro.Size = new Size(303, 27);
            DateRegistro.TabIndex = 16;
            DateRegistro.Value = new DateTime(2025, 7, 3, 14, 13, 11, 374);
            DateRegistro.ValueChanged += Date_Registro;
            // 
            // IntNumericEdad
            // 
            IntNumericEdad.Location = new Point(450, 178);
            IntNumericEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IntNumericEdad.Name = "IntNumericEdad";
            IntNumericEdad.Size = new Size(70, 27);
            IntNumericEdad.TabIndex = 17;
            IntNumericEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IntNumericEdad.ValueChanged += Int_Numeric_Edad;
            // 
            // IntNumericNNS
            // 
            IntNumericNNS.Location = new Point(450, 410);
            IntNumericNNS.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            IntNumericNNS.Name = "IntNumericNNS";
            IntNumericNNS.Size = new Size(121, 27);
            IntNumericNNS.TabIndex = 18;
            IntNumericNNS.ValueChanged += Int_Numeric_NNS;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Segoe UI", 11F);
            BtnGuardar.Location = new Point(450, 573);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(179, 73);
            BtnGuardar.TabIndex = 20;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += button2_Click;
            // 
            // BtnVizualizarRegistros
            // 
            BtnVizualizarRegistros.Font = new Font("Segoe UI", 11F);
            BtnVizualizarRegistros.Location = new Point(871, 573);
            BtnVizualizarRegistros.Margin = new Padding(3, 4, 3, 4);
            BtnVizualizarRegistros.Name = "BtnVizualizarRegistros";
            BtnVizualizarRegistros.Size = new Size(179, 73);
            BtnVizualizarRegistros.TabIndex = 21;
            BtnVizualizarRegistros.Text = "Visualizar Registros";
            BtnVizualizarRegistros.UseVisualStyleBackColor = true;
            BtnVizualizarRegistros.Click += btn_ViualizarRegistros;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(781, 367);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 22;
            label1.Text = "Hora de inicio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(781, 414);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 23;
            label2.Text = "Hora de salida";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(929, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(929, 411);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 25;
            // 
            // VentanaAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnVizualizarRegistros);
            Controls.Add(BtnGuardar);
            Controls.Add(IntNumericNNS);
            Controls.Add(IntNumericEdad);
            Controls.Add(DateRegistro);
            Controls.Add(SelectSede);
            Controls.Add(SelectDeporte);
            Controls.Add(SelectGrupo);
            Controls.Add(TextoFechaRegistro);
            Controls.Add(TextoNNS);
            Controls.Add(TextoSede);
            Controls.Add(TextoDeporte);
            Controls.Add(TextoGrupo);
            Controls.Add(TextoEdad);
            Controls.Add(IntApellido);
            Controls.Add(TextoApellido);
            Controls.Add(IntNombre);
            Controls.Add(TextoNombre);
            Controls.Add(Logo);
            Name = "VentanaAlumnos";
            Text = "Registro de Alumnos";
            Load += VentanaAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntNumericEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntNumericNNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label TextoNombre;
        private TextBox IntNombre;
        private Label TextoApellido;
        private TextBox IntApellido;
        private Label TextoEdad;
        private Label TextoGrupo;
        private Label TextoDeporte;
        private Label TextoSede;
        private Label TextoNNS;
        private Label TextoFechaRegistro;
        private ComboBox SelectGrupo;
        private ComboBox SelectDeporte;
        private ComboBox SelectSede;
        private DateTimePicker DateRegistro;
        private NumericUpDown IntNumericEdad;
        private NumericUpDown IntNumericNNS;
        private Button BtnGuardar;
        private Button BtnVizualizarRegistros;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}

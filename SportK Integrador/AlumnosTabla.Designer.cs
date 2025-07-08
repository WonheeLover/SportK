namespace SportK
{
    partial class AlumnosTabla
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.ComboBox ComboGrupo;
        private System.Windows.Forms.ComboBox comboDeporte;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelDeporte;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridAlumnos = new DataGridView();
            ComboGrupo = new ComboBox();
            comboDeporte = new ComboBox();
            labelGrupo = new Label();
            labelDeporte = new Label();
            buttonEditar = new Button();
            buttonGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridAlumnos
            // 
            dataGridAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlumnos.Location = new Point(12, 68);
            dataGridAlumnos.Name = "dataGridAlumnos";
            dataGridAlumnos.RowHeadersWidth = 51;
            dataGridAlumnos.Size = new Size(1038, 544);
            dataGridAlumnos.TabIndex = 0;
            // 
            // ComboGrupo
            // 
            ComboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboGrupo.Font = new Font("Segoe UI", 10F);
            ComboGrupo.FormattingEnabled = true;
            ComboGrupo.Location = new Point(83, 22);
            ComboGrupo.Name = "ComboGrupo";
            ComboGrupo.Size = new Size(121, 31);
            ComboGrupo.TabIndex = 1;
            ComboGrupo.SelectedIndexChanged += comboGrupo_SelectedIndexChanged;
            // 
            // comboDeporte
            // 
            comboDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDeporte.Font = new Font("Segoe UI", 10F);
            comboDeporte.FormattingEnabled = true;
            comboDeporte.Location = new Point(316, 23);
            comboDeporte.Name = "comboDeporte";
            comboDeporte.Size = new Size(200, 31);
            comboDeporte.TabIndex = 2;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Segoe UI", 11F);
            labelGrupo.Location = new Point(12, 23);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(69, 25);
            labelGrupo.TabIndex = 3;
            labelGrupo.Text = "Grupo:";
            // 
            // labelDeporte
            // 
            labelDeporte.AutoSize = true;
            labelDeporte.Font = new Font("Segoe UI", 11F);
            labelDeporte.Location = new Point(226, 23);
            labelDeporte.Name = "labelDeporte";
            labelDeporte.Size = new Size(84, 25);
            labelDeporte.TabIndex = 4;
            labelDeporte.Text = "Deporte:";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(9, 618);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(109, 43);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(138, 618);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(109, 46);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // AlumnosTabla
            // 
            ClientSize = new Size(1062, 673);
            Controls.Add(dataGridAlumnos);
            Controls.Add(ComboGrupo);
            Controls.Add(comboDeporte);
            Controls.Add(labelGrupo);
            Controls.Add(labelDeporte);
            Controls.Add(buttonEditar);
            Controls.Add(buttonGuardar);
            Name = "AlumnosTabla";
            Text = "Visualizar Alumnos";
            Load += AlumnosTabla_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
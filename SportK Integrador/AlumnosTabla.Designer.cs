namespace SportK
{
    partial class AlumnosTabla
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.ComboBox comboGrupo;
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
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.comboDeporte = new System.Windows.Forms.ComboBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelDeporte = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                            | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(12, 60);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.Size = new System.Drawing.Size(760, 320);
            this.dataGridAlumnos.TabIndex = 0;

            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(66, 20);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(121, 23);
            this.comboGrupo.TabIndex = 1;

            // 
            // comboDeporte
            // 
            this.comboDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeporte.FormattingEnabled = true;
            this.comboDeporte.Location = new System.Drawing.Point(260, 20);
            this.comboDeporte.Name = "comboDeporte";
            this.comboDeporte.Size = new System.Drawing.Size(200, 23);
            this.comboDeporte.TabIndex = 2;

            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(12, 23);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(43, 15);
            this.labelGrupo.TabIndex = 3;
            this.labelGrupo.Text = "Grupo:";

            // 
            // labelDeporte
            // 
            this.labelDeporte.AutoSize = true;
            this.labelDeporte.Location = new System.Drawing.Point(210, 23);
            this.labelDeporte.Name = "labelDeporte";
            this.labelDeporte.Size = new System.Drawing.Size(52, 15);
            this.labelDeporte.TabIndex = 4;
            this.labelDeporte.Text = "Deporte:";

            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 400);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 30);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);

            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(120, 400);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 30);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar Cambios";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);

            // 
            // VisualizarAlumnos
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.dataGridAlumnos);
            this.Controls.Add(this.comboGrupo);
            this.Controls.Add(this.comboDeporte);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.labelDeporte);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "VisualizarAlumnos";
            this.Text = "Visualizar Alumnos";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
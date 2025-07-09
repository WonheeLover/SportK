namespace SportK_Integrador
{
    partial class Asistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextoGrupo = new Label();
            TextoDeporte = new Label();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            DataGridInfo = new DataGridView();
            ComboGrupo = new ComboBox();
            ComboDeporte = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridInfo).BeginInit();
            SuspendLayout();
            // 
            // TextoGrupo
            // 
            TextoGrupo.AutoSize = true;
            TextoGrupo.Font = new Font("Segoe UI", 11F);
            TextoGrupo.Location = new Point(41, 30);
            TextoGrupo.Name = "TextoGrupo";
            TextoGrupo.Size = new Size(69, 25);
            TextoGrupo.TabIndex = 0;
            TextoGrupo.Text = "Grupo:";
            TextoGrupo.Click += Texto_Grupo;
            // 
            // TextoDeporte
            // 
            TextoDeporte.AutoSize = true;
            TextoDeporte.Font = new Font("Segoe UI", 11F);
            TextoDeporte.Location = new Point(246, 33);
            TextoDeporte.Name = "TextoDeporte";
            TextoDeporte.Size = new Size(84, 25);
            TextoDeporte.TabIndex = 1;
            TextoDeporte.Text = "Deporte:";
            TextoDeporte.Click += Texto_Deporte;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(21, 631);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 30);
            BtnEditar.TabIndex = 7;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += Btn_Editar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(129, 631);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(120, 30);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar Cambios";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += Btn_Guardar_Click;
            // 
            // DataGridInfo
            // 
            DataGridInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridInfo.Location = new Point(41, 96);
            DataGridInfo.Name = "DataGridInfo";
            DataGridInfo.RowHeadersWidth = 51;
            DataGridInfo.Size = new Size(977, 517);
            DataGridInfo.TabIndex = 9;
            DataGridInfo.CellContentClick += Data_Gried_Info;
            // 
            // ComboGrupo
            // 
            ComboGrupo.FormattingEnabled = true;
            ComboGrupo.Location = new Point(116, 30);
            ComboGrupo.Name = "ComboGrupo";
            ComboGrupo.Size = new Size(93, 28);
            ComboGrupo.TabIndex = 10;
            ComboGrupo.SelectedIndexChanged += Combo_Grupo;
            // 
            // ComboDeporte
            // 
            ComboDeporte.FormattingEnabled = true;
            ComboDeporte.Location = new Point(345, 31);
            ComboDeporte.Name = "ComboDeporte";
            ComboDeporte.Size = new Size(139, 28);
            ComboDeporte.TabIndex = 11;
            ComboDeporte.SelectedIndexChanged += Combo_Deporte;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(ComboDeporte);
            Controls.Add(ComboGrupo);
            Controls.Add(DataGridInfo);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(TextoDeporte);
            Controls.Add(TextoGrupo);
            Name = "Asistencia";
            Text = "Asistencia";
            Load += Asistencia_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextoGrupo;
        private Label TextoDeporte;
        private Button BtnEditar;
        private Button BtnGuardar;
        private DataGridView DataGridInfo;
        private ComboBox ComboGrupo;
        private ComboBox ComboDeporte;
    }
}
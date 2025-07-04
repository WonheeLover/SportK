namespace SportK
{
    partial class Menu_Ventana
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logo_Menu = new PictureBox();
            btn_Alumnos = new Button();
            btn_Asistencia = new Button();
            btn_Pagos = new Button();
            btn_Deportes = new Button();
            btn_Sedes = new Button();
            btn_Salir = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo_Menu).BeginInit();
            SuspendLayout();
            // 
            // Logo_Menu
            // 
            Logo_Menu.Image = SportK_Integrador.Properties.Resources.SportK_Logo_Final;
            Logo_Menu.Location = new Point(267, 38);
            Logo_Menu.Name = "Logo_Menu";
            Logo_Menu.Size = new Size(573, 246);
            Logo_Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo_Menu.TabIndex = 0;
            Logo_Menu.TabStop = false;
            Logo_Menu.Click += Logo_Menu_Click;
            // 
            // btn_Alumnos
            // 
            btn_Alumnos.Font = new Font("Segoe UI", 11F);
            btn_Alumnos.Location = new Point(124, 350);
            btn_Alumnos.Name = "btn_Alumnos";
            btn_Alumnos.Size = new Size(231, 120);
            btn_Alumnos.TabIndex = 1;
            btn_Alumnos.Text = "Alumnos";
            btn_Alumnos.UseVisualStyleBackColor = true;
            btn_Alumnos.Click += btn_Alumnos_Click;
            // 
            // btn_Asistencia
            // 
            btn_Asistencia.Font = new Font("Segoe UI", 11F);
            btn_Asistencia.Location = new Point(432, 349);
            btn_Asistencia.Name = "btn_Asistencia";
            btn_Asistencia.Size = new Size(231, 122);
            btn_Asistencia.TabIndex = 2;
            btn_Asistencia.Text = "Asistencia";
            btn_Asistencia.UseVisualStyleBackColor = true;
            btn_Asistencia.Click += btn_Asistencia_Click;
            // 
            // btn_Pagos
            // 
            btn_Pagos.Font = new Font("Segoe UI", 11F);
            btn_Pagos.Location = new Point(731, 349);
            btn_Pagos.Name = "btn_Pagos";
            btn_Pagos.Size = new Size(231, 122);
            btn_Pagos.TabIndex = 3;
            btn_Pagos.Text = "Pagos";
            btn_Pagos.UseVisualStyleBackColor = true;
            btn_Pagos.Click += btn_Pagos_Click;
            // 
            // btn_Deportes
            // 
            btn_Deportes.Font = new Font("Segoe UI", 11F);
            btn_Deportes.Location = new Point(124, 496);
            btn_Deportes.Name = "btn_Deportes";
            btn_Deportes.Size = new Size(231, 120);
            btn_Deportes.TabIndex = 4;
            btn_Deportes.Text = "Deportes";
            btn_Deportes.UseVisualStyleBackColor = true;
            btn_Deportes.Click += btn_Deportes_Click;
            // 
            // btn_Sedes
            // 
            btn_Sedes.Font = new Font("Segoe UI", 11F);
            btn_Sedes.Location = new Point(432, 496);
            btn_Sedes.Name = "btn_Sedes";
            btn_Sedes.Size = new Size(231, 120);
            btn_Sedes.TabIndex = 5;
            btn_Sedes.Text = "Sedes";
            btn_Sedes.UseVisualStyleBackColor = true;
            btn_Sedes.Click += btn_Sedes_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI", 11F);
            btn_Salir.Location = new Point(731, 496);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(231, 120);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // Menu_Ventana
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Sedes);
            Controls.Add(btn_Deportes);
            Controls.Add(btn_Pagos);
            Controls.Add(btn_Asistencia);
            Controls.Add(btn_Alumnos);
            Controls.Add(Logo_Menu);
            Name = "Menu_Ventana";
            Text = "Principal";
            Load += Ventana_Principal;
            ((System.ComponentModel.ISupportInitialize)Logo_Menu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo_Menu;
        private Button btn_Alumnos;
        private Button btn_Asistencia;
        private Button btn_Pagos;
        private Button btn_Deportes;
        private Button btn_Sedes;
        private Button btn_Salir;
    }
}
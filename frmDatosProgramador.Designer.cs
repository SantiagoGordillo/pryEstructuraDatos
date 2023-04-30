namespace pryEstructuraDatos
{
    partial class frmDatosProgramador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosProgramador));
            this.pbProgramador = new System.Windows.Forms.PictureBox();
            this.lblNombreProgramador = new System.Windows.Forms.Label();
            this.lblDNIProgramador = new System.Windows.Forms.Label();
            this.lblMateriaProgramador = new System.Windows.Forms.Label();
            this.lblCarreraProgramador = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgramador)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProgramador
            // 
            this.pbProgramador.Image = ((System.Drawing.Image)(resources.GetObject("pbProgramador.Image")));
            this.pbProgramador.Location = new System.Drawing.Point(58, 38);
            this.pbProgramador.Name = "pbProgramador";
            this.pbProgramador.Size = new System.Drawing.Size(183, 295);
            this.pbProgramador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProgramador.TabIndex = 0;
            this.pbProgramador.TabStop = false;
            // 
            // lblNombreProgramador
            // 
            this.lblNombreProgramador.AutoSize = true;
            this.lblNombreProgramador.Location = new System.Drawing.Point(267, 106);
            this.lblNombreProgramador.Name = "lblNombreProgramador";
            this.lblNombreProgramador.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProgramador.TabIndex = 1;
            this.lblNombreProgramador.Text = "Nombre:";
            // 
            // lblDNIProgramador
            // 
            this.lblDNIProgramador.AutoSize = true;
            this.lblDNIProgramador.Location = new System.Drawing.Point(267, 68);
            this.lblDNIProgramador.Name = "lblDNIProgramador";
            this.lblDNIProgramador.Size = new System.Drawing.Size(41, 20);
            this.lblDNIProgramador.TabIndex = 2;
            this.lblDNIProgramador.Text = "DNI:";
            // 
            // lblMateriaProgramador
            // 
            this.lblMateriaProgramador.AutoSize = true;
            this.lblMateriaProgramador.Location = new System.Drawing.Point(267, 145);
            this.lblMateriaProgramador.Name = "lblMateriaProgramador";
            this.lblMateriaProgramador.Size = new System.Drawing.Size(66, 20);
            this.lblMateriaProgramador.TabIndex = 3;
            this.lblMateriaProgramador.Text = "Materia:";
            // 
            // lblCarreraProgramador
            // 
            this.lblCarreraProgramador.AutoSize = true;
            this.lblCarreraProgramador.Location = new System.Drawing.Point(267, 185);
            this.lblCarreraProgramador.Name = "lblCarreraProgramador";
            this.lblCarreraProgramador.Size = new System.Drawing.Size(66, 20);
            this.lblCarreraProgramador.TabIndex = 4;
            this.lblCarreraProgramador.Text = "Carrera:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(348, 185);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(14, 20);
            this.lblCarrera.TabIndex = 8;
            this.lblCarrera.Text = "-";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(348, 145);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(14, 20);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(348, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(14, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "-";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(348, 68);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(14, 20);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "-";
            // 
            // frmDatosProgramador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(526, 365);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCarreraProgramador);
            this.Controls.Add(this.lblMateriaProgramador);
            this.Controls.Add(this.lblDNIProgramador);
            this.Controls.Add(this.lblNombreProgramador);
            this.Controls.Add(this.pbProgramador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatosProgramador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Programador";
            this.Load += new System.EventHandler(this.frmDatosProgramador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgramador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProgramador;
        private System.Windows.Forms.Label lblNombreProgramador;
        private System.Windows.Forms.Label lblDNIProgramador;
        private System.Windows.Forms.Label lblMateriaProgramador;
        private System.Windows.Forms.Label lblCarreraProgramador;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
    }
}
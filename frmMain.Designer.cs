namespace pryEstructuraDatos
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatosProgramador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPilas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDobles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArbolBinario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaseDeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperacionesConBaseDeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiconsultaSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRepasoDeOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSistema,
            this.tsmiLineales,
            this.tsmiNoLineales,
            this.tsmiBaseDeDatos});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(680, 33);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiSistema
            // 
            this.tsmiSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatosProgramador,
            this.tsmiSalir});
            this.tsmiSistema.Name = "tsmiSistema";
            this.tsmiSistema.Size = new System.Drawing.Size(90, 29);
            this.tsmiSistema.Text = "Sistema";
            // 
            // tsmiDatosProgramador
            // 
            this.tsmiDatosProgramador.Name = "tsmiDatosProgramador";
            this.tsmiDatosProgramador.Size = new System.Drawing.Size(272, 34);
            this.tsmiDatosProgramador.Text = "Datos Programador";
            this.tsmiDatosProgramador.Click += new System.EventHandler(this.tmsiDatosProgramador_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(272, 34);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tmsiSalir_Click);
            // 
            // tsmiLineales
            // 
            this.tsmiLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPilas,
            this.tsmiColas,
            this.tsmiListas});
            this.tsmiLineales.Name = "tsmiLineales";
            this.tsmiLineales.Size = new System.Drawing.Size(89, 29);
            this.tsmiLineales.Text = "Lineales";
            // 
            // tsmiPilas
            // 
            this.tsmiPilas.Name = "tsmiPilas";
            this.tsmiPilas.Size = new System.Drawing.Size(157, 34);
            this.tsmiPilas.Text = "Pilas";
            this.tsmiPilas.Click += new System.EventHandler(this.tmsiPilas_Click);
            // 
            // tsmiColas
            // 
            this.tsmiColas.Name = "tsmiColas";
            this.tsmiColas.Size = new System.Drawing.Size(157, 34);
            this.tsmiColas.Text = "Colas";
            this.tsmiColas.Click += new System.EventHandler(this.tmsiColas_Click);
            // 
            // tsmiListas
            // 
            this.tsmiListas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSimples,
            this.tsmiDobles});
            this.tsmiListas.Name = "tsmiListas";
            this.tsmiListas.Size = new System.Drawing.Size(157, 34);
            this.tsmiListas.Text = "Listas";
            // 
            // tsmiSimples
            // 
            this.tsmiSimples.Name = "tsmiSimples";
            this.tsmiSimples.Size = new System.Drawing.Size(176, 34);
            this.tsmiSimples.Text = "Simples";
            this.tsmiSimples.Click += new System.EventHandler(this.tmsiSimples_Click);
            // 
            // tsmiDobles
            // 
            this.tsmiDobles.Name = "tsmiDobles";
            this.tsmiDobles.Size = new System.Drawing.Size(176, 34);
            this.tsmiDobles.Text = "Dobles";
            this.tsmiDobles.Click += new System.EventHandler(this.tmsiDobles_Click);
            // 
            // tsmiNoLineales
            // 
            this.tsmiNoLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArbolBinario,
            this.tsmiGrafo});
            this.tsmiNoLineales.Name = "tsmiNoLineales";
            this.tsmiNoLineales.Size = new System.Drawing.Size(118, 29);
            this.tsmiNoLineales.Text = "No Lineales";
            // 
            // tsmiArbolBinario
            // 
            this.tsmiArbolBinario.Name = "tsmiArbolBinario";
            this.tsmiArbolBinario.Size = new System.Drawing.Size(217, 34);
            this.tsmiArbolBinario.Text = "Arbol Binario";
            this.tsmiArbolBinario.Click += new System.EventHandler(this.tmsiArbolBinario_Click);
            // 
            // tsmiGrafo
            // 
            this.tsmiGrafo.Name = "tsmiGrafo";
            this.tsmiGrafo.Size = new System.Drawing.Size(217, 34);
            this.tsmiGrafo.Text = "Grafos";
            // 
            // tsmiBaseDeDatos
            // 
            this.tsmiBaseDeDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOperacionesConBaseDeDatos,
            this.tsmiconsultaSQL,
            this.tsSeparator1,
            this.tsmiRepasoDeOperaciones});
            this.tsmiBaseDeDatos.Name = "tsmiBaseDeDatos";
            this.tsmiBaseDeDatos.Size = new System.Drawing.Size(141, 29);
            this.tsmiBaseDeDatos.Text = "Base de Datos";
            // 
            // tsmiOperacionesConBaseDeDatos
            // 
            this.tsmiOperacionesConBaseDeDatos.Name = "tsmiOperacionesConBaseDeDatos";
            this.tsmiOperacionesConBaseDeDatos.Size = new System.Drawing.Size(365, 34);
            this.tsmiOperacionesConBaseDeDatos.Text = "Operaciones con Base de Datos";
            this.tsmiOperacionesConBaseDeDatos.Click += new System.EventHandler(this.operacionesConBDToolStripMenuItem_Click);
            // 
            // tsmiconsultaSQL
            // 
            this.tsmiconsultaSQL.Name = "tsmiconsultaSQL";
            this.tsmiconsultaSQL.Size = new System.Drawing.Size(365, 34);
            this.tsmiconsultaSQL.Text = "Consulta SQL";
            this.tsmiconsultaSQL.Click += new System.EventHandler(this.consultaSQLToolStripMenuItem_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(362, 6);
            // 
            // tsmiRepasoDeOperaciones
            // 
            this.tsmiRepasoDeOperaciones.Name = "tsmiRepasoDeOperaciones";
            this.tsmiRepasoDeOperaciones.Size = new System.Drawing.Size(365, 34);
            this.tsmiRepasoDeOperaciones.Text = "Repaso de Operaciones";
            this.tsmiRepasoDeOperaciones.Click += new System.EventHandler(this.repasoDeOperacionesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(680, 449);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatosProgramador;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineales;
        private System.Windows.Forms.ToolStripMenuItem tsmiNoLineales;
        private System.Windows.Forms.ToolStripMenuItem tsmiPilas;
        private System.Windows.Forms.ToolStripMenuItem tsmiColas;
        private System.Windows.Forms.ToolStripMenuItem tsmiListas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSimples;
        private System.Windows.Forms.ToolStripMenuItem tsmiDobles;
        private System.Windows.Forms.ToolStripMenuItem tsmiArbolBinario;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrafo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaseDeDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperacionesConBaseDeDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmiconsultaSQL;
        private System.Windows.Forms.ToolStripMenuItem tsmiRepasoDeOperaciones;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
    }
}


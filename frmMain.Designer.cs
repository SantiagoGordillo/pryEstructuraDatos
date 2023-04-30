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
            this.tmsiSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDatosProgramador = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiPilas = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiColas = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiListas = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDobles = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiNoLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiArbolBinario = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiGrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiSistema,
            this.tmsiLineales,
            this.tmsiNoLineales});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(680, 33);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tmsiSistema
            // 
            this.tmsiSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiDatosProgramador,
            this.tmsiSalir});
            this.tmsiSistema.Name = "tmsiSistema";
            this.tmsiSistema.Size = new System.Drawing.Size(90, 29);
            this.tmsiSistema.Text = "Sistema";
            // 
            // tmsiDatosProgramador
            // 
            this.tmsiDatosProgramador.Name = "tmsiDatosProgramador";
            this.tmsiDatosProgramador.Size = new System.Drawing.Size(272, 34);
            this.tmsiDatosProgramador.Text = "Datos Programador";
            this.tmsiDatosProgramador.Click += new System.EventHandler(this.tmsiDatosProgramador_Click);
            // 
            // tmsiSalir
            // 
            this.tmsiSalir.Name = "tmsiSalir";
            this.tmsiSalir.Size = new System.Drawing.Size(272, 34);
            this.tmsiSalir.Text = "Salir";
            this.tmsiSalir.Click += new System.EventHandler(this.tmsiSalir_Click);
            // 
            // tmsiLineales
            // 
            this.tmsiLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiPilas,
            this.tmsiColas,
            this.tmsiListas});
            this.tmsiLineales.Name = "tmsiLineales";
            this.tmsiLineales.Size = new System.Drawing.Size(89, 29);
            this.tmsiLineales.Text = "Lineales";
            // 
            // tmsiPilas
            // 
            this.tmsiPilas.Name = "tmsiPilas";
            this.tmsiPilas.Size = new System.Drawing.Size(157, 34);
            this.tmsiPilas.Text = "Pilas";
            this.tmsiPilas.Click += new System.EventHandler(this.tmsiPilas_Click);
            // 
            // tmsiColas
            // 
            this.tmsiColas.Name = "tmsiColas";
            this.tmsiColas.Size = new System.Drawing.Size(157, 34);
            this.tmsiColas.Text = "Colas";
            this.tmsiColas.Click += new System.EventHandler(this.tmsiColas_Click);
            // 
            // tmsiListas
            // 
            this.tmsiListas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiSimples,
            this.tmsiDobles});
            this.tmsiListas.Name = "tmsiListas";
            this.tmsiListas.Size = new System.Drawing.Size(157, 34);
            this.tmsiListas.Text = "Listas";
            // 
            // tmsiSimples
            // 
            this.tmsiSimples.Name = "tmsiSimples";
            this.tmsiSimples.Size = new System.Drawing.Size(176, 34);
            this.tmsiSimples.Text = "Simples";
            this.tmsiSimples.Click += new System.EventHandler(this.tmsiSimples_Click);
            // 
            // tmsiDobles
            // 
            this.tmsiDobles.Name = "tmsiDobles";
            this.tmsiDobles.Size = new System.Drawing.Size(176, 34);
            this.tmsiDobles.Text = "Dobles";
            this.tmsiDobles.Click += new System.EventHandler(this.tmsiDobles_Click);
            // 
            // tmsiNoLineales
            // 
            this.tmsiNoLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiArbolBinario,
            this.tmsiGrafo});
            this.tmsiNoLineales.Name = "tmsiNoLineales";
            this.tmsiNoLineales.Size = new System.Drawing.Size(118, 29);
            this.tmsiNoLineales.Text = "No Lineales";
            // 
            // tmsiArbolBinario
            // 
            this.tmsiArbolBinario.Name = "tmsiArbolBinario";
            this.tmsiArbolBinario.Size = new System.Drawing.Size(270, 34);
            this.tmsiArbolBinario.Text = "Arbol Binario";
            this.tmsiArbolBinario.Click += new System.EventHandler(this.tmsiArbolBinario_Click);
            // 
            // tmsiGrafo
            // 
            this.tmsiGrafo.Name = "tmsiGrafo";
            this.tmsiGrafo.Size = new System.Drawing.Size(270, 34);
            this.tmsiGrafo.Text = "Grafos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 449);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tmsiSistema;
        private System.Windows.Forms.ToolStripMenuItem tmsiDatosProgramador;
        private System.Windows.Forms.ToolStripMenuItem tmsiSalir;
        private System.Windows.Forms.ToolStripMenuItem tmsiLineales;
        private System.Windows.Forms.ToolStripMenuItem tmsiNoLineales;
        private System.Windows.Forms.ToolStripMenuItem tmsiPilas;
        private System.Windows.Forms.ToolStripMenuItem tmsiColas;
        private System.Windows.Forms.ToolStripMenuItem tmsiListas;
        private System.Windows.Forms.ToolStripMenuItem tmsiSimples;
        private System.Windows.Forms.ToolStripMenuItem tmsiDobles;
        private System.Windows.Forms.ToolStripMenuItem tmsiArbolBinario;
        private System.Windows.Forms.ToolStripMenuItem tmsiGrafo;
    }
}


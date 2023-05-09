
namespace pryEstructuraDatos
{
    partial class frmEstructuraDinamicaLinealListaEnlazadaSimple
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
            this.mrcListaGrilla = new System.Windows.Forms.GroupBox();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.dgvcCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTrámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcElementosEliminados = new System.Windows.Forms.GroupBox();
            this.cbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.mrcNuevosElementos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigoNuevo = new System.Windows.Forms.MaskedTextBox();
            this.mrcListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.mrcElementosEliminados.SuspendLayout();
            this.mrcNuevosElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListaGrilla
            // 
            this.mrcListaGrilla.BackColor = System.Drawing.Color.Transparent;
            this.mrcListaGrilla.Controls.Add(this.lsbLista);
            this.mrcListaGrilla.Controls.Add(this.dgvGrilla);
            this.mrcListaGrilla.Location = new System.Drawing.Point(21, 365);
            this.mrcListaGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcListaGrilla.Name = "mrcListaGrilla";
            this.mrcListaGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcListaGrilla.Size = new System.Drawing.Size(874, 315);
            this.mrcListaGrilla.TabIndex = 6;
            this.mrcListaGrilla.TabStop = false;
            this.mrcListaGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 20;
            this.lsbLista.Location = new System.Drawing.Point(9, 29);
            this.lsbLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(338, 264);
            this.lsbLista.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCódigo,
            this.dgvcNombre,
            this.dgvcTrámite});
            this.dgvGrilla.Location = new System.Drawing.Point(358, 29);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.Size = new System.Drawing.Size(508, 266);
            this.dgvGrilla.TabIndex = 0;
            // 
            // dgvcCódigo
            // 
            this.dgvcCódigo.HeaderText = "Código";
            this.dgvcCódigo.MinimumWidth = 8;
            this.dgvcCódigo.Name = "dgvcCódigo";
            this.dgvcCódigo.ReadOnly = true;
            this.dgvcCódigo.Width = 95;
            // 
            // dgvcNombre
            // 
            this.dgvcNombre.HeaderText = "Nombre";
            this.dgvcNombre.MinimumWidth = 8;
            this.dgvcNombre.Name = "dgvcNombre";
            this.dgvcNombre.ReadOnly = true;
            this.dgvcNombre.Width = 101;
            // 
            // dgvcTrámite
            // 
            this.dgvcTrámite.HeaderText = "Trámite";
            this.dgvcTrámite.MinimumWidth = 8;
            this.dgvcTrámite.Name = "dgvcTrámite";
            this.dgvcTrámite.ReadOnly = true;
            this.dgvcTrámite.Width = 98;
            // 
            // mrcElementosEliminados
            // 
            this.mrcElementosEliminados.BackColor = System.Drawing.Color.Transparent;
            this.mrcElementosEliminados.Controls.Add(this.cbEliminar);
            this.mrcElementosEliminados.Controls.Add(this.btnEliminar);
            this.mrcElementosEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementosEliminados.Location = new System.Drawing.Point(630, 23);
            this.mrcElementosEliminados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcElementosEliminados.Name = "mrcElementosEliminados";
            this.mrcElementosEliminados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcElementosEliminados.Size = new System.Drawing.Size(266, 331);
            this.mrcElementosEliminados.TabIndex = 5;
            this.mrcElementosEliminados.TabStop = false;
            this.mrcElementosEliminados.Text = "Elemento Eliminados";
            // 
            // cbEliminar
            // 
            this.cbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(80, 109);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(175, 28);
            this.cbEliminar.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 258);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(248, 48);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(9, 114);
            this.lblCodigoEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoEliminar.TabIndex = 5;
            this.lblCodigoEliminar.Text = "Código";
            // 
            // mrcNuevosElementos
            // 
            this.mrcNuevosElementos.BackColor = System.Drawing.Color.Transparent;
            this.mrcNuevosElementos.Controls.Add(this.txtCodigoNuevo);
            this.mrcNuevosElementos.Controls.Add(this.btnAgregar);
            this.mrcNuevosElementos.Controls.Add(this.txtTramiteNuevo);
            this.mrcNuevosElementos.Controls.Add(this.txtNombreNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblCodigoNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblNombreNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblTramiteNuevo);
            this.mrcNuevosElementos.Location = new System.Drawing.Point(352, 23);
            this.mrcNuevosElementos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcNuevosElementos.Name = "mrcNuevosElementos";
            this.mrcNuevosElementos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcNuevosElementos.Size = new System.Drawing.Size(266, 331);
            this.mrcNuevosElementos.TabIndex = 4;
            this.mrcNuevosElementos.TabStop = false;
            this.mrcNuevosElementos.Text = "Nuevos Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 258);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(248, 48);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramiteNuevo.Location = new System.Drawing.Point(98, 171);
            this.txtTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(148, 26);
            this.txtTramiteNuevo.TabIndex = 4;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreNuevo.Location = new System.Drawing.Point(98, 103);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(148, 26);
            this.txtNombreNuevo.TabIndex = 3;
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(22, 40);
            this.lblCodigoNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoNuevo.TabIndex = 2;
            this.lblCodigoNuevo.Text = "Código";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(22, 108);
            this.lblNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(65, 20);
            this.lblNombreNuevo.TabIndex = 3;
            this.lblNombreNuevo.Text = "Nombre";
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(22, 175);
            this.lblTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblTramiteNuevo.TabIndex = 4;
            this.lblTramiteNuevo.Text = "Trámite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDatos.Properties.Resources.ed5;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoNuevo.Location = new System.Drawing.Point(98, 38);
            this.txtCodigoNuevo.Mask = "999999";
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigoNuevo.TabIndex = 3;
            this.txtCodigoNuevo.ValidatingType = typeof(int);
            // 
            // frmEstructuraDinamicaLinealListaEnlazadaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(922, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcListaGrilla);
            this.Controls.Add(this.mrcElementosEliminados);
            this.Controls.Add(this.mrcNuevosElementos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstructuraDinamicaLinealListaEnlazadaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista enlazada simple";
            this.mrcListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.mrcElementosEliminados.ResumeLayout(false);
            this.mrcElementosEliminados.PerformLayout();
            this.mrcNuevosElementos.ResumeLayout(false);
            this.mrcNuevosElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcListaGrilla;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTrámite;
        private System.Windows.Forms.GroupBox mrcElementosEliminados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcNuevosElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtCodigoNuevo;
    }
}
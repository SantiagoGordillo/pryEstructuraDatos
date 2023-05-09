namespace pryEstructuraDatos
{
    partial class frmEstructuraDinamicaLinealPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraDinamicaLinealPila));
            this.pbRepresentacionFila = new System.Windows.Forms.PictureBox();
            this.mrcListaGrilla = new System.Windows.Forms.GroupBox();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.dgvcCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTrámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcElementosEliminados = new System.Windows.Forms.GroupBox();
            this.txtTramiteEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.lblTramiteElimina = new System.Windows.Forms.Label();
            this.lblNombreElimina = new System.Windows.Forms.Label();
            this.mrcNuevosElementos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepresentacionFila)).BeginInit();
            this.mrcListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.mrcElementosEliminados.SuspendLayout();
            this.mrcNuevosElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRepresentacionFila
            // 
            this.pbRepresentacionFila.Image = ((System.Drawing.Image)(resources.GetObject("pbRepresentacionFila.Image")));
            this.pbRepresentacionFila.Location = new System.Drawing.Point(9, 9);
            this.pbRepresentacionFila.Name = "pbRepresentacionFila";
            this.pbRepresentacionFila.Size = new System.Drawing.Size(217, 218);
            this.pbRepresentacionFila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRepresentacionFila.TabIndex = 7;
            this.pbRepresentacionFila.TabStop = false;
            // 
            // mrcListaGrilla
            // 
            this.mrcListaGrilla.BackColor = System.Drawing.Color.Transparent;
            this.mrcListaGrilla.Controls.Add(this.lsbLista);
            this.mrcListaGrilla.Controls.Add(this.dgvGrilla);
            this.mrcListaGrilla.Location = new System.Drawing.Point(11, 235);
            this.mrcListaGrilla.Name = "mrcListaGrilla";
            this.mrcListaGrilla.Size = new System.Drawing.Size(583, 205);
            this.mrcListaGrilla.TabIndex = 6;
            this.mrcListaGrilla.TabStop = false;
            this.mrcListaGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.Location = new System.Drawing.Point(6, 19);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(227, 173);
            this.lsbLista.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCódigo,
            this.dgvcNombre,
            this.dgvcTrámite});
            this.dgvGrilla.Location = new System.Drawing.Point(239, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.Size = new System.Drawing.Size(339, 173);
            this.dgvGrilla.TabIndex = 0;
            // 
            // dgvcCódigo
            // 
            this.dgvcCódigo.HeaderText = "Código";
            this.dgvcCódigo.MinimumWidth = 8;
            this.dgvcCódigo.Name = "dgvcCódigo";
            this.dgvcCódigo.ReadOnly = true;
            this.dgvcCódigo.Width = 150;
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
            this.dgvcTrámite.Width = 150;
            // 
            // mrcElementosEliminados
            // 
            this.mrcElementosEliminados.BackColor = System.Drawing.Color.Transparent;
            this.mrcElementosEliminados.Controls.Add(this.txtTramiteEliminar);
            this.mrcElementosEliminados.Controls.Add(this.btnEliminar);
            this.mrcElementosEliminados.Controls.Add(this.txtNombreEliminar);
            this.mrcElementosEliminados.Controls.Add(this.txtCodigoEliminar);
            this.mrcElementosEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementosEliminados.Controls.Add(this.lblTramiteElimina);
            this.mrcElementosEliminados.Controls.Add(this.lblNombreElimina);
            this.mrcElementosEliminados.Location = new System.Drawing.Point(417, 12);
            this.mrcElementosEliminados.Name = "mrcElementosEliminados";
            this.mrcElementosEliminados.Size = new System.Drawing.Size(177, 215);
            this.mrcElementosEliminados.TabIndex = 5;
            this.mrcElementosEliminados.TabStop = false;
            this.mrcElementosEliminados.Text = "Elemento Eliminados";
            // 
            // txtTramiteEliminar
            // 
            this.txtTramiteEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramiteEliminar.Enabled = false;
            this.txtTramiteEliminar.Location = new System.Drawing.Point(58, 111);
            this.txtTramiteEliminar.Name = "txtTramiteEliminar";
            this.txtTramiteEliminar.Size = new System.Drawing.Size(99, 20);
            this.txtTramiteEliminar.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 31);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEliminar.Enabled = false;
            this.txtNombreEliminar.Location = new System.Drawing.Point(58, 67);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(99, 20);
            this.txtNombreEliminar.TabIndex = 7;
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoEliminar.Enabled = false;
            this.txtCodigoEliminar.Location = new System.Drawing.Point(58, 23);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(99, 20);
            this.txtCodigoEliminar.TabIndex = 6;
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(8, 26);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEliminar.TabIndex = 5;
            this.lblCodigoEliminar.Text = "Código";
            // 
            // lblTramiteElimina
            // 
            this.lblTramiteElimina.AutoSize = true;
            this.lblTramiteElimina.Location = new System.Drawing.Point(8, 114);
            this.lblTramiteElimina.Name = "lblTramiteElimina";
            this.lblTramiteElimina.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteElimina.TabIndex = 10;
            this.lblTramiteElimina.Text = "Trámite";
            // 
            // lblNombreElimina
            // 
            this.lblNombreElimina.AutoSize = true;
            this.lblNombreElimina.Location = new System.Drawing.Point(8, 70);
            this.lblNombreElimina.Name = "lblNombreElimina";
            this.lblNombreElimina.Size = new System.Drawing.Size(44, 13);
            this.lblNombreElimina.TabIndex = 8;
            this.lblNombreElimina.Text = "Nombre";
            // 
            // mrcNuevosElementos
            // 
            this.mrcNuevosElementos.BackColor = System.Drawing.Color.Transparent;
            this.mrcNuevosElementos.Controls.Add(this.btnAgregar);
            this.mrcNuevosElementos.Controls.Add(this.txtTramiteNuevo);
            this.mrcNuevosElementos.Controls.Add(this.txtNombreNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblCodigoNuevo);
            this.mrcNuevosElementos.Controls.Add(this.txtCodigoNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblNombreNuevo);
            this.mrcNuevosElementos.Controls.Add(this.lblTramiteNuevo);
            this.mrcNuevosElementos.Location = new System.Drawing.Point(232, 12);
            this.mrcNuevosElementos.Name = "mrcNuevosElementos";
            this.mrcNuevosElementos.Size = new System.Drawing.Size(177, 215);
            this.mrcNuevosElementos.TabIndex = 4;
            this.mrcNuevosElementos.TabStop = false;
            this.mrcNuevosElementos.Text = "Nuevos Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 168);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramiteNuevo.Location = new System.Drawing.Point(65, 111);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(99, 20);
            this.txtTramiteNuevo.TabIndex = 4;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreNuevo.Location = new System.Drawing.Point(65, 67);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(99, 20);
            this.txtNombreNuevo.TabIndex = 3;
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(15, 26);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoNuevo.TabIndex = 2;
            this.lblCodigoNuevo.Text = "Código";
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoNuevo.Location = new System.Drawing.Point(65, 23);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigoNuevo.TabIndex = 2;
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(15, 70);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreNuevo.TabIndex = 3;
            this.lblNombreNuevo.Text = "Nombre";
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(15, 114);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteNuevo.TabIndex = 4;
            this.lblTramiteNuevo.Text = "Trámite";
            // 
            // frmEstructuraDinamicaLinealPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(606, 454);
            this.Controls.Add(this.pbRepresentacionFila);
            this.Controls.Add(this.mrcListaGrilla);
            this.Controls.Add(this.mrcElementosEliminados);
            this.Controls.Add(this.mrcNuevosElementos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstructuraDinamicaLinealPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            ((System.ComponentModel.ISupportInitialize)(this.pbRepresentacionFila)).EndInit();
            this.mrcListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.mrcElementosEliminados.ResumeLayout(false);
            this.mrcElementosEliminados.PerformLayout();
            this.mrcNuevosElementos.ResumeLayout(false);
            this.mrcNuevosElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRepresentacionFila;
        private System.Windows.Forms.GroupBox mrcListaGrilla;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTrámite;
        private System.Windows.Forms.GroupBox mrcElementosEliminados;
        private System.Windows.Forms.TextBox txtTramiteEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Label lblTramiteElimina;
        private System.Windows.Forms.Label lblNombreElimina;
        private System.Windows.Forms.GroupBox mrcNuevosElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
    }
}
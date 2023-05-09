namespace pryEstructuraDatos
{
    partial class frmEstructuraDinamicaLinealListaEnlazadaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraDinamicaLinealListaEnlazadaDoble));
            this.pbListaEnlazadaSimple = new System.Windows.Forms.PictureBox();
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
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.gbListarDatos = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaEnlazadaSimple)).BeginInit();
            this.mrcListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.mrcElementosEliminados.SuspendLayout();
            this.mrcNuevosElementos.SuspendLayout();
            this.gbListarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbListaEnlazadaSimple
            // 
            this.pbListaEnlazadaSimple.Image = ((System.Drawing.Image)(resources.GetObject("pbListaEnlazadaSimple.Image")));
            this.pbListaEnlazadaSimple.Location = new System.Drawing.Point(10, 46);
            this.pbListaEnlazadaSimple.Name = "pbListaEnlazadaSimple";
            this.pbListaEnlazadaSimple.Size = new System.Drawing.Size(225, 105);
            this.pbListaEnlazadaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListaEnlazadaSimple.TabIndex = 11;
            this.pbListaEnlazadaSimple.TabStop = false;
            // 
            // mrcListaGrilla
            // 
            this.mrcListaGrilla.BackColor = System.Drawing.Color.Transparent;
            this.mrcListaGrilla.Controls.Add(this.lsbLista);
            this.mrcListaGrilla.Controls.Add(this.dgvGrilla);
            this.mrcListaGrilla.Location = new System.Drawing.Point(14, 237);
            this.mrcListaGrilla.Name = "mrcListaGrilla";
            this.mrcListaGrilla.Size = new System.Drawing.Size(591, 205);
            this.mrcListaGrilla.TabIndex = 10;
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
            this.dgvGrilla.Location = new System.Drawing.Point(243, 19);
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
            this.mrcElementosEliminados.Controls.Add(this.cbEliminar);
            this.mrcElementosEliminados.Controls.Add(this.btnEliminar);
            this.mrcElementosEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementosEliminados.Location = new System.Drawing.Point(427, 16);
            this.mrcElementosEliminados.Name = "mrcElementosEliminados";
            this.mrcElementosEliminados.Size = new System.Drawing.Size(177, 99);
            this.mrcElementosEliminados.TabIndex = 9;
            this.mrcElementosEliminados.TabStop = false;
            this.mrcElementosEliminados.Text = "Elemento Eliminados";
            // 
            // cbEliminar
            // 
            this.cbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(53, 23);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(118, 21);
            this.cbEliminar.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 31);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(7, 26);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEliminar.TabIndex = 5;
            this.lblCodigoEliminar.Text = "Código";
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
            this.mrcNuevosElementos.Location = new System.Drawing.Point(242, 16);
            this.mrcNuevosElementos.Name = "mrcNuevosElementos";
            this.mrcNuevosElementos.Size = new System.Drawing.Size(177, 215);
            this.mrcNuevosElementos.TabIndex = 8;
            this.mrcNuevosElementos.TabStop = false;
            this.mrcNuevosElementos.Text = "Nuevos Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 161);
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
            // gbListarDatos
            // 
            this.gbListarDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbListarDatos.Controls.Add(this.rbDescendente);
            this.gbListarDatos.Controls.Add(this.rbAscendente);
            this.gbListarDatos.Location = new System.Drawing.Point(427, 121);
            this.gbListarDatos.Name = "gbListarDatos";
            this.gbListarDatos.Size = new System.Drawing.Size(177, 110);
            this.gbListarDatos.TabIndex = 10;
            this.gbListarDatos.TabStop = false;
            this.gbListarDatos.Text = "Listar Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(10, 63);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Checked = true;
            this.rbAscendente.Location = new System.Drawing.Point(10, 30);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // frmEstructuraDinamicaLinealListaEnlazadaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(621, 458);
            this.Controls.Add(this.gbListarDatos);
            this.Controls.Add(this.pbListaEnlazadaSimple);
            this.Controls.Add(this.mrcListaGrilla);
            this.Controls.Add(this.mrcElementosEliminados);
            this.Controls.Add(this.mrcNuevosElementos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstructuraDinamicaLinealListaEnlazadaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista enlazada doble";
            ((System.ComponentModel.ISupportInitialize)(this.pbListaEnlazadaSimple)).EndInit();
            this.mrcListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.mrcElementosEliminados.ResumeLayout(false);
            this.mrcElementosEliminados.PerformLayout();
            this.mrcNuevosElementos.ResumeLayout(false);
            this.mrcNuevosElementos.PerformLayout();
            this.gbListarDatos.ResumeLayout(false);
            this.gbListarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbListaEnlazadaSimple;
        private System.Windows.Forms.GroupBox mrcListaGrilla;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTrámite;
        private System.Windows.Forms.GroupBox mrcElementosEliminados;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcNuevosElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.GroupBox gbListarDatos;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}
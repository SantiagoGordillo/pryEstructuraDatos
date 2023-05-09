namespace pryEstructuraDatos
{
    partial class frmEstructuraDinamicaNoLinealArbolBinario
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
            this.pbRepresentacionListaSimple = new System.Windows.Forms.PictureBox();
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
            this.txtCodigoNuevo = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.gbListarDatos = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPostOrder = new System.Windows.Forms.RadioButton();
            this.rbPreOrder = new System.Windows.Forms.RadioButton();
            this.rbInOrder = new System.Windows.Forms.RadioButton();
            this.tvDatos = new System.Windows.Forms.TreeView();
            this.gbTreeView = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepresentacionListaSimple)).BeginInit();
            this.mrcListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.mrcElementosEliminados.SuspendLayout();
            this.mrcNuevosElementos.SuspendLayout();
            this.gbListarDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRepresentacionListaSimple
            // 
            this.pbRepresentacionListaSimple.Image = global::pryEstructuraDatos.Properties.Resources.descarga__1_;
            this.pbRepresentacionListaSimple.Location = new System.Drawing.Point(21, 32);
            this.pbRepresentacionListaSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbRepresentacionListaSimple.Name = "pbRepresentacionListaSimple";
            this.pbRepresentacionListaSimple.Size = new System.Drawing.Size(326, 165);
            this.pbRepresentacionListaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRepresentacionListaSimple.TabIndex = 16;
            this.pbRepresentacionListaSimple.TabStop = false;
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
            this.mrcListaGrilla.Size = new System.Drawing.Size(880, 315);
            this.mrcListaGrilla.TabIndex = 15;
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
            this.dgvGrilla.Size = new System.Drawing.Size(508, 265);
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
            this.mrcElementosEliminados.Location = new System.Drawing.Point(30, 203);
            this.mrcElementosEliminados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcElementosEliminados.Name = "mrcElementosEliminados";
            this.mrcElementosEliminados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcElementosEliminados.Size = new System.Drawing.Size(309, 152);
            this.mrcElementosEliminados.TabIndex = 13;
            this.mrcElementosEliminados.TabStop = false;
            this.mrcElementosEliminados.Text = "Elemento Eliminados";
            // 
            // cbEliminar
            // 
            this.cbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(80, 35);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(206, 28);
            this.cbEliminar.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 86);
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
            this.lblCodigoEliminar.Location = new System.Drawing.Point(10, 40);
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
            this.mrcNuevosElementos.TabIndex = 12;
            this.mrcNuevosElementos.TabStop = false;
            this.mrcNuevosElementos.Text = "Nuevos Elementos";
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoNuevo.Location = new System.Drawing.Point(93, 38);
            this.txtCodigoNuevo.Mask = "999999";
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigoNuevo.TabIndex = 5;
            this.txtCodigoNuevo.ValidatingType = typeof(int);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(8, 266);
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
            this.txtTramiteNuevo.Location = new System.Drawing.Point(93, 192);
            this.txtTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(148, 26);
            this.txtTramiteNuevo.TabIndex = 4;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreNuevo.Location = new System.Drawing.Point(93, 115);
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
            this.lblNombreNuevo.Location = new System.Drawing.Point(22, 117);
            this.lblNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(65, 20);
            this.lblNombreNuevo.TabIndex = 3;
            this.lblNombreNuevo.Text = "Nombre";
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(22, 194);
            this.lblTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblTramiteNuevo.TabIndex = 4;
            this.lblTramiteNuevo.Text = "Trámite";
            // 
            // gbListarDatos
            // 
            this.gbListarDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbListarDatos.Controls.Add(this.rbDescendente);
            this.gbListarDatos.Controls.Add(this.rbAscendente);
            this.gbListarDatos.Location = new System.Drawing.Point(636, 218);
            this.gbListarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListarDatos.Name = "gbListarDatos";
            this.gbListarDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListarDatos.Size = new System.Drawing.Size(266, 135);
            this.gbListarDatos.TabIndex = 17;
            this.gbListarDatos.TabStop = false;
            this.gbListarDatos.Text = "Listar Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(15, 78);
            this.rbDescendente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(130, 24);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Checked = true;
            this.rbAscendente.Location = new System.Drawing.Point(15, 37);
            this.rbAscendente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(120, 24);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbPostOrder);
            this.groupBox1.Controls.Add(this.rbPreOrder);
            this.groupBox1.Controls.Add(this.rbInOrder);
            this.groupBox1.Location = new System.Drawing.Point(636, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(266, 174);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Datos";
            // 
            // rbPostOrder
            // 
            this.rbPostOrder.AutoSize = true;
            this.rbPostOrder.Location = new System.Drawing.Point(15, 117);
            this.rbPostOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPostOrder.Name = "rbPostOrder";
            this.rbPostOrder.Size = new System.Drawing.Size(110, 24);
            this.rbPostOrder.TabIndex = 2;
            this.rbPostOrder.Text = "Post Order";
            this.rbPostOrder.UseVisualStyleBackColor = true;
            this.rbPostOrder.CheckedChanged += new System.EventHandler(this.rbPostOrder_CheckedChanged);
            // 
            // rbPreOrder
            // 
            this.rbPreOrder.AutoSize = true;
            this.rbPreOrder.Location = new System.Drawing.Point(15, 72);
            this.rbPreOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPreOrder.Name = "rbPreOrder";
            this.rbPreOrder.Size = new System.Drawing.Size(102, 24);
            this.rbPreOrder.TabIndex = 1;
            this.rbPreOrder.Text = "Pre Order";
            this.rbPreOrder.UseVisualStyleBackColor = true;
            this.rbPreOrder.CheckedChanged += new System.EventHandler(this.rbPreOrder_CheckedChanged);
            // 
            // rbInOrder
            // 
            this.rbInOrder.AutoSize = true;
            this.rbInOrder.Checked = true;
            this.rbInOrder.Location = new System.Drawing.Point(15, 29);
            this.rbInOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbInOrder.Name = "rbInOrder";
            this.rbInOrder.Size = new System.Drawing.Size(92, 24);
            this.rbInOrder.TabIndex = 0;
            this.rbInOrder.TabStop = true;
            this.rbInOrder.Text = "In Order";
            this.rbInOrder.UseVisualStyleBackColor = true;
            this.rbInOrder.CheckedChanged += new System.EventHandler(this.rbInOrder_CheckedChanged);
            // 
            // tvDatos
            // 
            this.tvDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvDatos.Location = new System.Drawing.Point(15, 31);
            this.tvDatos.Name = "tvDatos";
            this.tvDatos.Size = new System.Drawing.Size(384, 568);
            this.tvDatos.TabIndex = 19;
            this.tvDatos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDatos_NodeMouseDoubleClick);
            // 
            // gbTreeView
            // 
            this.gbTreeView.BackColor = System.Drawing.Color.Transparent;
            this.gbTreeView.Controls.Add(this.label1);
            this.gbTreeView.Controls.Add(this.tvDatos);
            this.gbTreeView.Location = new System.Drawing.Point(927, 23);
            this.gbTreeView.Name = "gbTreeView";
            this.gbTreeView.Size = new System.Drawing.Size(416, 657);
            this.gbTreeView.TabIndex = 20;
            this.gbTreeView.TabStop = false;
            this.gbTreeView.Text = "Tree View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 617);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Double click on each node for more information";
            // 
            // frmEstructuraDinamicaNoLinealArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.gbTreeView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbListarDatos);
            this.Controls.Add(this.pbRepresentacionListaSimple);
            this.Controls.Add(this.mrcListaGrilla);
            this.Controls.Add(this.mrcElementosEliminados);
            this.Controls.Add(this.mrcNuevosElementos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstructuraDinamicaNoLinealArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.frmEstructuraDinamicaNoLinealArbolBinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRepresentacionListaSimple)).EndInit();
            this.mrcListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.mrcElementosEliminados.ResumeLayout(false);
            this.mrcElementosEliminados.PerformLayout();
            this.mrcNuevosElementos.ResumeLayout(false);
            this.mrcNuevosElementos.PerformLayout();
            this.gbListarDatos.ResumeLayout(false);
            this.gbListarDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTreeView.ResumeLayout(false);
            this.gbTreeView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbRepresentacionListaSimple;
        private System.Windows.Forms.GroupBox mrcListaGrilla;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox mrcElementosEliminados;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcNuevosElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.GroupBox gbListarDatos;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPostOrder;
        private System.Windows.Forms.RadioButton rbPreOrder;
        private System.Windows.Forms.RadioButton rbInOrder;
        private System.Windows.Forms.TreeView tvDatos;
        private System.Windows.Forms.GroupBox gbTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCodigoNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTrámite;
    }
}
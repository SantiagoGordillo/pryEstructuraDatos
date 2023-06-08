namespace pryEstructuraDatos
{
    partial class frmBaseDeDatos
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
            this.dgbMain = new System.Windows.Forms.DataGridView();
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMultiple = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionMultiple = new System.Windows.Forms.Button();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.gbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMain)).BeginInit();
            this.gbProyeccion.SuspendLayout();
            this.gbSeleccion.SuspendLayout();
            this.gbAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbMain
            // 
            this.dgbMain.AllowUserToAddRows = false;
            this.dgbMain.AllowUserToDeleteRows = false;
            this.dgbMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMain.Location = new System.Drawing.Point(18, 18);
            this.dgbMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgbMain.Name = "dgbMain";
            this.dgbMain.ReadOnly = true;
            this.dgbMain.RowHeadersVisible = false;
            this.dgbMain.RowHeadersWidth = 62;
            this.dgbMain.Size = new System.Drawing.Size(1164, 435);
            this.dgbMain.TabIndex = 0;
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.gbProyeccion.Controls.Add(this.btnProyeccionMultiple);
            this.gbProyeccion.Controls.Add(this.btnJuntar);
            this.gbProyeccion.Location = new System.Drawing.Point(42, 463);
            this.gbProyeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProyeccion.Size = new System.Drawing.Size(336, 211);
            this.gbProyeccion.TabIndex = 1;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(26, 29);
            this.btnProyeccionSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(280, 35);
            this.btnProyeccionSimple.TabIndex = 3;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnProyeccionMultiple
            // 
            this.btnProyeccionMultiple.Location = new System.Drawing.Point(26, 88);
            this.btnProyeccionMultiple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProyeccionMultiple.Name = "btnProyeccionMultiple";
            this.btnProyeccionMultiple.Size = new System.Drawing.Size(280, 35);
            this.btnProyeccionMultiple.TabIndex = 4;
            this.btnProyeccionMultiple.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMultiple.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiple.Click += new System.EventHandler(this.btnProyeccionMultiple_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(26, 149);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(280, 35);
            this.btnJuntar.TabIndex = 5;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gbSeleccion.Controls.Add(this.btnSeleccionMultiple);
            this.gbSeleccion.Controls.Add(this.btnSeleccionConvolucion);
            this.gbSeleccion.Location = new System.Drawing.Point(424, 463);
            this.gbSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeleccion.Size = new System.Drawing.Size(336, 211);
            this.gbSeleccion.TabIndex = 6;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Operaciones de Seleccion";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(26, 29);
            this.btnSeleccionSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(280, 35);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnSeleccionMultiple
            // 
            this.btnSeleccionMultiple.Location = new System.Drawing.Point(26, 88);
            this.btnSeleccionMultiple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionMultiple.Name = "btnSeleccionMultiple";
            this.btnSeleccionMultiple.Size = new System.Drawing.Size(280, 35);
            this.btnSeleccionMultiple.TabIndex = 4;
            this.btnSeleccionMultiple.Text = "Seleccion Multioatributo";
            this.btnSeleccionMultiple.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiple.Click += new System.EventHandler(this.btnSeleccionMultiple_Click);
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(26, 149);
            this.btnSeleccionConvolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(280, 35);
            this.btnSeleccionConvolucion.TabIndex = 5;
            this.btnSeleccionConvolucion.Text = "Seleccion por Convolucion";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // gbAlgebraicas
            // 
            this.gbAlgebraicas.Controls.Add(this.btnUnion);
            this.gbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbAlgebraicas.Location = new System.Drawing.Point(810, 463);
            this.gbAlgebraicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlgebraicas.Name = "gbAlgebraicas";
            this.gbAlgebraicas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlgebraicas.Size = new System.Drawing.Size(336, 211);
            this.gbAlgebraicas.TabIndex = 6;
            this.gbAlgebraicas.TabStop = false;
            this.gbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(26, 29);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(280, 35);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(26, 88);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(280, 35);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(26, 149);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(280, 35);
            this.btnDiferencia.TabIndex = 5;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gbAlgebraicas);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbProyeccion);
            this.Controls.Add(this.dgbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMain)).EndInit();
            this.gbProyeccion.ResumeLayout(false);
            this.gbSeleccion.ResumeLayout(false);
            this.gbAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbMain;
        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnProyeccionMultiple;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnSeleccionMultiple;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.GroupBox gbAlgebraicas;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnDiferencia;
    }
}
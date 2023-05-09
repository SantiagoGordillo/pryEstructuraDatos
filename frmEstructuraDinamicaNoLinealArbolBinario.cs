using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryEstructuraDatos
{
    public partial class frmEstructuraDinamicaNoLinealArbolBinario : Form
    {
        public frmEstructuraDinamicaNoLinealArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        StreamWriter Writer;
        public bool Ascendente = true;
        public string Recorrido;
        public int NodoEliminar;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                if (Arbol.Buscar(Convert.ToInt32(txtCodigoNuevo.Text)) == false)
                {
                    clsNodo objNodo = new clsNodo();

                    objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                    objNodo.Nombre = txtNombreNuevo.Text;
                    objNodo.Tramite = txtTramiteNuevo.Text;

                    Arbol.Agregar(objNodo);

                    if (Arbol.Raiz != null)
                    {
                        Arbol.Equilibrar();
                    }

                    SeleccionRecorrido();
                    Recorridos();
                }
                else
                {
                    MessageBox.Show("El codigo ya existe", "Error");
                }

                txtCodigoNuevo.Text = "";
                txtNombreNuevo.Text = "";
                txtTramiteNuevo.Text = "";
                txtCodigoNuevo.Focus();
            }
            else
            {
                if (txtCodigoNuevo.Text == "") txtCodigoNuevo.Focus();
                else if (txtNombreNuevo.Text == "") txtNombreNuevo.Focus();
                else if (txtTramiteNuevo.Text == "") txtTramiteNuevo.Focus();
                MessageBox.Show("Complete todos los campos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null && cbEliminar.SelectedIndex != -1)
            {
                Arbol.Equilibrar(Convert.ToInt32(cbEliminar.SelectedItem));

                SeleccionRecorrido();
                Recorridos();

                if (Arbol.Raiz == null)
                {
                    File.Delete("./ArbolBinario.csv");
                    dgvGrilla.Rows.Clear();
                    lsbLista.Items.Clear();
                    cbEliminar.Items.Clear();
                    tvDatos.Nodes.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");
            }
            txtCodigoNuevo.Focus();
        }
        private void rbInOrder_CheckedChanged(object sender, EventArgs e)
        {
            InOrderEstado();
            SeleccionRecorrido();
            Recorridos();
        }
        private void rbPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            InOrderEstado();
            SeleccionRecorrido();
            Recorridos();
        }
        private void rbPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            InOrderEstado();
            SeleccionRecorrido();
            Recorridos();
        }
        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            InOrderEstado();
            SeleccionRecorrido();
            Recorridos();
        }
        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            InOrderEstado();
            SeleccionRecorrido();
            Recorridos();
        }
        public void InOrderEstado()
        {
            if (rbInOrder.Checked)
            {
                rbAscendente.Enabled = true;
                rbDescendente.Enabled = true;
            }
            else
            {
                rbAscendente.Enabled = false;
                rbDescendente.Enabled = false;
            }
        }
        public void SeleccionRecorrido()
        {
            if (rbInOrder.Checked)
            {
                Recorrido = "InOrder";
                if (rbAscendente.Checked) Ascendente = true;
                else if (rbDescendente.Checked) Ascendente = false;
            }
            else if (rbPostOrder.Checked)
            {
                Recorrido = "PostOrder";
            }
            else if (rbPreOrder.Checked)
            {
                Recorrido = "PreOrder";
            }
        }
        public void Recorridos()
        {
            if (Arbol.Raiz != null)
            {
                Writer = new StreamWriter("./ArbolBinario.csv", false);
                Arbol.Recorrer(Writer, Ascendente, Recorrido);
                Writer.Close();
                Writer.Dispose();
                Arbol.Recorrer(dgvGrilla, Ascendente, Recorrido);
                Arbol.Recorrer(lsbLista, Ascendente, Recorrido);
                Arbol.Recorrer(cbEliminar, Ascendente, Recorrido);
                Arbol.Recorrer(tvDatos);
                tvDatos.ExpandAll();
            }
        }
    }
}

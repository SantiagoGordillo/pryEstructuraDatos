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

namespace pryEstructuraDatos
{
    public partial class frmEstructuraDinamicaNoLinealArbolBinario : Form
    {
        public frmEstructuraDinamicaNoLinealArbolBinario()
        {
            InitializeComponent();
        }

        public bool Ascendente = true;
        public string Recorrido;
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Tramite = txtTramiteNuevo.Text;

                SeleccionRecorrido();

                Arbol.Agregar(objNodo);

                Recorridos();

                txtCodigoNuevo.Text = "";
                txtNombreNuevo.Text = "";
                txtTramiteNuevo.Text = "";
                txtCodigoNuevo.Focus();
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
                txtCodigoNuevo.Focus();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((Arbol.Raiz != null) && (cbEliminar.Text != ""))
            {

                Arbol.Eliminar(Convert.ToInt32(cbEliminar.SelectedItem));

                if (Arbol.Raiz != null)
                {
                    InOrderEstado();
                    SeleccionRecorrido();
                    Recorridos();
                }
                else
                {
                    dgvGrilla.Rows.Clear();
                    lsbLista.Items.Clear();
                    cbEliminar.Items.Clear();
                    txtCodigoNuevo.Focus();
                }

                txtCodigoNuevo.Focus();
            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");

                txtCodigoNuevo.Focus();
            }
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
            Arbol.Recorrer(dgvGrilla, Ascendente, Recorrido);
            Arbol.Recorrer(lsbLista, Ascendente, Recorrido);
            Arbol.Recorrer(cbEliminar, Ascendente, Recorrido);
        }
    }
}

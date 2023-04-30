using System;
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
    public partial class frmEstructuraDinamicaLinealListaEnlazadaDoble : Form
    {
        public frmEstructuraDinamicaLinealListaEnlazadaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {  
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Tramite = txtTramiteNuevo.Text;

                Lista.Agregar(objNodo);

                if (rbAscendente.Checked)
                {
                    Lista.Recorrer(dgvGrilla);
                    Lista.Recorrer(lsbLista);
                    Lista.Recorrer(cbEliminar);
                }
                else if (rbDescendente.Checked)
                {
                    Lista.RecorrerDes(dgvGrilla);
                    Lista.RecorrerDes(lsbLista);
                    Lista.RecorrerDes(cbEliminar);
                }

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
            if ((Lista.Primero != null) && (cbEliminar.Text != ""))
            {

                Lista.Eliminar(Convert.ToInt32(cbEliminar.SelectedItem));

                if (rbAscendente.Checked)
                {
                    Lista.Recorrer(dgvGrilla);
                    Lista.Recorrer(lsbLista);
                    Lista.Recorrer(cbEliminar);
                }
                else if (rbDescendente.Checked)
                {
                    Lista.RecorrerDes(dgvGrilla);
                    Lista.RecorrerDes(lsbLista);
                    Lista.RecorrerDes(cbEliminar);
                }

                txtCodigoNuevo.Focus();
            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");

                txtCodigoNuevo.Focus();
            }
        }
 
        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvGrilla);
            Lista.Recorrer(lsbLista);
            Lista.Recorrer(cbEliminar);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvGrilla);
            Lista.RecorrerDes(lsbLista);
            Lista.RecorrerDes(cbEliminar);
        }
    }
}

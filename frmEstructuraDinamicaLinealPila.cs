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
    public partial class frmEstructuraDinamicaLinealPila : Form
    {
        public frmEstructuraDinamicaLinealPila()
        {
            InitializeComponent();
        }

        clsPila Pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
                {
                    if (Pila.Buscar(Convert.ToInt32(txtCodigoNuevo.Text)) == false)
                    {
                        clsNodo objNodo = new clsNodo();

                        objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                        objNodo.Nombre = txtNombreNuevo.Text;
                        objNodo.Tramite = txtTramiteNuevo.Text;

                        Pila.Agregar(objNodo);
                        Pila.Recorrer(dgvGrilla);
                        Pila.Recorrer(lsbLista);

                        txtCodigoNuevo.Text = "";
                        txtNombreNuevo.Text = "";
                        txtTramiteNuevo.Text = "";
                        txtCodigoNuevo.Focus();
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
            catch (Exception ex)
            {
                MessageBox.Show("Codigo invalido");
                txtCodigoNuevo.Text = "";
                txtCodigoNuevo.Focus();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                txtCodigoEliminar.Text = Pila.Primero.Codigo.ToString();
                txtNombreEliminar.Text = Pila.Primero.Nombre;
                txtTramiteEliminar.Text = Pila.Primero.Tramite;

                Pila.Eliminar();

                Pila.Recorrer(dgvGrilla);
                Pila.Recorrer(lsbLista);

                txtCodigoNuevo.Focus();
            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");

                txtCodigoEliminar.Text = "";
                txtNombreEliminar.Text = "";
                txtTramiteEliminar.Text = "";

                txtCodigoNuevo.Focus();
            }
        }
    }
}

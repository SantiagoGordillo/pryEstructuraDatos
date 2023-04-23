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
    public partial class frmEstructuraDinamicaLinealCola : Form
    {
        public frmEstructuraDinamicaLinealCola()
        {
            InitializeComponent();
        }

        clsCola Fila = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            objNodo.Nombre = txtNombreNuevo.Text;
            objNodo.Tramite = txtTramiteNuevo.Text;

            Fila.Agregar(objNodo);
            Fila.Recorrer(dgvGrilla);
            Fila.Recorrer(lsbLista);

            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
            txtCodigoNuevo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Fila.Primero != null)
            {
                txtCodigoEliminar.Text = Fila.Primero.Codigo.ToString();
                txtNombreEliminar.Text = Fila.Primero.Nombre;
                txtTramiteEliminar.Text = Fila.Primero.Tramite;

                Fila.Eliminar();
                Fila.Recorrer(dgvGrilla);
                Fila.Recorrer(lsbLista);

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

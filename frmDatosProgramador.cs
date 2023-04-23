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
    public partial class frmDatosProgramador : Form
    {
        public frmDatosProgramador()
        {
            InitializeComponent();
        }

        private void frmDatosProgramador_Load(object sender, EventArgs e)
        {
            lblDNI.Text = "44192777";
            lblNombre.Text = "Gordillo Santiago";
            lblMateria.Text = "Estructura de Datos";
            lblCarrera.Text = "Analista de Sistemas";
        }
    }
}

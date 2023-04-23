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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tmsiDatosProgramador_Click(object sender, EventArgs e)
        {
            new frmDatosProgramador().ShowDialog();
        }

        private void tmsiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmsiColas_Click(object sender, EventArgs e)
        {
            new frmEstructuraDinamicaLinealCola().ShowDialog();
        }

        private void tmsiPilas_Click(object sender, EventArgs e)
        {
            new frmEstructuraDinamicaLinealPila().ShowDialog();
        }

        private void tmsiSimples_Click(object sender, EventArgs e)
        {
            new frmEstructuraDinamicaLinealListaEnlazadaSimple().ShowDialog();
        }

        private void tmsiDobles_Click(object sender, EventArgs e)
        {
            new frmEstructuraDinamicaLinealListaEnlazadaDoble().ShowDialog();  
        }
    }
}

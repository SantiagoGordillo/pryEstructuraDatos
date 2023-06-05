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
    public partial class frmConsultaSQL : Form
    {
        public frmConsultaSQL()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
                string varSQL = txtSQL.Text;
                objBaseDatos.Listar(dgvConsulta, varSQL);
                dgvConsulta.AutoResizeColumns();
        }
    }
}

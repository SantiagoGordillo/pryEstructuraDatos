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
    public partial class frmRepasoOperaciones : Form
    {
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        public frmRepasoOperaciones()
        {
            InitializeComponent();
        }
        private void frmRepasoOperaciones_Load(object sender, EventArgs e)
        {
            cbIntruccion.SelectedIndex = 0;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            string varSQL = "";
            switch (cbIntruccion.SelectedIndex)
            {
                case 0: // Diferencia
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idLibro not in (SELECT idLibro FROM Libro where idAutor = 83) ORDER BY 1 ASC";
                    break;
                case 1: // Interseccion
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND exists (SELECT * FROM Libro where idAutor = 5) ORDER BY 1 ASC";
                    break;
                case 2: // Juntar
                    varSQL = "SELECT * FROM Libro inner join Pais on Libro.IdPais = Pais.IdPais";
                    break;
                case 3: // Union
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 union SELECT * FROM Libro where idIdioma = 3 ORDER BY 1 ASC";
                    break;
                case 4: // Proyeccion Simple
                    varSQL = "SELECT Titulo FROM Libro ORDER BY 1 ASC";
                    break;
                case 5: // Proyeccion Multiatributo
                    varSQL = "SELECT * FROM Libro ORDER BY 1 ASC";
                    break;
                case 6: // Seleccion Simple
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 ORDER BY 1 ASC";
                    break;
                case 7: // Seleccion Multiatributo con operador AND
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idAutor = 83 ORDER BY 1 ASC";
                    break;
                case 8: // Seleccion Multiatributo con operador OR
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 OR idAutor = 83 ORDER BY 1 ASC";
                    break;
                case 9: // Seleccion Multiatributo por convolucion
                    varSQL = "SELECT * FROM ( SELECT * FROM Libro where Idautor = 3 ) as X where idIdioma = 2 ORDER BY Titulo";
                    break;
            }
            objBaseDatos.Listar(dgvDatos, varSQL);
            dgvDatos.AutoResizeColumns();
        }
    }
}

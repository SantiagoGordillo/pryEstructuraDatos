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
            string varText = "";
            string varSQL = "";
            switch (cbIntruccion.SelectedIndex)
            {
                case 0: // Diferencia
                    varText = "Libros en Ruso(2) que no son de Pablo Alvarez(83)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idLibro not in (SELECT idLibro FROM Libro where idAutor = 83) ORDER BY 1 ASC";
                    break;
                case 1: // Interseccion
                    varText = "Libros en Ruso(2) si es que existe uno de Alfred Döblin(5)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND exists (SELECT * FROM Libro where idAutor = 5) ORDER BY 1 ASC";
                    break;
                case 2: // Juntar
                    varText = "Junta de las filas de la Tabla Libro y Pais";
                    varSQL = "SELECT * FROM Libro inner join Pais on Libro.IdPais = Pais.IdPais";
                    break;
                case 3: // Union
                    varText = "Libros en Ruso(2) y Alemán(3)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 union SELECT * FROM Libro where idIdioma = 3 ORDER BY 1 ASC";
                    break;
                case 4: // Proyeccion Simple
                    varText = "Titulos de los Libros";
                    varSQL = "SELECT Titulo FROM Libro ORDER BY 1 ASC";
                    break;
                case 5: // Proyeccion Multiatributo
                    varText = "Libros";
                    varSQL = "SELECT * FROM Libro ORDER BY 1 ASC";
                    break;
                case 6: // Seleccion Simple
                    varText = "Libros en Ruso(2)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 ORDER BY 1 ASC";
                    break;
                case 7: // Seleccion Multiatributo con operador AND
                    varText = "Libros en Ruso(2) de Pablo Alvarez(83)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idAutor = 83 ORDER BY 1 ASC";
                    break;
                case 8: // Seleccion Multiatributo con operador OR
                    varText = "Libros en Ruso(2) o de Pablo Alvarez(83)";
                    varSQL = "SELECT * FROM Libro where idIdioma = 2 OR idAutor = 83 ORDER BY 1 ASC";
                    break;
                case 9: // Seleccion Multiatributo por convolucion
                    varText = "Libros en Ruso(2) o de virginia(3)";
                    varSQL = "SELECT * FROM ( SELECT * FROM Libro where Idautor = 3 ) as X where idIdioma = 2 ORDER BY Titulo";
                    break;
            }
            txtDescripcion.Text = varText;
            objBaseDatos.Listar(dgvDatos, varSQL);
            dgvDatos.AutoResizeColumns();
        }
    }
}

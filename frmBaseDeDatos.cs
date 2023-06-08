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
    public partial class frmBaseDeDatos : Form
    {
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT Titulo FROM Libro ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnProyeccionMultiple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro where idIdioma = 2 ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnSeleccionMultiple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idAutor = 83 ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnUnion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro where idIdioma = 2 union SELECT * FROM Libro where idIdioma = 3 ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro where idIdioma = 2 AND exists (SELECT * FROM Libro where idAutor = 5) ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro where idIdioma = 2 AND idLibro not in (SELECT idLibro FROM Libro where idAutor = 5) ORDER BY 1 ASC";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM ( SELECT * FROM Libro where Idautor = 3 ) as X where idIdioma = 2 ORDER BY Titulo";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
        private void btnJuntar_Click(object sender, EventArgs e)
        {
            // string varSQL = "SELECT * FROM Libro, Pais where Libro.IdPais = Pais.IdPais"; // solo conceptual
            string varSQL = "SELECT * FROM Libro inner join Pais on Libro.IdPais = Pais.IdPais";
            objBaseDatos.Listar(dgbMain, varSQL);
            dgbMain.AutoResizeColumns();
        }
    }
}

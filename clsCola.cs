using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsCola
    {
        // Nodos de la clase clsCola
        public clsNodo Primero;
        public clsNodo Ultimo;
        public clsNodo Aux;

        public void Agregar(clsNodo Nuevo) // Recibe los datos del Nuevo Nodo
        {
            if (Primero == null) // Si no existe ningun Nodo
            {
                Primero = Nuevo; // El nuevo pasa a ser el primero
                Ultimo = Nuevo; // El nuevo pasa a ser ultimo
            }
            else
            {
                Ultimo.Siguiente = Nuevo; // 
                Ultimo = Nuevo; // El nuevo pasa a ser Ultimo
            }
        }
        public bool Buscar(int Codigo)
        {
            clsNodo Aux = Primero;
            while (Aux != null && Aux.Codigo != Codigo)
            {
                Aux = Aux.Siguiente;
            }
            if (Aux != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo) // Si el primero es igual al ultimo:
            {
                Primero = null; // Se elimina el primero
                Ultimo = null; // Se elimina el ultimo
            }
            else
            {
                Primero = Primero.Siguiente;  // Movemos el primero al siguiente y el primero se elimina
            }
        }
        public void Recorrer(DataGridView grilla)
        {
            Aux = Primero;
            grilla.Rows.Clear();
            while ( Aux != null)
            {
                grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            Aux = Primero;
            lista.Items.Clear();
            while (Aux != null)
            {
                lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
    }
}

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
        public clsNodo Primero; // Declaramos el primer Nodo
        public clsNodo Ultimo; // Declaramos el ultimo Nodo
        public clsNodo Aux; // Declaramos un nodo auxiliar
        public void Agregar(clsNodo Nuevo) // Recibe los datos del Nuevo Nodo
        {
            if (Primero == null) // Si no existe ningun Nodo:
            {
                Primero = Nuevo; // El nuevo es el primero
                Ultimo = Nuevo; // El nuevo es el ultimo
            }
            else // Si no:
            {
                Ultimo.Siguiente = Nuevo; // Al ultimo se le engacha el siguiente (Nuevo)
                Ultimo = Nuevo; // El nuevo pasa a ser Ultimo
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo) // Si el primero es igual al ultimo:
            {
                Primero = null; // Se elimina el primero
                Ultimo = null; // Se elimina el ultimo
            }
            else // Si no:
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

        public void Recorrer(ComboBox combo)
        {
            Aux = Primero;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }
    }
}

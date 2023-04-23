using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsPila
    {
        public clsNodo Primero; // Declaramos el primer Nodo
        public clsNodo Aux; // Declaramos un nodo auxiliar

        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            Aux = Primero;
            grilla.Rows.Clear();
            while (Aux != null)
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

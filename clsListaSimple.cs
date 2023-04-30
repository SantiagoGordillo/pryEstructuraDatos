using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace pryEstructuraDatos
{
    class clsListaSimple
    {
        public clsNodo Primero;
        public clsNodo Anterior;
        public clsNodo Aux; 
        public void Agregar(clsNodo Nuevo) // Recibe los datos del Nuevo Nodo
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    Anterior = Nuevo;
                    Aux = Primero;

                    while (Nuevo.Codigo > Aux.Codigo)
                    {
                        Anterior = Aux;
                        Aux = Aux.Siguiente;
                        if (Aux == null)
                        {
                            break;
                        }
                    }

                    Nuevo.Siguiente = Aux;
                    Anterior.Siguiente = Nuevo;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                Anterior = Primero;
                Aux = Primero;
                while(Aux.Codigo != Codigo)
                {
                    Anterior = Aux;
                    Aux = Aux.Siguiente;
                }
                Anterior.Siguiente = Aux.Siguiente;
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
                combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        public clsNodo pri;
        public clsNodo ult;
        public clsNodo Aux;
        public clsNodo Ant;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value;  }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo) // Recibe los datos del Nuevo Nodo
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo >= Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        Aux = Primero;
                        Ant = Primero;

                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        Aux = Primero;
                        Ant = Primero;
                        while (Aux.Codigo < Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;
                    }
                }
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

        public void RecorrerDes(DataGridView grilla)
        {
            Aux = Ultimo;
            grilla.Rows.Clear();
            while (Aux != null)
            {
                grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox lista)
        {
            Aux = Ultimo;
            lista.Items.Clear();
            while (Aux != null)
            {
                lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ComboBox combo)
        {
            Aux = Ultimo;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Nombre);
                Aux = Aux.Anterior;
            }
        }

    }
} 


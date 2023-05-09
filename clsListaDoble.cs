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
        // Nodos de la clase clsListaDoble
        public clsNodo pri;
        public clsNodo ult;
        public clsNodo Aux;
        public clsNodo Ant;
        public clsNodo Primero // Crea un puntero para la primera posicion
        {
            get { return pri; }
            set { pri = value;  }
        }
        public clsNodo Ultimo // Crea un puntero para la ultima posicion
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo) // Recibe los datos del Nuevo Nodo
        {
            if (Primero == null) // Si no hay nongun nodo, establece el nuevo como primero y ultimo
            {
                Primero = Nuevo; // El nuevo nodo se convierte en el primero
                Ultimo = Nuevo; // El nuevo nodo se convierte en el ultimo
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo) // Si el codigo del nuevo es menor o igual al primero 
                {
                    Nuevo.Siguiente = Primero; // El valor siguiente del nuevo nodo apunta al primero
                    Primero.Anterior = Nuevo; // El valor anterior del primero apunta al nuevo nodo
                    Primero = Nuevo; // El nuevo nodo se convierte en el primero
                }
                else
                {
                    if (Nuevo.Codigo >= Ultimo.Codigo) // si el codigo del nuevo es mayor o igual que el ultimo
                    {
                        Ultimo.Siguiente = Nuevo; // El valor siguiente del ultimo apunta al nuevo nodo
                        Nuevo.Anterior = Ultimo;  // El valor anterior del nuevo nodo apunta al ultimo
                        Ultimo = Nuevo; // El nuevo nodo se convierte en el ultimo
                    }
                    else
                    {
                        Aux = Primero; // El Aux apunta al primero
                        Ant = Primero; // El Ant apunta al primero

                        while (Aux.Codigo < Nuevo.Codigo) // Mientras el codigo del aux sea menor que el del nuevo
                        {
                            Ant = Aux; // El Ant apunta al Aux
                            Aux = Aux.Siguiente; // El Aux apunta al siguiente
                        }
                        Ant.Siguiente = Nuevo; // El valor siguiente del Ant apunta al nuevo nodo
                        Nuevo.Siguiente = Aux; // El valor siguiente del nuevo nodo apunta al Aux
                        Aux.Anterior = Nuevo; // El valor anterior del Aux apunta al nuevo nodo
                        Nuevo.Anterior = Ant; // El valor anterior del nuevo nodo apunta al Ant
                    }
                }
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
        public void Eliminar(Int32 Codigo) // Elimina el nodo segun el codigo recibido
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero) // Si el codigo del primero es igual al codigo recibido y el ultimo es igual al primero
            {
                Primero = null; // El primero se borra
                Ultimo = null; // El ultimo se borra
            }
            else
            {
                if (Primero.Codigo == Codigo) // Si el codigo del primero es igual al codigo recibido
                {
                    Primero = Primero.Siguiente; // El primero pasa a ser el .siguiente
                    Primero.Anterior = null; // El valor anterior del nuevo primero se borra
                }
                else
                {
                    if (Ultimo.Codigo == Codigo) // Si el codigo del ultimo es igual al codigo recibido
                    {
                        Ultimo = Ultimo.Anterior; // El ultimo pasa a ser el .anterior
                        Ultimo.Siguiente = null; // El valor siguiente del nuevo ultimo se borra
                    }
                    else
                    {
                        Aux = Primero; // El Aux apunta al primero
                        Ant = Primero; // El Ant apunta al primero
                        while (Aux.Codigo < Codigo) // Mientras el codigo del aux sea menor que el codigo recibido
                        {
                            Ant = Aux; // El Ant apunta al Aux
                            Aux = Aux.Siguiente; // El Aux apunta al siguiente
                        }
                        Aux = Aux.Siguiente;
                        Ant.Siguiente = Aux;
                        Aux.Anterior = Ant;
                    }
                }
            }
        }
        public void Recorrer(DataGridView grilla) // Recorre los datos con la grilla
        {
            Aux = Primero; // El Aux apunta al primero
            grilla.Rows.Clear(); // Limpia la grilla
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite); // Agrega los datos a la grilla
                Aux = Aux.Siguiente; // El Aux apunta al siguiente
            }
        }
        public void Recorrer(ListBox lista) // Recorre los datos con la lista 
        {
            Aux = Primero; // El Aux apunta al primero
            lista.Items.Clear(); // Limpia la lista
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite); // Agrega los datos a la lista
                Aux = Aux.Siguiente; // El Aux apunta al siguiente
            }
        }
        public void Recorrer(ComboBox combo) // Recorre los datos con el ComboBox
        {
            Aux = Primero; // El Aux apunta al primero
            combo.Items.Clear(); // Limpia el ComboBox
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                combo.Items.Add(Aux.Codigo); // Agrega los datos al ComboBox
                Aux = Aux.Siguiente; // El Aux apunta al siguiente
            }
        }
        public void RecorrerDes(DataGridView grilla) // Recorre los datos en sentido inverso con la grilla
        {
            Aux = Ultimo; // El Aux apunta al ultimo
            grilla.Rows.Clear(); // Limpia la grilla
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite); // Agrega los datos a la grilla
                Aux = Aux.Anterior; // El Aux apunta al anterior
            }
        }
        public void RecorrerDes(ListBox lista) // Recorre los datos en sentido inverso con la lista
        {
            Aux = Ultimo; // El Aux apunta al ultimo
            lista.Items.Clear(); // Limpia la lista
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite); // Agrega los datos a la lista
                Aux = Aux.Anterior; // El Aux apunta al anterior
            }
        }
        public void RecorrerDes(ComboBox combo) // Recorre los datos en sentido inverso con el ComboBox
        {
            Aux = Ultimo; // El Aux apunta al ultimo
            combo.Items.Clear(); // Limpia el ComboBox
            while (Aux != null) // Mientras el Aux sea diferente de nulo
            {
                combo.Items.Add(Aux.Codigo); // Agrega los datos al ComboBox
                Aux = Aux.Anterior; // El Aux apunta al anterior
            }
        }
    }
} 


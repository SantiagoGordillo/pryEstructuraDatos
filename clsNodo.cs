using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        // Declaracion de variables del Nodo

        private Int32 cod;
        private string nom;
        private string tram;
        private clsNodo sig;
        private clsNodo ant;

        // Propiedades, interactuan con la interfaz, sacando o dando informacion

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tram; }
            set { tram = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Izquierda
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Derecha
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}

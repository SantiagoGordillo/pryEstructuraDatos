using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        public clsNodo[] Vector = new clsNodo[100];
        public int i = 0;
        public clsNodo ini;
        public clsNodo Raiz
        {
            get { return ini; }
            set { ini = value; }
        }
        public void Equilibrar()
        {
            i = 0;
            CargarVectorInOrder(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierda = null;
            Nuevo.Derecha = null;

            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                }
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = Nuevo;
                }
                else
                {
                    NodoPadre.Derecha = Nuevo;
                }
            }
        }
        public void Eliminar (Int32 Codigo)
        {
            clsNodo NodoPadre = Raiz;
            clsNodo Aux = Raiz;

            if (Raiz != null && Raiz.Codigo == Codigo)
            {
                if (Raiz.Izquierda == null && Raiz.Derecha == null)
                {
                    Raiz = null;
                }
                else if (Raiz.Izquierda != null && Raiz.Derecha == null)
                {
                    Raiz = Raiz.Izquierda;
                }
                else if (Raiz.Izquierda == null && Raiz.Derecha != null)
                {
                    Raiz = Raiz.Derecha;
                }
                else
                {
                    Aux = Raiz.Izquierda;
                    while (Aux.Derecha != null)
                    {
                        Aux = Aux.Derecha;
                    }
                    Aux.Derecha = Raiz.Derecha;
                    Raiz = Raiz.Izquierda;
                }
            }
            else
            {
                while (Aux != null && Aux.Codigo != Codigo)
                {
                    NodoPadre = Aux;
                    if (Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                }
                if (Aux != null)
                {
                    if (Aux.Izquierda == null && Aux.Derecha == null)
                    {
                        if (Codigo < NodoPadre.Codigo)
                        {
                            NodoPadre.Izquierda = null;
                        }
                        else
                        {
                            NodoPadre.Derecha = null;
                        }
                    }
                    else if (Aux.Izquierda != null && Aux.Derecha == null)
                    {
                        if (Codigo < NodoPadre.Codigo)
                        {
                            NodoPadre.Izquierda = Aux.Izquierda;
                        }
                        else
                        {
                            NodoPadre.Derecha = Aux.Izquierda;
                        }
                    }
                    else if (Aux.Izquierda == null && Aux.Derecha != null)
                    {
                        if (Codigo < NodoPadre.Codigo)
                        {
                            NodoPadre.Izquierda = Aux.Derecha;
                        }
                        else
                        {
                            NodoPadre.Derecha = Aux.Derecha;
                        }
                    }
                    else if (Aux.Izquierda != null && Aux.Derecha != null)
                    {
                        if (Codigo < NodoPadre.Codigo)
                        {
                            NodoPadre.Izquierda = Aux.Izquierda;
                            NodoPadre.Izquierda.Derecha = Aux.Derecha;
                        }
                        else
                        {
                            NodoPadre.Derecha = Aux.Izquierda;
                            NodoPadre.Derecha.Derecha = Aux.Derecha;
                        }
                    }
                }
            }
        }
        public bool Buscar(Int32 Codigo)
        {
            clsNodo Aux = Raiz;
            while (Aux != null && Aux.Codigo != Codigo)
            {
                if (Codigo < Aux.Codigo)
                {
                    Aux = Aux.Izquierda;
                }
                else
                {
                    Aux = Aux.Derecha;
                }
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
        public void Recorrer(ListBox Lista, bool Ascendente, string Recorrido)
        {
            Lista.Items.Clear ();
            if (Recorrido == "InOrder")
            {
                if (Ascendente == true) InOrderAcs(Lista, Raiz);
                else if (Ascendente == false) InOrderDes(Lista, Raiz);
            }
            else if (Recorrido == "PostOrder")
            {
                PostOrder(Lista, Raiz);
            }
            else if (Recorrido == "PreOrder")
            {
                PreOrder(Lista, Raiz);
            }
        }
        public void Recorrer(ComboBox Combo, bool Ascendente, string Recorrido)
        {
            Combo.Items.Clear();
            if (Recorrido == "InOrder")
            {
                if (Ascendente == true) InOrderAcs(Combo, Raiz);
                else if (Ascendente == false) InOrderDes(Combo, Raiz);
            }
            else if (Recorrido == "PostOrder")
            {
                PostOrder(Combo, Raiz);
            }
            else if (Recorrido == "PreOrder")
            {
                PreOrder(Combo, Raiz);
            }
        }
        public void Recorrer(StreamWriter Writer, bool Ascendente, string Recorrido)
        {
            if (Recorrido == "InOrder")
            {
                if (Ascendente == true) InOrderAcs(Writer, Raiz);
                else if (Ascendente == false) InOrderDes(Writer, Raiz);
            }
            else if (Recorrido == "PostOrder")
            {
                PostOrder(Writer, Raiz);
            }
            else if (Recorrido == "PreOrder")
            {
                PreOrder(Writer, Raiz);
            }
        }
        public void Recorrer(DataGridView Grilla, bool Ascendente, string Recorrido)
        {
            Grilla.Rows.Clear();
            if (Recorrido == "InOrder")
            {
                if (Ascendente == true) InOrderAcs(Grilla, Raiz);
                else if (Ascendente == false) InOrderDes(Grilla, Raiz);
            }
            else if (Recorrido == "PostOrder")
            {
                PostOrder(Grilla, Raiz);
            }
            else if (Recorrido == "PreOrder")
            {
                PreOrder(Grilla, Raiz);
            }
        }
        public void Recorrer(TreeView Tree, bool Ascendente, string Recorrido)
        {
            Tree.Nodes.Clear();
            InOrderAcs(Tree.Nodes, Raiz);
        }
        private void InOrderAcs(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Lista, Raiz.Izquierda);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Derecha != null) InOrderAcs(Lista, Raiz.Derecha);
        }
        private void InOrderAcs(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Combo, Raiz.Izquierda);
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Derecha != null) InOrderAcs(Combo, Raiz.Derecha);
        }
        private void InOrderAcs(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Writer, Raiz.Izquierda);
            Writer.Write (Raiz.Codigo);
            Writer.Write (";");
            Writer.Write (Raiz.Nombre);
            Writer.Write (";");
            Writer.WriteLine (Raiz.Tramite);
            if (Raiz.Derecha != null) InOrderAcs(Writer, Raiz.Derecha);
        }
        private void InOrderAcs(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Grilla, Raiz.Izquierda);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecha != null) InOrderAcs(Grilla, Raiz.Derecha);
        }
        private void InOrderAcs(TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
            TreeNode NuevoNodo = NodoPadre.Add(Raiz.Codigo.ToString());
            if (Raiz.Izquierda != null) InOrderAcs(NuevoNodo.Nodes, Raiz.Izquierda);
            if (Raiz.Derecha != null) InOrderAcs(NuevoNodo.Nodes, Raiz.Derecha);
        }
        private void InOrderDes(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Lista, Raiz.Derecha);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Izquierda != null) InOrderDes(Lista, Raiz.Izquierda);
        }
        private void InOrderDes(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Combo, Raiz.Derecha);
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierda != null) InOrderDes(Combo, Raiz.Izquierda);
        }
        private void InOrderDes(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Writer, Raiz.Derecha);
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
            if (Raiz.Izquierda != null) InOrderDes(Writer, Raiz.Izquierda);
        }
        private void InOrderDes(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Grilla, Raiz.Derecha);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierda != null) InOrderDes(Grilla, Raiz.Izquierda);
        }
        private void InOrderDes (TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
        }
        private void PreOrder(ListBox Lista, clsNodo Raiz)
        {
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Izquierda != null) PreOrder(Lista, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Lista, Raiz.Derecha);
        }
        private void PreOrder(ComboBox Combo, clsNodo Raiz)
        {
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierda != null) PreOrder(Combo, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Combo, Raiz.Derecha);
        }
        private void PreOrder(StreamWriter Writer, clsNodo Raiz)
        {
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
            if (Raiz.Izquierda != null) PreOrder(Writer, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Writer, Raiz.Derecha);
        }
        private void PreOrder(DataGridView Grilla, clsNodo Raiz)
        {
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierda != null) PreOrder(Grilla, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Grilla, Raiz.Derecha);
        }
        private void PreOrder(TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
        }
        private void PostOrder(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Lista, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Lista, Raiz.Derecha);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
        }
        private void PostOrder(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Combo, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Combo, Raiz.Derecha);
            Combo.Items.Add(Raiz.Codigo);
        }
        private void PostOrder(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Writer, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Writer, Raiz.Derecha);
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
        }
        private void PostOrder(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Grilla, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Grilla, Raiz.Derecha);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
        }
        private void PostOrder(TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
        }
        private void CargarVectorInOrder(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierda != null)
            {
                CargarVectorInOrder(NodoPadre.Izquierda);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecha != null)
            {
                CargarVectorInOrder(NodoPadre.Derecha);
            }
        }
        private void EquilibrarArbol(int ini, int fin)
        {
            int m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
    }
}

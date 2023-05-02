using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        public TreeNode NodoTree;
        public TreeNode NuevoTree;
        public TreeNode AuxTree;
        public clsNodo ini;
        public clsNodo Raiz
        {
            get { return ini; }
            set { ini = value; }
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
        public void Recorrer(TreeView Tree)
        {
            Tree.Nodes.Clear();
            NodoTree = Tree.Nodes.Add(Raiz.Codigo.ToString());

            RecorrerTree(Tree, Raiz);
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
        public void RecorrerTree(TreeView Tree, clsNodo Nodo)
        {
            if (Nodo.Derecha != null)
            {
                NuevoTree = NodoTree.Nodes.Add(Nodo.Derecha.Codigo.ToString());
                RecorrerTree(Tree, Nodo.Derecha);
            }
            if (Nodo.Izquierda != null)
            {
                NuevoTree = NodoTree.Nodes.Add(Nodo.Izquierda.Codigo.ToString());
                RecorrerTree(Tree, Nodo.Izquierda);
            }
        }
        public void InOrderAcs(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Lista, Raiz.Izquierda);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Derecha != null) InOrderAcs(Lista, Raiz.Derecha);
        }
        public void InOrderAcs(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Combo, Raiz.Izquierda);
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Derecha != null) InOrderAcs(Combo, Raiz.Derecha);
        }
        public void InOrderAcs(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) InOrderAcs(Grilla, Raiz.Izquierda);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecha != null) InOrderAcs(Grilla, Raiz.Derecha);
        }
        public void InOrderDes(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Lista, Raiz.Derecha);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Izquierda != null) InOrderDes(Lista, Raiz.Izquierda);
        }
        public void InOrderDes(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Combo, Raiz.Derecha);
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierda != null) InOrderDes(Combo, Raiz.Izquierda);
        }
        public void InOrderDes(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Derecha != null) InOrderDes(Grilla, Raiz.Derecha);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierda != null) InOrderDes(Grilla, Raiz.Izquierda);
        }
        public void PreOrder(ListBox Lista, clsNodo Raiz)
        {
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
            if (Raiz.Izquierda != null) PreOrder(Lista, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Lista, Raiz.Derecha);
        }
        public void PreOrder(ComboBox Combo, clsNodo Raiz)
        {
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierda != null) PreOrder(Combo, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Combo, Raiz.Derecha);
        }
        public void PreOrder(DataGridView Grilla, clsNodo Raiz)
        {
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierda != null) PreOrder(Grilla, Raiz.Izquierda);
            if (Raiz.Derecha != null) PreOrder(Grilla, Raiz.Derecha);
        }
        public void PostOrder(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Lista, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Lista, Raiz.Derecha);
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);
        }
        public void PostOrder(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Combo, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Combo, Raiz.Derecha);
            Combo.Items.Add(Raiz.Codigo);
        }
        public void PostOrder(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierda != null) PostOrder(Grilla, Raiz.Izquierda);
            if (Raiz.Derecha != null) PostOrder(Grilla, Raiz.Derecha);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
        }
    }
}

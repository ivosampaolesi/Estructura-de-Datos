using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSampaolesiI.Clases
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;         
        
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo ant = Raiz; 
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    ant = aux;
                    if (Nvo.Codigo < aux.Codigo) aux = aux.Izquierdo;
                    else aux = aux.Derecho;
                }
                
                if (Nvo.Codigo < ant.Codigo) ant.Izquierdo = Nvo;
                else ant.Derecho = Nvo;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            Raiz = Eliminar(Raiz, Codigo);
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void Recorrer(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            if (Raiz != null)
            {
                Arbol.Nodes.Add(CargarNodo(Raiz));
                Arbol.ExpandAll();
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void Recorrer(clsNodo[] Vector)
        {
            Int32 i = 0;
            InOrdenAsc(Vector, Raiz, ref i);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        private void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        private void InOrdenAsc(clsNodo[] Vector, clsNodo R, ref Int32 i)
        {
            if (R.Izquierdo != null) InOrdenAsc(Vector, R.Izquierdo, ref i);
            Vector[i] = R;
            i++;
            if (R.Derecho != null) InOrdenAsc(Vector, R.Derecho, ref i);
        }

        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Dgv, R.Derecho);
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        private TreeNode CargarNodo(clsNodo R)
        {
            TreeNode Nodo = new TreeNode(R.Codigo + " - " + R.Nombre + " - " + R.Tramite);

            if (R.Izquierdo != null) Nodo.Nodes.Add(CargarNodo(R.Izquierdo));
            if (R.Derecho != null) Nodo.Nodes.Add(CargarNodo(R.Derecho));

            return Nodo;
        }

        private clsNodo Eliminar(clsNodo R, Int32 Codigo)
        {
            if (Codigo < R.Codigo)
            {
                R.Izquierdo = Eliminar(R.Izquierdo, Codigo);
            }
            else
            {
                if (Codigo > R.Codigo)
                {
                    R.Derecho = Eliminar(R.Derecho, Codigo);
                }
                else
                {
                    if (R.Izquierdo == null) R = R.Derecho;
                    else
                    {
                        if (R.Derecho == null) R = R.Izquierdo;
                        else
                        {
                            clsNodo aux = R.Derecho;
                            while (aux.Izquierdo != null)
                            {
                                aux = aux.Izquierdo;
                            }
                            R.Codigo = aux.Codigo;
                            R.Nombre = aux.Nombre;
                            R.Tramite = aux.Tramite;
                            R.Derecho = Eliminar(R.Derecho, aux.Codigo);
                        }
                    }
                }
            }
            return R;
        }


    }
}

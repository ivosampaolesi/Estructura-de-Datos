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

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }


    }
}

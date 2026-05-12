using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple(); 

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaSimple);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer();
            }

        }
    }
}

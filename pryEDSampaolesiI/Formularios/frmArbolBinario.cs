using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryEDSampaolesiI.Clases;

namespace pryEDSampaolesiI.Formularios
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario Arbol = new clsArbolBinario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            Arbol.Agregar(nuevo);
            Arbol.Recorrer(dgvListaDoble);
            Arbol.Recorrer(cmbLista);
            Arbol.Recorrer(treeView1);

            btnEquilibrar.Enabled = true;

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbLista.Text);
            Arbol.Eliminar(codigo);
            Arbol.Recorrer(dgvListaDoble);
            Arbol.Recorrer(cmbLista);
            Arbol.Recorrer(treeView1);

            if (Arbol.Raiz == null) btnEquilibrar.Enabled = false;

            cmbLista.Focus();
            btnBorrar.Enabled = false;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(dgvListaDoble);
            Arbol.Recorrer(cmbLista);
            Arbol.Recorrer(treeView1);
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                Arbol.Recorrer(dgvListaDoble);
                Arbol.Recorrer(treeView1);
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                Arbol.RecorrerPreOrden(dgvListaDoble);
                Arbol.Recorrer(treeView1);
            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
            {
                Arbol.RecorrerPostOrden(dgvListaDoble);
                Arbol.Recorrer(treeView1);
            }
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBorrar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}

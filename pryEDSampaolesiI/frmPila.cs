using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDSampaolesiI
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            Pila.Agregar(nuevo);
            Pila.Recorrer(lstPila);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer("Pila.csv");
            
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigo.Text = Pila.Primero.Codigo.ToString();
                lblNombre.Text = Pila.Primero.Nombre;
                lblTramite.Text = Pila.Primero.Tramite;

                Pila.Eliminar();
                Pila.Recorrer(lstPila);
                Pila.Recorrer(dgvPila);
                Pila.Recorrer("Pila.csv");
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}

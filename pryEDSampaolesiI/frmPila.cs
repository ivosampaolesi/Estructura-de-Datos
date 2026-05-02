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
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer("ArchivoPila.csv"); 

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           if (Pila.Primero != null)
           {
                lblCodigo.Text =Pila.Primero.Codigo.ToString();
                lblNombre.Text=Pila.Primero.Nombre;
                lblTramite.Text =Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer("ArchivoPila.csv");
           }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
                 
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Pila.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvPila);
          
        }


    }
}

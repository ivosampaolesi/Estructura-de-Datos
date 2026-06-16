using System;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmConsultaOperaciones : Form
    {
        clsBaseDatos bd = new clsBaseDatos();

        public frmConsultaOperaciones()
        {
            InitializeComponent();
        }

        private void frmConsultaOperaciones_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("Todos los libros");
            cmbOperacion.Items.Add("Título, precio y cantidad");
            cmbOperacion.Items.Add("Libros con stock menor a 5");
            
        }

        
        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedItem != null)
            {
                btnListar.Enabled= true;
            }

            switch (cmbOperacion.SelectedIndex)
            {
                case 0:
                    txtConsulta.Text = "SELECT * FROM Libro";
                    break;
                case 1:
                    txtConsulta.Text = "SELECT Titulo, Precio, Cantidad FROM Libro";
                    break;
                case 2:
                    txtConsulta.Text = "SELECT Titulo, Cantidad FROM Libro WHERE Cantidad < 5";
                    break;

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            bd.Listar(dgvDatos, txtConsulta.Text);
            btnListar.Enabled = false;
        }
    }
}

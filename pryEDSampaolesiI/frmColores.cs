using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo= "Colores.csv";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstColores);

            MessageBox.Show("Dato grabado correctamente");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
           
        }

        private void frmColores_Load(object sender, EventArgs e)
        {

        }
    }
}

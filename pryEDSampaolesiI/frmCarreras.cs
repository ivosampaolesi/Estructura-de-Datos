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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Carreras.csv";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstCarreras);

            MessageBox.Show("Dato grabado correctamente");
        }
    }
}

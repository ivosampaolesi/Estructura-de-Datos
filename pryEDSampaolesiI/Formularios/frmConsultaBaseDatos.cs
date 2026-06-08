using System;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmConsultaBaseDatos : Form
    {
        public frmConsultaBaseDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvDatos, txtConsulta.Text);
        }
    }
}

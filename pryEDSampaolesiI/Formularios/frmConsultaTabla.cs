using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pryEDSampaolesiI.Clases;

namespace pryEDSampaolesiI
{
    public partial class frmConsultaTabla : Form
    {
        public frmConsultaTabla()
        {
            InitializeComponent();
        }

        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {
         
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(cmbTabla.Text, dgvDatos);
        }
    }
}


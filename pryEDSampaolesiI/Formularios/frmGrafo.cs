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
    public partial class frmGrafo : Form
    {
        clsGrafo grafo = new clsGrafo();

        public frmGrafo()
        {
            InitializeComponent();
            Load += frmGrafo_Load;
            btnCargar.Click += btnCargar_Click;
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigenCarga);
            grafo.MostrarCiudades(cmbOrigenConsulta);
            grafo.MostrarCiudades(cmbDesde);
            grafo.MostrarCiudades(cmbDestinoCarga);
            grafo.MostrarCiudades(cmbDestinoConsulta);
            grafo.MostrarCiudades(cmbHasta);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenCarga.SelectedIndex;
            Int32 c = cmbDestinoCarga.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecioCarga.Text);
            grafo.Agregar(f, c, p);
            grafo.MostrarTodo(dgvGrafo);
            lblListarViajes.Text = "Listado completo de viajes";
            txtPrecioCarga.Text = "";
        }
    }
}

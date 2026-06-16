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
            
            btnCargar.Enabled = false;
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
            btnCargar.Enabled = false;

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvGrafo);
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigenConsulta.SelectedIndex;
            Int32 destino = cmbDestinoConsulta.SelectedIndex;
            Decimal precio = grafo.Consultar(destino, origen);
            if (precio > 0)
                lblListarViajes.Text = "$ " + precio.ToString();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigenConsulta.SelectedIndex;
            Int32 destino = cmbDestinoConsulta.SelectedIndex;
            grafo.Eliminar(destino, origen);
            grafo.MostrarTodo(dgvGrafo);
            
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            grafo.MostrarDestinos(cmbDesde.SelectedIndex, dgvGrafo);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            grafo.MostrarOrigenes(cmbHasta.SelectedIndex, dgvGrafo);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }

        private void txtPrecioCarga_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioCarga.Text != null && cmbOrigenCarga.SelectedItem!=null && cmbDestinoCarga.SelectedItem != null)
            {
                btnCargar.Enabled = true;
            } 
        }

        private void cmbDestinoCarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPrecioCarga.Text != null && cmbOrigenCarga.SelectedItem != null && cmbDestinoCarga.SelectedItem != null)
            {
                btnCargar.Enabled = true;
            }
        }

        private void cmbOrigenCarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPrecioCarga.Text != "" && cmbOrigenCarga.SelectedItem != null && cmbDestinoCarga.SelectedItem != null)
            {
                btnCargar.Enabled = true;
            }
        }


    }
}

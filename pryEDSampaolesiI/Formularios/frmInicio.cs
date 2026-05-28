using pryEDSampaolesiI.Formularios;
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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador x = new frmDatosDesarrollador();
            x.ShowDialog(); 
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores x = new frmColores();
            x.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses x = new frmMeses();
            x.ShowDialog(); 
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras x = new frmCarreras();
            x.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();
            x.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos x = new frmAlumnos();
            x.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.ShowDialog();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila x = new frmPila();
            x.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple x = new frmListaSimple();
            x.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble x = new frmListaDoble();
            x.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo x = new frmGrafo();
            x.ShowDialog();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario x = new frmArbolBinario();
            x.ShowDialog();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTabla x = new frmConsultaTabla();
            x.ShowDialog();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDatos x = new frmConsultaBaseDatos();
            x.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatos x = new frmBaseDatos();
            x.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepasoOperacionesBaseDatos x = new frmRepasoOperacionesBaseDatos();
            x.ShowDialog();
        }
    }
}

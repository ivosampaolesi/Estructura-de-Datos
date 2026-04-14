using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Alumnos.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvAlumnos);
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NombreArchivo = "Carreras.csv";
            if (File.Exists(objCarrera.NombreArchivo)) objCarrera.Recorrer(cmbCarrera);

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            objAlumnos.NombreArchivo = "Alumnos.csv";
            objAlumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objAlumnos.Recorrer(dgvAlumnos);
            MessageBox.Show("Dato grabado");
        }
    }
}

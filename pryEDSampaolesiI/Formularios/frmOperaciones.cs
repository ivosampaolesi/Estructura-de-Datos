using System;
using System.Windows.Forms;

namespace pryEDSampaolesiI
{
    public partial class frmOperaciones : Form
    {
        clsBaseDatos bd = new clsBaseDatos();

        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Titulo FROM Libro");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Titulo, Año FROM Libro");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE IdAutor = 4");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE IdAutor = 3 AND IdIdioma = 3");
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE Titulo LIKE '%a%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Nombre FROM Idioma UNION SELECT Nombre FROM Pais");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Idioma.Nombre FROM Idioma INNER JOIN Pais ON Idioma.Nombre = Pais.Nombre");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Nombre FROM Idioma WHERE Nombre NOT IN (SELECT Nombre FROM Pais)");
        }

  
    }
}

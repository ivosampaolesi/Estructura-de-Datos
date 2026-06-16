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
            bd.Listar(dgvDatos, "SELECT Titulo, Año, Precio FROM Libro");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE Cantidad < 5");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE Precio > 100 AND Cantidad > 7");
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT * FROM Libro WHERE Titulo LIKE 'E%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Titulo FROM Libro WHERE Precio > 700 " + "UNION SELECT Titulo FROM Libro WHERE Cantidad > 5");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT L.Titulo FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor WHERE A.Nombre LIKE 'G%'");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvDatos, "SELECT Titulo FROM Libro WHERE IdIdioma = 1 AND IdLibro NOT IN (SELECT IdLibro FROM Libro WHERE IdIdioma = 2)");
        }

  
    }
}

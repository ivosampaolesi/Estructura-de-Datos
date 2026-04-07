using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace pryEDSampaolesiI
{
    internal class clsArchivoTexto
    {
        public string NombreArchivo = "Colores.txt";


        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.WriteLine("Hola");
            AD.Close();
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true); 
            AD.WriteLine(Dato);
            AD.Close(); 
        }
        public void Grabar(String Codigo, String Nombre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.Write(Codigo);
            AD.Write(";");
            AD.WriteLine(Nombre);
            AD.Close();
        }


        public void Recorrer()
        {

        }   
    }
}

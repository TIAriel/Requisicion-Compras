using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class Manejador_Archivos
    {
        Acceso_Archivos aa = new Acceso_Archivos();

        public void SubirArchivo(string nombre, byte[] contenido, int idSolicitud)
        {
            aa.GuardarArchivo(nombre, contenido, idSolicitud);
        }

        public void AbrirPDF(int ID)
        {
            aa.AbrirPDF(ID);
        }

        public void MostrarPDF(DataGridView tabla, int ID)
        {
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = aa.MostrarPDF(ID).Tables["archivos"];
            tabla.Columns[0].Visible = false;
            tabla.Columns[1].Visible = false;
        }
    }
}

using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class Manejador_Usuario
    {
        Acceso_Usuario au = new Acceso_Usuario();

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.DataSource = au.Mostrar().Tables["usuarios"];
        }
    }
}

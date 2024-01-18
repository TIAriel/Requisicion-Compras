using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{

    public class Manejador_Producto
    {
        Acceso_Producto ap = new Acceso_Producto();

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
        }

        public void Eliminar(int id)
        {
            ap.Eliminar(id);
        }

        public void Mostrar(DataGridView tabla, int filtro)
        {
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.Columns[0].Visible = false;
            tabla.Columns[1].Visible = false;
        }

        public void MostrarCatalogo(ComboBox caja, string filtro)
        {
            caja.DataSource = ap.MostrarCatalogo(filtro).Tables["catalogo"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "id";
        }

        public string InfoProducto(string variable, string condicion)
        {
            return ap.InfoProducto(variable, condicion);
        }
    }
}

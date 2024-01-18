using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos
{
    public class Acceso_Producto
    {
        Conexion connetion;
        public Acceso_Producto()
        {
            connetion = new Conexion("database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com", "root", "GSerrano2023.", "Requisicion");
        }

        public void Guardar(dynamic Entidad)
        {
            connetion.EjecutarConsulta(string.Format("INSERT INTO productos VALUES(NULL,{0},'{1}','{2}','{3}','{4}','{5}')", Entidad.Fkid, Entidad.N, Entidad.Cantidad, Entidad.Unidad, Entidad.Descripcion, Entidad.Referencia));
        }

        public DataSet Mostrar(int filtro)
        {
            return connetion.Obtener(string.Format("CALL ShowProductos({0})", filtro), "productos");
        }

        public DataSet MostrarCatalogo(string filtro)
        {
            return connetion.Obtener(string.Format("CALL Vista_Catalogo('%{0}%')", filtro), "catalogo");
        }

        public string InfoProducto(string variable, string condificion)
        {
            return connetion.ObtenerDato(string.Format("SELECT {0} FROM catalogo WHERE nombre = '{1}'", variable, condificion));
        }

        public void Eliminar(int id)
        {
            connetion.EjecutarConsulta(string.Format("DELETE FROM productos WHERE id = {0}", id));
        }
    }
}

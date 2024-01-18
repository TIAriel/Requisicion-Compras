using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Acceso_Usuario
    {
        Conexion connection;
        public Acceso_Usuario()
        {
            connection = new Conexion("database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com", "root", "GSerrano2023.", "Requisicion");
        }

        public void Guardar(dynamic Entidad)
        {
            connection.EjecutarConsulta(string.Format("call insertusuario('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", Entidad.Nombre, Entidad.Empresa, Entidad.Puesto, Entidad.Area, Entidad.Nusuario, Entidad.Clave, Entidad.TipoUsuario));
        }

        public DataSet Mostrar()
        {
            return connection.Obtener(string.Format("SELECT * FROM usuarios"), "usuarios");
        }
    }
}

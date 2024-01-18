using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Acceso_Login
    {
        Conexion connection;

        public Acceso_Login()
        {
            try
            {
                connection = new Conexion("database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com", "root", "GSerrano2023.", "Requisicion");
                //conexion = new Conexion("localhost", "root", "", "requisicion");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló La Conexión " + ex.Message);
            }
        }

        public bool ExisteRegistro(string nombre, string clave)
        {
            try
            {
                string consulta = string.Format("call validar('{0}', '{1}')", nombre, clave);
                var existe = connection.Existencia(consulta);
                if (existe == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló La Consulta", ex.Message);
                return false;
            }
        }

        public string Permiso(string usuario, string clave)
        {
            return connection.ObtenerDato(string.Format("SELECT permisos FROM usuarios WHERE usuario= '{0}' AND clave = '{1}'", usuario, clave));
        }
    }

}

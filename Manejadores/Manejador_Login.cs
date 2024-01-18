using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;
namespace Manejadores
{
    public class Manejador_Login
    {
        Acceso_Login al = new Acceso_Login();
        public bool ExisteRegistro(string nombre, string clave)
        {
            var existe = al.ExisteRegistro(nombre, clave);
            return existe;
        }

        public string Permiso(string usuario, string clave)
        {
            return al.Permiso(usuario, clave);
        }
    }
}

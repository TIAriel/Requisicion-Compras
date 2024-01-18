using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public Usuario(string nombre, string empresa, string puesto, string area, string nusuario, string clave, string tipoUsuario)
        {
            Nombre = nombre;
            Empresa = empresa;
            Puesto = puesto;
            Area = area;
            Nusuario = nusuario;
            Clave = clave;
            TipoUsuario = tipoUsuario;
        }

        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Nusuario { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}

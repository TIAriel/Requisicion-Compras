using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Solicitante
    {
        public Solicitante(int id, int folio, string nombre, string empresa, string puesto, string area, string articulo, string fecha, string prioridad, string estatus, string tipo)
        {
            Id = id;
            Folio = folio;
            Nombre = nombre;
            Empresa = empresa;
            Puesto = puesto;
            Area = area;
            Articulo = articulo;
            Fecha = fecha;
            Prioridad = prioridad;
            Estatus = estatus;
            Tipo = tipo;
        }

        public int Id { get; set; }
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Articulo { get; set; }
        public string Fecha { get; set; }
        public string Prioridad { get; set; }
        public string Estatus { get; set; }
        public string Tipo { get; set; }
    }
}

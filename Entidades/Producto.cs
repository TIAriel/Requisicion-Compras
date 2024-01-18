using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto(int id, int fkid, int n, int cantidad, string unidad, string descripcion, string referencia)
        {
            Id = id;
            Fkid = fkid;
            N = n;
            Cantidad = cantidad;
            Unidad = unidad;
            Descripcion = descripcion;
            Referencia = referencia;
        }

        public int Id { get; set; }
        public int Fkid { get; set; }
        public int N { get; set; }
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
    }
}

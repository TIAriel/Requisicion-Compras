using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class Manejador_Solicitud
    {
        Acceso_Solicitud acs = new Acceso_Solicitud();

        public void Guardar(dynamic Entidad)
        {
            acs.Guardar(Entidad);
        }

        public void GuardarComentario(string texto, int id)
        {
            acs.GuardarComentario(texto, id);
        }

        public void Eliminar(string id)
        {
            acs.Eliminar(id);
        }

        public void ActualizarEstatus(int id, string estatus, string empresa)
        {
            acs.ActualizarEstatus(id, estatus, empresa);
        }

        public void MostrarRequisiciones(DataGridView tabla, string nombre, string estatus, string tipo)
        {
            tabla.DataSource = acs.MostrarRequisiciones(nombre, estatus, tipo).Tables["solicitudes"];
        }

        public string Dato(string condicion, string usuario)
        {
            return acs.Dato(condicion, usuario);
        }

        public string Folio(string empresa)
        {
            return acs.Folio(empresa);
        }

        public string ID(string folio, string empresa)
        {
            return acs.ID(folio, empresa);
        }

        public string Comentario(int id)
        {
            return acs.Comentario(id);
        }
    }
}

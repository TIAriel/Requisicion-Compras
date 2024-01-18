using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos
{
    public class Acceso_Solicitud
    {
        Conexion connection;

        public Acceso_Solicitud()
        {
            connection = new Conexion("database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com", "root", "GSerrano2023.", "Requisicion");
        }

        public void Guardar(dynamic Entidad)
        {
            connection.EjecutarConsulta(string.Format("INSERT INTO solicitudes VALUES(NULL, {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", Entidad.Folio, Entidad.Nombre, Entidad.Empresa, Entidad.Puesto, Entidad.Area, Entidad.Articulo, Entidad.Fecha, Entidad.Prioridad, Entidad.Estatus, Entidad.Tipo));
        }

        public void GuardarComentario(string texto, int id)
        {
            connection.EjecutarConsulta(string.Format("INSERT INTO Comentarios VALUES(NULL, '{0}', {1})", texto, id));
        }

        public void Eliminar(string id)
        {
            connection.EjecutarConsulta(string.Format("DELETE FROM solicitudes WHERE id = {0}", id));
        }

        public void ActualizarEstatus(int id, string estatus, string empresa)
        {
            connection.EjecutarConsulta(string.Format("UPDATE solicitudes SET estatus = '{0}' WHERE id = {1} AND empresa = '{2}';", estatus, id, empresa));
        }

        public DataSet MostrarRequisiciones(string nombre, string estatus, string tipo)
        {
            return connection.Obtener(string.Format("CALL Solicitudes('%{0}%', '%{1}%', '%{2}%');", nombre, estatus, tipo), "solicitudes");
        }

        public string Dato(string condicion, string usuario)
        {
            return connection.ObtenerDato(string.Format("SELECT {0} FROM usuarios WHERE usuario = '{1}'", condicion, usuario));
        }

        public string Folio(string empresa)
        {
            return connection.ObtenerDato(string.Format("SELECT folio FROM solicitudes WHERE empresa = '{0}' ORDER BY folio DESC LIMIT 1", empresa));
        }

        public string ID(string folio, string empresa)
        {
            return connection.ObtenerDato(string.Format("SELECT id FROM solicitudes WHERE folio ={0} AND empresa = '{1}'", folio, empresa));
        }

        public string Comentario(int id)
        {
            return connection.ObtenerDato(string.Format("SELECT comentario FROM Comentarios WHERE FKSolicitud = {0}", id));
        }
    }
}

using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class FrmSolicitudes : Form
    {
        Manejador_Solicitud ms;
        public static string folio, nombre, empresa, puesto, area, articulo, prioridad, fecha;
        public static Boolean usuario = false;

        public FrmSolicitudes()
        {
            InitializeComponent();
            ms = new Manejador_Solicitud();
        }

        private void FrmSolicitudes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgSolicitudesUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = true;
            folio = dtgSolicitudesUsuario.CurrentRow.Cells["Folio"].Value.ToString();
            nombre = dtgSolicitudesUsuario.CurrentRow.Cells["Nombre del Solicitante"].Value.ToString();
            empresa = dtgSolicitudesUsuario.CurrentRow.Cells["Empresa"].Value.ToString();
            puesto = dtgSolicitudesUsuario.CurrentRow.Cells["Puesto"].Value.ToString();
            area = dtgSolicitudesUsuario.CurrentRow.Cells["Area"].Value.ToString();
            articulo = dtgSolicitudesUsuario.CurrentRow.Cells["Articulo"].Value.ToString();
            fecha = dtgSolicitudesUsuario.CurrentRow.Cells["Fecha de la Solicitud"].Value.ToString();
            prioridad = dtgSolicitudesUsuario.CurrentRow.Cells["Prioridad"].Value.ToString();

            FrmSolicitud fs = new FrmSolicitud();
            fs.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            ms.MostrarRequisiciones(dtgSolicitudesUsuario, FrmMenu.nombre, FrmMenu.estatus, FrmMenu.tipo);
            if (dtgSolicitudesUsuario.Rows.Count == 0) 
            {
                dtgSolicitudesUsuario.Enabled = false;
            }
            else
            {
                dtgSolicitudesUsuario.Enabled = true;
            }
            usuario = false;
        }
    }
}

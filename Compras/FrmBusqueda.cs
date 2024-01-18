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
    public partial class FrmBusqueda : Form
    {
        Manejador_Solicitud ms;
        public static string folio, nombre, empresa, puesto, area, articulo, prioridad, fecha;

        public FrmBusqueda()
        {
            InitializeComponent();
            ms = new Manejador_Solicitud();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            folio = dtgSolicitudes.CurrentRow.Cells["Folio"].Value.ToString();
            nombre = dtgSolicitudes.CurrentRow.Cells["Nombre del Solicitante"].Value.ToString();
            empresa = dtgSolicitudes.CurrentRow.Cells["Empresa"].Value.ToString();
            puesto = dtgSolicitudes.CurrentRow.Cells["Puesto"].Value.ToString();
            area = dtgSolicitudes.CurrentRow.Cells["Area"].Value.ToString();
            articulo = dtgSolicitudes.CurrentRow.Cells["Articulo"].Value.ToString();
            fecha = dtgSolicitudes.CurrentRow.Cells["Fecha de la Solicitud"].Value.ToString();
            prioridad = dtgSolicitudes.CurrentRow.Cells["Prioridad"].Value.ToString();
        }

        void Actualizar()
        {
            ms.MostrarRequisiciones(dtgSolicitudes, txtNombre.Text, "Pendiente", "Normal");
            if (dtgSolicitudes.Rows.Count == 0)
            {
                dtgSolicitudes.Enabled = false;
            }
            else
            {
                dtgSolicitudes.Enabled = true;
            }
        }
    }
}

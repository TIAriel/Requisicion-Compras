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
    public partial class FrmSolicitud : Form
    {
        Manejador_Producto mp;
        Manejador_Solicitud ms;
        Manejador_Archivos ma;

        string id;

        public FrmSolicitud()
        {
            InitializeComponent();
            mp = new Manejador_Producto();
            ms = new Manejador_Solicitud();
            ma = new Manejador_Archivos();
        }

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            Botonera(FrmMenu.eliminar, FrmMenu.autorizar, FrmMenu.rechazar);

            if (FrmSolicitudes.usuario)
            {
                lblFolio.Text = FrmSolicitudes.folio;
                lblNombre.Text = FrmSolicitudes.nombre;
                lblEmpresa.Text = FrmSolicitudes.empresa;
                lblPuesto.Text = FrmSolicitudes.puesto;
                lblArea.Text = FrmSolicitudes.area;
                lblTipo.Text = FrmSolicitudes.articulo;
                lblFecha.Text = FrmSolicitudes.fecha;
                lblPrioridad.Text = FrmSolicitudes.prioridad;
            }
            else
            {
                lblFolio.Text = FrmBusqueda.folio;
                lblNombre.Text = FrmBusqueda.nombre;
                lblEmpresa.Text = FrmBusqueda.empresa;
                lblPuesto.Text = FrmBusqueda.puesto;
                lblArea.Text = FrmBusqueda.area;
                lblTipo.Text = FrmBusqueda.articulo;
                lblFecha.Text = FrmBusqueda.fecha;
                lblPrioridad.Text = FrmBusqueda.prioridad;
            }
            id = ms.ID(lblFolio.Text, lblEmpresa.Text);
            
            ma.MostrarPDF(dtgArchivos, int.Parse(id));
            Actualizar();
            txtComentario.Text = ms.Comentario(int.Parse(id));
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos,int.Parse(id));
            if (dtgProductos.Rows.Count == 0)
            {
                dtgProductos.Enabled = false;
            }
            else
            {
                dtgProductos.Enabled = true;
            }
        }

        void Botonera(Boolean el, Boolean au, Boolean re)
        {
            btnEliminar.Visible = el;
            btnAutorizar.Visible = au;
            btnRechazar.Visible = re;
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = dtgProductos.CurrentRow.Cells["ID"].Value.ToString();

            mp.Eliminar(int.Parse(id));
            btnEliminar.Enabled = false;
            Actualizar();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            ms.ActualizarEstatus(int.Parse(id), "Autorizada", lblEmpresa.Text);
            this.Close();
        }

        private void dtgArchivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dtgArchivos.CurrentRow.Cells["ID"].Value.ToString());
            ma.AbrirPDF(ID);
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            ms.ActualizarEstatus(int.Parse(id), "Rechazada", lblEmpresa.Text);
            this.Close ();
        }
    }
}

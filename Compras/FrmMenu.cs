using Manejadores;
using System;
using System.Windows.Forms;

namespace Compras
{
    public partial class FrmMenu : Form
    {
        Manejador_Solicitud ms;
        public static string nombre, estatus, tipo;
        public static Boolean eliminar, autorizar, rechazar;

        public FrmMenu()
        {
            InitializeComponent();
            ms = new Manejador_Solicitud();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Permisos(FrmLogin.requisicion, FrmLogin.requisicionc, FrmLogin.usuario, FrmLogin.empresa);
            SubPermisos(FrmLogin.au, FrmLogin.re, FrmLogin.pe, FrmLogin.bu);
        }

        void Permisos(Boolean r, Boolean c, Boolean u, Boolean e)
        {
            tsmiRequisiciones.Visible = r;
            tsmiUsuario.Visible = u;
        }

        void SubPermisos(Boolean a, Boolean r, Boolean p, Boolean bu)
        {
            tsmiRAutorizadas.Visible = a;
            tsmiRRechazadas.Visible = r;
            tsmiRPendientes.Visible = p;
            buscarToolStripMenuItem.Visible = bu;
        }

        private void tsmiNuevoU_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            AbrirFormulario(fu);
        }

        private void tsmiMostrarU_Click(object sender, EventArgs e)
        {
            FrmMUsuarios fmu = new FrmMUsuarios();
            AbrirFormulario(fmu);
        }

        private void tsmiRMisRequisiciones_Click(object sender, EventArgs e)
        {
            nombre = ms.Dato("nombre", FrmLogin.user);
            estatus = "";
            tipo = "Normal";
            FrmSolicitudes fs = new FrmSolicitudes();
            AbrirFormulario(fs);
        }

        private void tsmiRNueva_Click(object sender, EventArgs e)
        {
            FrmDatos fd = new FrmDatos();
            AbrirFormulario(fd);
        }

        private void tsmiRAutorizadas_Click(object sender, EventArgs e)
        {
            Botonera(false, false, false);
            nombre = "";
            estatus = "Autorizada";
            tipo = "Normal";
            FrmSolicitudes fs = new FrmSolicitudes();
            AbrirFormulario(fs);
        }

        private void tsmiRRechazadas_Click(object sender, EventArgs e)
        {
            Botonera(false, false, false);
            nombre = "";
            estatus = "Rechazada";
            tipo = "Normal";
            FrmSolicitudes fs = new FrmSolicitudes();
            AbrirFormulario(fs);
        }

        private void tsmiRPendientes_Click(object sender, EventArgs e)
        {
            Botonera(true, true, true);
            nombre = "";
            estatus = "Pendiente";
            tipo = "Normal";
            FrmSolicitudes fs = new FrmSolicitudes();
            AbrirFormulario(fs);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda();
            AbrirFormulario(fb);
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
        }

        public void AbrirFormulario(Form fr)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }
            fr.TopLevel = false;
            this.pnlPrincipal.Controls.Add(fr);
            fr.Show();
        }
        void Botonera(Boolean el, Boolean au, Boolean re)
        {
            eliminar = el;
            autorizar = au;
            rechazar = re;
        }
    }
}

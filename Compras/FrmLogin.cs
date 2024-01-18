using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace Compras
{
    public partial class FrmLogin : Form
    {
        Manejador_Login ml;
        public static string filtro = "", estatus = "", user = "";
        public static Boolean comite = false, requisicion, requisicionc, usuario, empresa, au, re, pe, bu;

        public FrmLogin()
        {
            InitializeComponent();
            ml = new Manejador_Login();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Hide();
            filtro = txtUsuario.Text;
            if (ml.ExisteRegistro(txtUsuario.Text, txtClave.Text))
            {
                string permiso = ml.Permiso(txtUsuario.Text, txtClave.Text);
                if (permiso == "Administrador")
                {
                    Permisos(true, true, true);
                    SubPermisos(true, true, true, true);

                    AbriFormulario();

                }
                else if (permiso == "Compras")
                {
                    Permisos(true, false, false);
                    SubPermisos(true, true, true, true);

                    AbriFormulario();

                }
                else if(permiso == "Usuario")
                {
                    Permisos(true, false, false);
                    SubPermisos(false, false, false, false);
                    AbriFormulario();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Son Incorrectos","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
                Show();
            }
        }

        void AbriFormulario()
        {
            user = txtUsuario.Text;
            FrmMenu fm = new FrmMenu();
            fm.ShowDialog();
            txtUsuario.Clear();
            txtClave.Clear();
            this.Dispose();
        }

        public void Permisos(Boolean r, Boolean u, Boolean e)
        {
            requisicion = r;
            usuario = u;
            empresa = e;
        }

        public void SubPermisos(Boolean a, Boolean r, Boolean p, Boolean b)
        {
            au = a;
            re = r;
            pe = p;
            bu = b;
        }
    }
}

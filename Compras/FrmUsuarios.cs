using Entidades;
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
    public partial class FrmUsuarios : Form
    {
        Manejador_Usuario mu;

        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new Manejador_Usuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mu.Guardar(new Usuario(txtNombre.Text, txtEmpresa.Text, txtPuesto.Text, txtArea.Text, txtUsuario.Text, txtClave.Text, cmbTipo.Text));
            txtNombre.Clear();
            txtEmpresa.Clear();
            txtPuesto.Clear();
            txtArea.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtNombre.Focus();
        }
    }
}

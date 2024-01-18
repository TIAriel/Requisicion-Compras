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
    public partial class FrmMUsuarios : Form
    {
        Manejador_Usuario mu;

        public FrmMUsuarios()
        {
            InitializeComponent();
            mu = new Manejador_Usuario();
        }

        private void FrmMUsuarios_Load(object sender, EventArgs e)
        {
            mu.Mostrar(dtgUsuarios);
        }
    }
}

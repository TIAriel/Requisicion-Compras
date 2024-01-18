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
using Entidades;

namespace Compras
{
    public partial class FrmDatos : Form
    {
        public static string nombre, empresa, puesto, area, fecha, articulo, prioridad, folio;
        Manejador_Solicitud ms;
        public FrmDatos()
        {
            InitializeComponent();
            ms = new Manejador_Solicitud();
            lblNombre.Text = ms.Dato("nombre", FrmLogin.user);
            lblEmpresa.Text = ms.Dato("empresa", FrmLogin.user);
            lblPuesto.Text = ms.Dato("puesto", FrmLogin.user);
            lblArea.Text = ms.Dato("area", FrmLogin.user);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            folio = (int.Parse(ms.Folio(lblEmpresa.Text)) + 1).ToString();
            
            if (txtTipo.Text != "" && cmbPrioridad.Text != "")
            {
                Hide();
                nombre = lblNombre.Text;
                empresa = lblEmpresa.Text;
                puesto = lblPuesto.Text;
                area = lblArea.Text;
                fecha = DateTime.Now.ToString("d");
                prioridad = cmbPrioridad.Text;
                articulo = txtTipo.Text;

                ms.Guardar(new Solicitante(0, int.Parse(folio), nombre, empresa, puesto, area, articulo, fecha, prioridad, "Pendiente", "Normal"));

                FrmRequisicion fr = new FrmRequisicion();
                fr.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Llena todos los campos de la solicitud");
            }
        }
    }
}

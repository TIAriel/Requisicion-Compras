using Entidades;
using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class FrmRequisicion : Form
    {
        Manejador_Solicitud ms;
        Manejador_Producto mp;
        Manejador_Archivos ma;
        
        int n;
        string nombreArchivo = "", eliminar = "", id;
        byte[] contenidoPDF = null;

        public FrmRequisicion()
        {
            InitializeComponent();
            ms = new Manejador_Solicitud();
            mp = new Manejador_Producto();
            ma = new Manejador_Archivos();
            lblFolio.Text = FrmDatos.folio;
            lblNombre.Text = FrmDatos.nombre;
            lblEmpresa.Text = FrmDatos.empresa;
            lblPuesto.Text = FrmDatos.puesto;
            lblArea.Text = FrmDatos.area;
            lblTipo.Text = FrmDatos.articulo;
            lblPrioridad.Text = FrmDatos.prioridad;
            lblFecha.Text = DateTime.Now.ToString("d");
            id = ms.ID(lblFolio.Text, lblEmpresa.Text);
            mp.MostrarCatalogo(cmbProducto, txtBuscar.Text);
        }

        private void FrmRequisicion_Load(object sender, EventArgs e)
        {
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Desea Descartar La Requisición", "ATENCIÓN", MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                ms.Eliminar(ms.ID(lblFolio.Text, lblEmpresa.Text));
                this.Close();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.Text != "" && txtCantidad.Text != "" && txtUnidad.Text != "")
                {
                    n++;
                    mp.Guardar(new Producto(0, int.Parse(ms.ID(lblFolio.Text, lblEmpresa.Text)), n, int.Parse(txtCantidad.Text), txtUnidad.Text, cmbProducto.Text, mp.InfoProducto("referencia", cmbProducto.Text)));
                    cmbProducto.Text = "";
                    txtUnidad.Text = "";
                    txtCantidad.Clear();
                    txtBuscar.Clear();
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Llena Todos Los Campos Del Producto");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos, int.Parse(ms.ID(lblFolio.Text, lblEmpresa.Text)));
            if (dtgProductos.Rows.Count == 0)
            {
                dtgProductos.Enabled = false;
                btnEnviar.Enabled = false;
            }
            else
            {
                dtgProductos.Enabled = true;
                btnEnviar.Enabled = true;
            }
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            txtUnidad.Text = mp.InfoProducto("unidad", cmbProducto.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Está Seguro De Eliminar El " + eliminar + " Seleccionado?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                var id = dtgProductos.CurrentRow.Cells["ID"].Value.ToString();
                mp.Eliminar(int.Parse(id));
                Actualizar();
            }

            btnEliminar.Enabled = false;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            eliminar = "Producto";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mp.MostrarCatalogo(cmbProducto, txtBuscar.Text);
        }

        private void dtgArchivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dtgArchivos.CurrentRow.Cells["ID"].Value.ToString());
            string Nombre = dtgArchivos.CurrentRow.Cells["Archivo"].Value.ToString();
            ma.AbrirPDF(ID, Nombre);
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                contenidoPDF = File.ReadAllBytes(rutaArchivo);

                string[] archivo = rutaArchivo.Split('\\');
                nombreArchivo = archivo[archivo.Length - 1];
                ma.SubirArchivo(nombreArchivo, contenidoPDF, int.Parse(id));

                ma.MostrarPDF(dtgArchivos, int.Parse(id));
            }

            nombreArchivo = "";
            contenidoPDF = null;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dtgProductos.Rows.Count != 0)
            {
                ms.GuardarComentario(txtComentario.Text, int.Parse(id));
                MessageBox.Show("Requisición Enviada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Requisición Vacía, Ingresa Algún Producto");
            }
        }
    }
}

namespace Compras
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoU = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMostrarU = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRequisiciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRMisRequisiciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRAutorizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRRechazadas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRPendientes = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 31);
            this.panel2.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuario,
            this.tsmiRequisiciones,
            this.tsmiCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoU,
            this.tsmiMostrarU});
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(74, 20);
            this.tsmiUsuario.Text = "Usuarios";
            // 
            // tsmiNuevoU
            // 
            this.tsmiNuevoU.Name = "tsmiNuevoU";
            this.tsmiNuevoU.Size = new System.Drawing.Size(171, 22);
            this.tsmiNuevoU.Text = "Agregar Nuevo";
            this.tsmiNuevoU.Click += new System.EventHandler(this.tsmiNuevoU_Click);
            // 
            // tsmiMostrarU
            // 
            this.tsmiMostrarU.Name = "tsmiMostrarU";
            this.tsmiMostrarU.Size = new System.Drawing.Size(171, 22);
            this.tsmiMostrarU.Text = "Ver Todos";
            this.tsmiMostrarU.Click += new System.EventHandler(this.tsmiMostrarU_Click);
            // 
            // tsmiRequisiciones
            // 
            this.tsmiRequisiciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRMisRequisiciones,
            this.tsmiRNueva,
            this.tsmiRAutorizadas,
            this.tsmiRRechazadas,
            this.tsmiRPendientes,
            this.buscarToolStripMenuItem});
            this.tsmiRequisiciones.Name = "tsmiRequisiciones";
            this.tsmiRequisiciones.Size = new System.Drawing.Size(106, 20);
            this.tsmiRequisiciones.Text = "Requisiciones";
            // 
            // tsmiRMisRequisiciones
            // 
            this.tsmiRMisRequisiciones.Name = "tsmiRMisRequisiciones";
            this.tsmiRMisRequisiciones.Size = new System.Drawing.Size(187, 22);
            this.tsmiRMisRequisiciones.Text = "Mis Requisiciones";
            this.tsmiRMisRequisiciones.Click += new System.EventHandler(this.tsmiRMisRequisiciones_Click);
            // 
            // tsmiRNueva
            // 
            this.tsmiRNueva.Name = "tsmiRNueva";
            this.tsmiRNueva.Size = new System.Drawing.Size(187, 22);
            this.tsmiRNueva.Text = "Nueva";
            this.tsmiRNueva.Click += new System.EventHandler(this.tsmiRNueva_Click);
            // 
            // tsmiRAutorizadas
            // 
            this.tsmiRAutorizadas.Name = "tsmiRAutorizadas";
            this.tsmiRAutorizadas.Size = new System.Drawing.Size(187, 22);
            this.tsmiRAutorizadas.Text = "Autorizadas";
            this.tsmiRAutorizadas.Click += new System.EventHandler(this.tsmiRAutorizadas_Click);
            // 
            // tsmiRRechazadas
            // 
            this.tsmiRRechazadas.Name = "tsmiRRechazadas";
            this.tsmiRRechazadas.Size = new System.Drawing.Size(187, 22);
            this.tsmiRRechazadas.Text = "Rechazadas";
            this.tsmiRRechazadas.Click += new System.EventHandler(this.tsmiRRechazadas_Click);
            // 
            // tsmiRPendientes
            // 
            this.tsmiRPendientes.Name = "tsmiRPendientes";
            this.tsmiRPendientes.Size = new System.Drawing.Size(187, 22);
            this.tsmiRPendientes.Text = "Pendientes";
            this.tsmiRPendientes.Click += new System.EventHandler(this.tsmiRPendientes_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(107, 20);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pbxMinimizar);
            this.panel1.Controls.Add(this.pbxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 27);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::Compras.Properties.Resources.Minimizar_Rojo;
            this.pbxMinimizar.Location = new System.Drawing.Point(644, 0);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(24, 24);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMinimizar.TabIndex = 41;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = global::Compras.Properties.Resources.Close;
            this.pbxCerrar.Location = new System.Drawing.Point(673, 1);
            this.pbxCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(24, 24);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCerrar.TabIndex = 22;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 60);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(700, 440);
            this.pnlPrincipal.TabIndex = 31;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoU;
        private System.Windows.Forms.ToolStripMenuItem tsmiMostrarU;
        private System.Windows.Forms.ToolStripMenuItem tsmiRequisiciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiRMisRequisiciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiRNueva;
        private System.Windows.Forms.ToolStripMenuItem tsmiRAutorizadas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRRechazadas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRPendientes;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}
using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Forms.Facturacion.UserControls;
using Pantallas_Sistema_facturación.Forms.Tablas.UserControls;

namespace Pantallas_Sistema_facturación
{
    public partial class frmPrincipal : Form
    {
        // Instancias de los UserControls
        private ucFacturacion ucFacturacion;
        private ucInforme ucInforme;
        private ucProducto ucProducto;
        private ucCliente ucCliente;
        private ucCategoriasProductos ucCategoriasProductos;

        public frmPrincipal()
        {
            InitializeComponent();
            MostrarModuloTablas();
            MostrarBienvenida("Bienvenido al módulo de Tablas");
        }

        // Menú superior - Tablas
        private void menuTablas_Click(object sender, EventArgs e)
        {
            MostrarModuloTablas();
            MostrarBienvenida("Bienvenido al módulo de Tablas");
        }

        // Menú superior - Facturación
        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            MostrarModuloFacturacion();
            MostrarBienvenida("Bienvenido al módulo de Facturación");
        }

        // Menú superior - Principal/Security
        private void menuPrincipal_Click(object sender, EventArgs e)
        {
            OcultarModulosLaterales();
            MostrarBienvenida("Bienvenido al Sistema de Facturación");
        }
        private void menuSeguridad_Click(object sender, EventArgs e)
        {
            OcultarModulosLaterales();
            MostrarBienvenida("Bienvenido al módulo de Seguridad");
        }

        // Botones del lateral izquierdo
        private void btnFacturacionLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucFacturacion());
        }

        private void btnInformesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucInforme());
        }

        private void btnProductosLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucProducto());
        }

        private void btnClientesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucCliente());
        }

        private void btnCategoriasLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucCategoriasProductos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Métodos para mostrar/ocultar módulos laterales
        private void MostrarModuloTablas()
        {
            // Oculta módulo facturación
            lblModuloFacturacion.Visible = false;
            btnFacturacionLeft.Visible = false;
            btnInformesLeft.Visible = false;
            // Muestra módulo tablas
            lblModuloTablas.Visible = true;
            btnProductosLeft.Visible = true;
            btnClientesLeft.Visible = true;
            btnCategoriasLeft.Visible = true;
        }

        private void MostrarModuloFacturacion()
        {
            // Oculta módulo tablas
            lblModuloTablas.Visible = false;
            btnProductosLeft.Visible = false;
            btnClientesLeft.Visible = false;
            btnCategoriasLeft.Visible = false;
            // Muestra módulo facturación
            lblModuloFacturacion.Visible = true;
            btnFacturacionLeft.Visible = true;
            btnInformesLeft.Visible = true;
        }

        private void OcultarModulosLaterales()
        {
            lblModuloFacturacion.Visible = false;
            btnFacturacionLeft.Visible = false;
            btnInformesLeft.Visible = false;
            lblModuloTablas.Visible = false;
            btnProductosLeft.Visible = false;
            btnClientesLeft.Visible = false;
            btnCategoriasLeft.Visible = false;
        }

        // Mostrar mensaje de bienvenida en el panel central
        private void MostrarBienvenida(string mensaje)
        {
            panelContent.Controls.Clear();
            Label lblBienvenida = new Label();
            lblBienvenida.Text = mensaje;
            lblBienvenida.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            lblBienvenida.AutoSize = false;
            lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblBienvenida.Dock = DockStyle.Fill;
            panelContent.Controls.Add(lblBienvenida);
        }

        // Mostrar un UserControl en el panel central
        private void MostrarUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }
    }
}

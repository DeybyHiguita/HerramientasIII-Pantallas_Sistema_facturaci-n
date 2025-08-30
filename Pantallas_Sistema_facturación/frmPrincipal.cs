using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
//using Pantallas_Sistema_facturación.Forms.Ayuda.UserControls;
using Pantallas_Sistema_facturación.Forms.Seguridad.UserControls;
using Pantallas_Sistema_facturación.Forms.Facturacion.UserControls;
using Pantallas_Sistema_facturación.Forms.Tablas.UserControls;
using Pantallas_Sistema_facturación.UserControls;

namespace Pantallas_Sistema_facturación
{
    public partial class frmPrincipal : Form
    {
        private readonly MaterialSkinManager skinManager;

        public frmPrincipal()
        {
            InitializeComponent();
            InicializarApariencia();
            ConfigurarFormulario();
        }

        void InicializarApariencia()
        {
            MaterialSkinManager AdministradorApariencia = MaterialSkinManager.Instance;
            AdministradorApariencia.AddFormToManage(this);
            AdministradorApariencia.Theme = MaterialSkinManager.Themes.LIGHT;
            AdministradorApariencia.ColorScheme = new ColorScheme(
                Primary.Purple600,
                Primary.Purple700,
                Primary.Purple300,
                Accent.Purple200,
                TextShade.WHITE
            );
        }

        void ConfigurarFormulario()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            if (panelContent != null)
            {
                panelContent.AutoScroll = true;
                panelContent.AutoScrollMargin = new Size(20, 20);
                panelContent.Padding = new Padding(20);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            MostrarContenidoPrincipal();
        }

        // ---------- EVENTOS ----------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var ResultadoOpcion = MessageBox.Show(this,
                "¿Qué desea hacer?\n\n" +
                "• Sí: Cerrar sesión y volver al login\n" +
                "• No: Salir completamente del sistema\n" +
                "• Cancelar: Quedarse en el sistema",
                "Salir del sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            switch (ResultadoOpcion)
            {
                case DialogResult.Yes:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;

                case DialogResult.No:
                    this.DialogResult = DialogResult.Abort;
                    Application.Exit();
                    break;

                case DialogResult.Cancel:
                default:
                    break;
            }
        }

        private void menuPrincipal_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            HideSeguridadButtons();
            HideAyudaButtons();
            MostrarContenidoPrincipal();
        }

        private void menuTablas_Click(object sender, EventArgs e)
        {
            MostrarBotonesTabla();
            MostrarContenidoPrincipal();
        }

        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            MostrarContenidoFacturacion();
        }

        private void menuSeguridad_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            HideAyudaButtons();
            ShowSeguridadButtons();
            MostrarContenidoPrincipal();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            HideSeguridadButtons();
            ShowAyudaButtons();
        }

        // ---------- BOTONES LATERALES ----------
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

        private void btnInformesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucInforme());
        }

        private void btnEmpleadosLeft_Click(object sender, EventArgs e)
        {
            MostrarContenidoSeguridad();
        }

        private void btnRolesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucRol());
        }

        private void btnSeguridadLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucAdminSeguridad());
        }

        private void btnAyudaLeft_Click(object sender, EventArgs e)
        {
            MostrarContenidoAyuda();
        }

        // ---------- MÉTODOS AUXILIARES ----------
        private void MostrarContenidoPrincipal()
        {
            MostrarUserControl(new ucDashboard());
        }

        private void MostrarContenidoFacturacion()
        {
            panelContent.Controls.Clear();

            var lblTitulo = new MaterialLabel
            {
                Text = "Módulo de Facturación",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50
            };

            var lblSubtitulo = new MaterialLabel
            {
                Text = "Crear Facturas, Cotizaciones y Reportes",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Dock = DockStyle.Top,
                Height = 30
            };

            panelContent.Controls.Add(lblSubtitulo);
            panelContent.Controls.Add(lblTitulo);
        }

        private void MostrarContenidoSeguridad()
        {
            MostrarUserControl(new ucEmpleado());
        }

        private void MostrarContenidoAyuda()
        {
            //MostrarUserControl(new ucAyuda());
        }

        private void MostrarUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        // ---------- MOSTRAR/OCULTAR MÓDULOS ----------
        private void MostrarBotonesTabla()
        {
            MostrarModuloFacturacion();
            MostrarBienvenida("Bienvenido al módulo de Facturación");
        }

        private void MostrarModuloTablas()
        {
            lblModuloFacturacion.Visible = false;
            btnFacturacionLeft.Visible = false;
            btnInformesLeft.Visible = false;

            lblModuloTablas.Visible = true;
            btnProductosLeft.Visible = true;
            btnClientesLeft.Visible = true;
            btnCategoriasLeft.Visible = true;
        }

        private void MostrarModuloFacturacion()
        {
            lblModuloTablas.Visible = false;
            btnProductosLeft.Visible = false;
            btnClientesLeft.Visible = false;
            btnCategoriasLeft.Visible = false;

            lblModuloFacturacion.Visible = true;
            btnFacturacionLeft.Visible = true;
            btnInformesLeft.Visible = true;
        }

        private void OcultarBotonesTabla()
        {
            lblModuloFacturacion.Visible = false;
            btnFacturacionLeft.Visible = false;
            btnInformesLeft.Visible = false;
            lblModuloTablas.Visible = false;
            btnProductosLeft.Visible = false;
            btnClientesLeft.Visible = false;
            btnCategoriasLeft.Visible = false;
        }

        private void ShowSeguridadButtons()
        {
            lblModuloSeguridad.Visible = true;
            btnEmpleadosLeft.Visible = true;
            btnRolesLeft.Visible = true;
            btnSeguridadLeft.Visible = true;
        }

        private void HideSeguridadButtons()
        {
            lblModuloSeguridad.Visible = false;
            btnEmpleadosLeft.Visible = false;
            btnRolesLeft.Visible = false;
            btnSeguridadLeft.Visible = false;
        }

        private void ShowAyudaButtons()
        {
            lblModuloAyuda.Visible = true;
            btnAyudaLeft.Visible = true;
            btnAcercaDeLeft.Visible = true;
        }

        private void HideAyudaButtons()
        {
            lblModuloAyuda.Visible = false;
            btnAyudaLeft.Visible = false;
            btnAcercaDeLeft.Visible = false;
        }

        private void MostrarBienvenida(string mensaje)
        {
            panelContent.Controls.Clear();
            Label lblBienvenida = new Label();
            lblBienvenida.Text = mensaje;
            lblBienvenida.Font = new Font("Roboto", 20F, FontStyle.Bold);
            lblBienvenida.AutoSize = false;
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Dock = DockStyle.Fill;
            panelContent.Controls.Add(lblBienvenida);
        }
    }
}

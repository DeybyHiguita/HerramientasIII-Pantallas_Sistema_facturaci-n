using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Forms.Ayuda.UserControls;
using Pantallas_Sistema_facturación.Forms.Seguridad.UserControls;
using Pantallas_Sistema_facturación.Forms.Tablas.UserControls;
using Pantallas_Sistema_facturación.Forms.Facturacion.UserControls;
using Pantallas_Sistema_facturación.UserControls;
using System.Drawing;

namespace Pantallas_Sistema_facturación
{
    public partial class frmPrincipal : MaterialForm
    {
        private MaterialLabel lblModuloFacturacion;
        private MaterialButton btnFacturacionLeft;
        private MaterialButton btnInformesLeft;

        public frmPrincipal()
        {
            InitializeComponent();
            InicializarApariencia();
            ConfigurarFormulario();
        }

        void InicializarApariencia()
        {
            var AdministradorApariencia = MaterialSkinManager.Instance;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show(this,
                "¿Qué desea hacer?\n\n" +
                "• Sí: Cerrar sesión y volver al login\n" +
                "• No: Salir completamente del sistema\n" +
                "• Cancelar: Quedarse en el sistema",
                "Salir del Sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            switch (Resultado)
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
            OcultarBotonesSeguridad();
            OcultarBotonesAyuda();
            MostrarContenidoPrincipal();
        }

        private void menuTablas_Click(object sender, EventArgs e)
        {
            MostrarBotonesTabla();
            MostrarContenidoPrincipal();
        }

        private void btnProductosLeft_Click(object sender, EventArgs e)
        {
            MostrarProductos();
            OcultarBotonesTabla();
            OcultarBotonesSeguridad();
            OcultarBotonesAyuda();
            MostrarModuloTablas();
        }

        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            OcultarBotonesSeguridad();
            OcultarBotonesAyuda();
            MostrarModuloFacturacion();
        }

        private void menuSeguridad_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            OcultarBotonesAyuda();
            MostrarBotonesSeguridad();
            MostrarContenidoPrincipal();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            OcultarBotonesSeguridad();
            MostrarBotonesAyuda();
            MostrarContenidoPrincipal();
        }

        private void btnFacturacionLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucFacturacion());
        }

        private void btnInformesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucInforme());
        }

        private void btnClientesLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucCliente());
        }

        private void btnCategoriasLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucCategoriasProductos());
        }

        private void btnEmpleadosLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucEmpleado());
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
            MostrarUserControl(new ucAyuda());
        }

        private void btnAcercaDeLeft_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ucAcercaDe());
        }

        private void MostrarBotonesTabla()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = true;
            if (btnProductosLeft != null) btnProductosLeft.Visible = true;
            if (btnClientesLeft != null) btnClientesLeft.Visible = true;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = true;
        }

        private void MostrarBotonesSeguridad()
        {
            if (lblModuloSeguridad != null) lblModuloSeguridad.Visible = true;
            if (btnEmpleadosLeft != null) btnEmpleadosLeft.Visible = true;
            if (btnRolesLeft != null) btnRolesLeft.Visible = true;
            if (btnSeguridadLeft != null) btnSeguridadLeft.Visible = true;
        }

        private void MostrarBotonesAyuda()
        {
            if (lblModuloAyuda != null) lblModuloAyuda.Visible = true;
            if (btnAyudaLeft != null) btnAyudaLeft.Visible = true;
            if (btnAcercaDeLeft != null) btnAcercaDeLeft.Visible = true;
        }

        private void OcultarBotonesAyuda()
        {
            if (lblModuloAyuda != null) lblModuloAyuda.Visible = false;
            if (btnAyudaLeft != null) btnAyudaLeft.Visible = false;
            if (btnAcercaDeLeft != null) btnAcercaDeLeft.Visible = false;
        }

        private void OcultarBotonesTabla()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = false;
            if (btnProductosLeft != null) btnProductosLeft.Visible = false;
            if (btnClientesLeft != null) btnClientesLeft.Visible = false;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = false;
            if (lblModuloFacturacion != null) lblModuloFacturacion.Visible = false;
            if (btnFacturacionLeft != null) btnFacturacionLeft.Visible = false;
            if (btnInformesLeft != null) btnInformesLeft.Visible = false;
        }

        private void OcultarBotonesSeguridad()
        {
            if (lblModuloSeguridad != null) lblModuloSeguridad.Visible = false;
            if (btnEmpleadosLeft != null) btnEmpleadosLeft.Visible = false;
            if (btnRolesLeft != null) btnRolesLeft.Visible = false;
            if (btnSeguridadLeft != null) btnSeguridadLeft.Visible = false;
        }

        private void MostrarContenidoPrincipal()
        {
            MostrarUserControl(new ucDashboard());
        }

        private void MostrarUserControl(UserControl Control)
        {
            panelContent.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(Control);
        }

        private void MostrarModuloTablas()
        {
            OcultarBotonesTabla();
            if (lblModuloTablas != null) lblModuloTablas.Visible = true;
            if (btnProductosLeft != null) btnProductosLeft.Visible = true;
            if (btnClientesLeft != null) btnClientesLeft.Visible = true;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = true;
        }

        private void MostrarModuloFacturacion()
        {
            OcultarBotonesTabla();
            if (lblModuloFacturacion != null) lblModuloFacturacion.Visible = true;
            if (btnFacturacionLeft != null) btnFacturacionLeft.Visible = true;
            if (btnInformesLeft != null) btnInformesLeft.Visible = true;
        }

        private void MostrarProductos()
        {
            MostrarUserControl(new ucProducto());
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblModuloFacturacion_Click(object sender, EventArgs e)
        {

        }
    }
}

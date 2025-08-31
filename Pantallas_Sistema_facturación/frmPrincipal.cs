using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Forms.Ayuda.UserControls;
using Pantallas_Sistema_facturación.Forms.Seguridad.UserControls;
using Pantallas_Sistema_facturación.Forms.Tablas.UserControls;
using Pantallas_Sistema_facturación.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarApariencia();
            ConfigurarFormulario();
        }

        void InicializarApariencia()
        {
            var administrador = MaterialSkinManager.Instance;
            administrador.AddFormToManage(this);
            administrador.Theme = MaterialSkinManager.Themes.LIGHT;
            administrador.ColorScheme = new ColorScheme(
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

        // ---------------- EVENTOS ----------------
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            MostrarContenidoPrincipal();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(this,
                "¿Qué desea hacer?\n\n" +
                "• Sí: Cerrar sesión y volver al login\n" +
                "• No: Salir completamente del sistema\n" +
                "• Cancelar: Quedarse en el sistema",
                "Salir del sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            switch (resultado)
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

        private void btnProductosLeft_Click(object sender, EventArgs e)
        {
            MostrarProductos();
            OcultarBotonesTabla();
            HideSeguridadButtons();
            HideAyudaButtons();
            MostrarModuloTablas();
        }

        // Menú superior - Facturación
        private void menuFacturacion_Click(object sender, EventArgs e)
        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            HideSeguridadButtons();
            HideAyudaButtons();
            MostrarModuloFacturacion();
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
        private void MostrarBotonesTabla()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = true;
            if (btnProductosLeft != null) btnProductosLeft.Visible = true;
            if (btnClientesLeft != null) btnClientesLeft.Visible = true;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = true;
        }
            MostrarUserControl(new ucInforme());
        private void ShowSeguridadButtons()
        {
            if (lblModuloSeguridad != null) lblModuloSeguridad.Visible = true;
            if (btnEmpleadosLeft != null) btnEmpleadosLeft.Visible = true;
            if (btnRolesLeft != null) btnRolesLeft.Visible = true;
            if (btnSeguridadLeft != null) btnSeguridadLeft.Visible = true;
        }

        private void ShowAyudaButtons()
        {
            if (lblModuloAyuda != null) lblModuloAyuda.Visible = true;
            if (btnAyudaLeft != null) btnAyudaLeft.Visible = true;
            if (btnAcercaDeLeft != null) btnAcercaDeLeft.Visible = true;
        }

        private void HideAyudaButtons()
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
        }

        private void HideSeguridadButtons()
        {
            if (lblModuloSeguridad != null) lblModuloSeguridad.Visible = false;
            if (btnEmpleadosLeft != null) btnEmpleadosLeft.Visible = false;
            if (btnRolesLeft != null) btnRolesLeft.Visible = false;
            if (btnSeguridadLeft != null) btnSeguridadLeft.Visible = false;
        }


        private void MostrarContenidoPrincipal()

        private void MostrarContenidoPrincipal()
        {
            panelContent.Controls.Clear();
            var panel = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            control.Location = new Point(20, 20);
            control.Size = new Size(820, 540);
            panel.Controls.Add(control);
            panelContent.Controls.Add(panel);

            panelContent.Resize += (s, e) =>
            {
                if (panel != null && !panel.IsDisposed)
                    panel.Size = panelContent.ClientSize;
            };
        }

        private void MostrarUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void MostrarContenidoPrincipal() => MostrarUserControl(new ucDashboard());

        private void MostrarContenidoFacturacion()
        {
            panelContent.Controls.Clear();
            var panelFact = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                BackColor = Color.White,
                AutoScroll = true,
                Padding = new Padding(30),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var lblTitulo = new MaterialLabel
            {
                Text = "Módulo de Facturación",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Location = new Point(0, 20),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblSubtitulo = new MaterialLabel
            {
                Text = "Crear Facturas, Cotizaciones y Reportes",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Location = new Point(0, 70),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panelFact.Controls.Add(lblTitulo);
            panelFact.Controls.Add(lblSubtitulo);
            panelContent.Controls.Add(panelFact);

            panelContent.Resize += (s, e) =>
            {
                if (panelFact != null && !panelFact.IsDisposed)
                    panelFact.Size = panelContent.ClientSize;
            };
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
            OcultarBotonesTabla();
            lblModuloSeguridad.Visible = false;
            btnEmpleadosLeft.Visible = false;
            btnRolesLeft.Visible = false;

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

        private void MostrarModuloTablas()
        {
            OcultarBotonesTabla();
            lblModuloTablas.Visible = true;
            btnProductosLeft.Visible = true;
            btnClientesLeft.Visible = true;
            btnCategoriasLeft.Visible = true;
        }

        private void MostrarModuloFacturacion()
        {
            OcultarBotonesTabla();
            lblModuloFacturacion.Visible = true;
            btnFacturacionLeft.Visible = true;
            btnInformesLeft.Visible = true;
        }

        private void OcultarBotonesTabla()
        {
            lblModuloTablas.Visible = false;
            btnProductosLeft.Visible = false;
            btnClientesLeft.Visible = false;
            btnCategoriasLeft.Visible = false;
            lblModuloFacturacion.Visible = false;
            btnFacturacionLeft.Visible = false;
            btnInformesLeft.Visible = false;
        }

        private void MostrarBienvenida(string mensaje)
        {
            panelContent.Controls.Clear();
            Label lbl = new Label
            {
                Text = mensaje,
                Font = new Font("Roboto", 20F, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            panelContent.Controls.Add(lbl);
        }
            panelContent.Controls.Add(control);
        }
    }
}

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
            MaterialSkinManager AdministradorApariencia = MaterialSkinManager.Instance;
            AdministradorApariencia.AddFormToManage(this);
            AdministradorApariencia.Theme = MaterialSkinManager.Themes.LIGHT;
            AdministradorApariencia.ColorScheme = new ColorScheme(
                Primary.Purple600, // #A587C3 - Color principal
                Primary.Purple700, // #8E6BA8 - Color más oscuro para hover
                Primary.Purple300, // #C8A8D8 - Color más claro para accents
                Accent.Purple200,  // Acento morado claro
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
        }

        private void btnClientesLeft_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void btnCategoriasLeft_Click(object sender, EventArgs e)
        {
            MostrarCategorias();
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

        private void btnEmpleadosLeft_Click(object sender, EventArgs e)
        {
            //ShowEmpleados();
            MostrarContenidoSeguridad();
        }

        private void btnRolesLeft_Click(object sender, EventArgs e)
        {
            ShowRolesEmpleado();
        }

        private void btnSeguridadLeft_Click(object sender, EventArgs e)
        {
            ShowAdminSeguridad();
        }

        private void btnAyudaLeft_Click(object sender, EventArgs e)
        {
            MostrarContenidoAyuda();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            HideSeguridadButtons();
            ShowAyudaButtons();     
        }

        private void MostrarBotonesTabla()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = true;
            if (btnProductosLeft != null) btnProductosLeft.Visible = true;
            if (btnClientesLeft != null) btnClientesLeft.Visible = true;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = true;
        }

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
        {
            panelContent.Controls.Clear();
            var PanelPrincipal = new ucDashboard();

            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Size = panelContent.ClientSize;
            PanelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            panelContent.Controls.Add(PanelPrincipal);

            panelContent.Resize += (sender, e) => {
                if (PanelPrincipal != null && !PanelPrincipal.IsDisposed)
                {
                    PanelPrincipal.Size = panelContent.ClientSize;
                }
            };
        }

        private void MostrarProductos()
        {
            // Cargar el formulario de productos
            panelContent.Controls.Clear();

            // Crear un panel wrapper con scroll
            var PanelContenedorProductos = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ControlProductos = new ucProducto();
            ControlProductos.Location = new Point(20, 20);
            ControlProductos.Size = new Size(820, 540);
            PanelContenedorProductos.Controls.Add(ControlProductos);

            panelContent.Controls.Add(PanelContenedorProductos);

            panelContent.Resize += (sender, e) => {
                if (PanelContenedorProductos != null && !PanelContenedorProductos.IsDisposed)
                {
                    PanelContenedorProductos.Size = panelContent.ClientSize;
                }
            };
        }

        private void MostrarCliente()
        {
            panelContent.Controls.Clear();

            var PanelContenedorClientes = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ControlClientes = new ucCliente();
            ControlClientes.Location = new Point(20, 20);
            ControlClientes.Size = new Size(820, 540);
            PanelContenedorClientes.Controls.Add(ControlClientes);
            panelContent.Controls.Add(PanelContenedorClientes);

            panelContent.Resize += (sender, e) => {
                if (PanelContenedorClientes != null && !PanelContenedorClientes.IsDisposed)
                {
                    PanelContenedorClientes.Size = panelContent.ClientSize;
                }
            };
        }

        private void MostrarCategorias()
        {
            panelContent.Controls.Clear();

            var PanelContenedorCategorias = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ControlCategorias = new ucCategoriasProductos();
            ControlCategorias.Location = new Point(20, 20);
            ControlCategorias.Size = new Size(820, 540);
            PanelContenedorCategorias.Controls.Add(ControlCategorias);
            panelContent.Controls.Add(PanelContenedorCategorias);

            panelContent.Resize += (sender, e) => {
                if (PanelContenedorCategorias != null && !PanelContenedorCategorias.IsDisposed)
                {
                    PanelContenedorCategorias.Size = panelContent.ClientSize;
                }
            };
        }

        private void MostrarContenidoFacturacion()
        {
            panelContent.Controls.Clear();

            var PanelFacturacion = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                BackColor = Color.White,
                AutoScroll = true,
                Padding = new Padding(30),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var EtiquetaFacturacion = new MaterialLabel
            {
                Text = "Módulo de Facturación",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Location = new Point(0, 20),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var EtiquetaSubtitulo = new MaterialLabel
            {
                Text = "Crear Facturas, Cotizaciones y Reportes",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Location = new Point(0, 70),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };

            PanelFacturacion.Controls.Add(EtiquetaFacturacion);
            PanelFacturacion.Controls.Add(EtiquetaSubtitulo);

            panelContent.Controls.Add(PanelFacturacion);

            panelContent.Resize += (sender, e) => {
                if (PanelFacturacion != null && !PanelFacturacion.IsDisposed)
                {
                    PanelFacturacion.Size = panelContent.ClientSize;
                }
            };
        }

        private void MostrarContenidoSeguridad()
        {
            panelContent.Controls.Clear();

            var PanelSeguridad = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ucEmpleados = new ucEmpleado
            {
                Location = new Point(20, 20),
                Size = new Size(820, 540)
            };

            PanelSeguridad.Controls.Add(ucEmpleados);
            panelContent.Controls.Add(PanelSeguridad);

            panelContent.Resize += (sender, e) =>
            {
                if (PanelSeguridad != null && !PanelSeguridad.IsDisposed)
                {
                    PanelSeguridad.Size = panelContent.ClientSize;
                }
            };
        }

        private void ShowRolesEmpleado()
        {
            // Cargar el formulario de productos
            panelContent.Controls.Clear();

            // Crear un panel wrapper con scroll
            var scrollPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ucRoles = new ucRol();
            ucRoles.Location = new Point(20, 20);
            ucRoles.Size = new Size(820, 540);
            scrollPanel.Controls.Add(ucRoles);

            panelContent.Controls.Add(scrollPanel);

            panelContent.Resize += (sender, e) => {
                if (scrollPanel != null && !scrollPanel.IsDisposed)
                {
                    scrollPanel.Size = panelContent.ClientSize;
                }
            };

        }

        private void ShowAdminSeguridad()
        {
            panelContent.Controls.Clear();

            var PanelSeguridad = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ucAdminsSeguridad = new ucAdminSeguridad
            {
                Location = new Point(20, 20),
                Size = new Size(820, 540)
            };

            PanelSeguridad.Controls.Add(ucAdminsSeguridad);
            panelContent.Controls.Add(PanelSeguridad);

            panelContent.Resize += (sender, e) =>
            {
                if (PanelSeguridad != null && !PanelSeguridad.IsDisposed)
                {
                    PanelSeguridad.Size = panelContent.ClientSize;
                }
            };
        }
        private void MostrarContenidoAyuda()
        {
            panelContent.Controls.Clear();

            var PanelAyuda = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var ucAyudas = new ucAyuda
            {
                Location = new Point(20, 20),
                Size = new Size(820, 540)
            };

            PanelAyuda.Controls.Add(ucAyudas);
            panelContent.Controls.Add(PanelAyuda);

            panelContent.Resize += (sender, e) =>
            {
                if (PanelAyuda != null && !PanelAyuda.IsDisposed)
                {
                    PanelAyuda.Size = panelContent.ClientSize;
                }
            };
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OcultarBotonesTabla();
            MostrarContenidoPrincipal();
        }
    }
}
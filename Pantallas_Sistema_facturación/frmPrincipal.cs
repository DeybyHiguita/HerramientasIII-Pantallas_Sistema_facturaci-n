using MaterialSkin;
using MaterialSkin.Controls;
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
            InitializeSkin();
            ConfigureForm();
        }
        
        void InitializeSkin()
        {
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Paleta de morados elegante
            manager.ColorScheme = new ColorScheme(
                Primary.Purple600, // #A587C3 - Color principal
                Primary.Purple700, // #8E6BA8 - Color más oscuro para hover
                Primary.Purple300, // #C8A8D8 - Color más claro para accents
                Accent.Purple200,  // Acento morado claro
                TextShade.WHITE
            );
        }
        
        void ConfigureForm()
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
            var result = MessageBox.Show(this,
                "¿Qué desea hacer?\n\n" +
                "• Sí: Cerrar sesión y volver al login\n" +
                "• No: Salir completamente del sistema\n" +
                "• Cancelar: Quedarse en el sistema",
                "Salir del sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
                
            switch (result)
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
            HideTablaButtons();
            ShowMainContent();
        }
        
        private void menuTablas_Click(object sender, EventArgs e)
        {
            ShowTablaButtons();
            ShowMainContent();
        }

        private void btnProductosLeft_Click(object sender, EventArgs e)
        {
            ShowProductos();
        }

        private void btnClientesLeft_Click(object sender, EventArgs e)
        {
            ShowCliente();
        }

        private void btnCategoriasLeft_Click(object sender, EventArgs e)
        {
            ShowCategorias();
        }
        
        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            HideTablaButtons();
            ShowFacturacionContent();
        }
        
        private void menuSeguridad_Click(object sender, EventArgs e)
        {
            HideTablaButtons();
            ShowSeguridadContent();
        }
        
        private void menuAyuda_Click(object sender, EventArgs e)
        {
            HideTablaButtons();
            ShowCliente();
        }
        
        private void ShowTablaButtons()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = true;
            if (btnProductosLeft != null) btnProductosLeft.Visible = true;
            if (btnClientesLeft != null) btnClientesLeft.Visible = true;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = true;
        }
        
        private void HideTablaButtons()
        {
            if (lblModuloTablas != null) lblModuloTablas.Visible = false;
            if (btnProductosLeft != null) btnProductosLeft.Visible = false;
            if (btnClientesLeft != null) btnClientesLeft.Visible = false;
            if (btnCategoriasLeft != null) btnCategoriasLeft.Visible = false;
        }
        
        private void ShowMainContent()
        {
            panelContent.Controls.Clear();
            var dashboard = new ucDashboard();
            
            dashboard.Location = new Point(0, 0);
            dashboard.Size = panelContent.ClientSize;
            dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            
            panelContent.Controls.Add(dashboard);
            
            panelContent.Resize += (sender, e) => {
                if (dashboard != null && !dashboard.IsDisposed)
                {
                    dashboard.Size = panelContent.ClientSize;
                }
            };
        }
        
        private void ShowProductos()
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
            
            var ucProductos = new ucProducto();
            ucProductos.Location = new Point(20, 20);
            ucProductos.Size = new Size(820, 540);
            scrollPanel.Controls.Add(ucProductos);
            
            panelContent.Controls.Add(scrollPanel);
            
            panelContent.Resize += (sender, e) => {
                if (scrollPanel != null && !scrollPanel.IsDisposed)
                {
                    scrollPanel.Size = panelContent.ClientSize;
                }
            };
        }

        private void ShowCliente()
        {
            panelContent.Controls.Clear();
            
            var scrollPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            
            var ucClientes = new ucCliente();
            ucClientes.Location = new Point(20, 20);
            ucClientes.Size = new Size(820, 540);
            scrollPanel.Controls.Add(ucClientes);
            panelContent.Controls.Add(scrollPanel);

            panelContent.Resize += (sender, e) => {
                if (scrollPanel != null && !scrollPanel.IsDisposed)
                {
                    scrollPanel.Size = panelContent.ClientSize;
                }
            };
        }
        
        private void ShowCategorias()
        {
            panelContent.Controls.Clear();

            var scrollPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                AutoScroll = true,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var uc = new ucCategoriasProductos();
            uc.Location = new Point(20, 20);
            uc.Size = new Size(820, 540);
            scrollPanel.Controls.Add(uc);
            panelContent.Controls.Add(scrollPanel);

            panelContent.Resize += (sender, e) => {
                if (scrollPanel != null && !scrollPanel.IsDisposed)
                {
                    scrollPanel.Size = panelContent.ClientSize;
                }
            };
        }
        
        private void ShowFacturacionContent()
        {
            panelContent.Controls.Clear();
            
            var panelFacturacion = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                BackColor = Color.White,
                AutoScroll = true,
                Padding = new Padding(30),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            
            var lblFacturacion = new MaterialLabel
            {
                Text = "Módulo de Facturación",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Location = new Point(0, 20),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleLeft
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Crear Facturas, Cotizaciones y Reportes",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Location = new Point(0, 70),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };
            
            panelFacturacion.Controls.Add(lblFacturacion);
            panelFacturacion.Controls.Add(lblSubtitle);
            
            panelContent.Controls.Add(panelFacturacion);
            
            panelContent.Resize += (sender, e) => {
                if (panelFacturacion != null && !panelFacturacion.IsDisposed)
                {
                    panelFacturacion.Size = panelContent.ClientSize;
                }
            };
        }
        
        private void ShowSeguridadContent()
        {
            panelContent.Controls.Clear();
            
            var panelSeguridad = new Panel
            {
                Location = new Point(0, 0),
                Size = panelContent.ClientSize,
                BackColor = Color.White,
                AutoScroll = true,
                Padding = new Padding(30),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            
            var lblSeguridad = new MaterialLabel
            {
                Text = "Módulo de Seguridad",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Location = new Point(0, 20),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleLeft
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Gestión de Usuarios y Permisos",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Location = new Point(0, 70),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };
            
            panelSeguridad.Controls.Add(lblSeguridad);
            panelSeguridad.Controls.Add(lblSubtitle);
            
            panelContent.Controls.Add(panelSeguridad);
            
            // Suscribirse al evento de redimensionamiento del panel
            panelContent.Resize += (sender, e) => {
                if (panelSeguridad != null && !panelSeguridad.IsDisposed)
                {
                    panelSeguridad.Size = panelContent.ClientSize;
                }
            };
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar logo
            LoadLogo();
            
            // Ocultar botones de tablas por defecto
            HideTablaButtons();
            
            // Mostrar contenido principal por defecto
            ShowMainContent();
        }
        
        private void LoadLogo()
        {
            try
            {
                Bitmap logo = new Bitmap(160, 120);
                using (Graphics g = Graphics.FromImage(logo))
                {
                    // Fondo morado principal
                    g.Clear(Color.FromArgb(165, 135, 195)); // #A587C3
                    
                    // Dibujar un rectángulo blanco para simular el logo
                    using (Brush whiteBrush = new SolidBrush(Color.White))
                    {
                        g.FillRectangle(whiteBrush, 20, 20, 120, 80);
                    }
                    
                    // Agregar texto del sistema en morado
                    using (Font logoFont = new Font("Segoe UI", 10, FontStyle.Bold))
                    using (Brush textBrush = new SolidBrush(Color.FromArgb(165, 135, 195)))
                    {
                        string logoText = "PANTALLAS\nSISTEMA\nFACTURACIÓN";
                        var textRect = new RectangleF(25, 25, 110, 70);
                        var stringFormat = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString(logoText, logoFont, textBrush, textRect, stringFormat);
                    }
                }
                if (pictureBoxLogo != null)
                {
                    pictureBoxLogo.Image = logo;
                }
            }
            catch (Exception ex)
            {
                if (pictureBoxLogo != null)
                {
                    pictureBoxLogo.BackColor = Color.FromArgb(165, 135, 195);
                }
            }
        }
    }
}

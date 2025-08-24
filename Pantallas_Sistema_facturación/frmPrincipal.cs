using MaterialSkin;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Forms.Clientes.UserControls;
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
                    // Volver al login - cerrar con DialogResult.Cancel para que Program.cs vuelva al login
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
                    
                case DialogResult.No:
                    // Salir completamente de la aplicación
                    this.DialogResult = DialogResult.Abort; // Usamos Abort para indicar salida completa
                    Application.Exit();
                    break;
                    
                case DialogResult.Cancel:
                default:
                    // No hacer nada (quedarse en el formulario)
                    break;
            }
        }


        
        // Métodos para manejar la navegación de menús
        private void menuPrincipal_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar página principal
            ShowMainContent();
        }
        
        private void menuTablas_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar página de tablas
            ShowTablasContent();
        }
        
        private void menuFacturacion_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar página de facturación
            ShowFacturacionContent();
        }
        
        private void menuSeguridad_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar página de seguridad
            ShowSeguridadContent();
        }
        
        private void menuAyuda_Click(object sender, EventArgs e)
        {
            ShowCliente();
        }
        
        private void ShowMainContent()
        {
            // Cargar el dashboard principal
            panelContent.Controls.Clear();
            var dashboard = new ucDashboard();
            panelContent.Controls.Add(dashboard);
        }
        
        private void ShowTablasContent()
        {
            panelContent.Controls.Clear();
            var lblTablas = new MaterialLabel
            {
                Text = "Módulo de Tablas",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 60
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Gestión de Clientes, Productos y Categorías",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };
            
            panelContent.Controls.Add(lblSubtitle);
            panelContent.Controls.Add(lblTablas);
        }
        
        private void ShowFacturacionContent()
        {
            panelContent.Controls.Clear();
            var lblFacturacion = new MaterialLabel
            {
                Text = "Módulo de Facturación",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 60
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Crear Facturas, Cotizaciones y Reportes",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };
            
            panelContent.Controls.Add(lblSubtitle);
            panelContent.Controls.Add(lblFacturacion);
        }
        
        private void ShowSeguridadContent()
        {
            panelContent.Controls.Clear();
            var lblSeguridad = new MaterialLabel
            {
                Text = "Módulo de Seguridad",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 60
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Gestión de Usuarios y Permisos",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };
            
            panelContent.Controls.Add(lblSubtitle);
            panelContent.Controls.Add(lblSeguridad);
        }
        
        private void ShowAyudaContent()
        {
            panelContent.Controls.Clear();
            var lblAyuda = new MaterialLabel
            {
                Text = "Módulo de Ayuda",
                Font = new Font("Roboto", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 60
            };
            
            var lblSubtitle = new MaterialLabel
            {
                Text = "Documentación y Soporte Técnico",
                Font = new Font("Roboto", 14, FontStyle.Regular),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };
            
            panelContent.Controls.Add(lblSubtitle);
            panelContent.Controls.Add(lblAyuda);
        }

        private void ShowCliente()
        {
            // Cargar el dashboard principal
            panelContent.Controls.Clear();
            var uc = new ucCliente();
            panelContent.Controls.Add(uc);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar logo
            LoadLogo();
            
            // Mostrar contenido principal por defecto
            ShowMainContent();
        }
        
        private void LoadLogo()
        {
            try
            {
                // Crear un logo simple programáticamente con paleta morada
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
                pictureBoxLogo.Image = logo;
            }
            catch (Exception ex)
            {
                // Si hay error, mantener el fondo del color del sistema
                pictureBoxLogo.BackColor = Color.FromArgb(165, 135, 195);
            }
        }
    }
}

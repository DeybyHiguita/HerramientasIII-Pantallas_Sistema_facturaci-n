using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq;

namespace Pantallas_Sistema_facturación
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            InicializarApariencia();
            ConfigurarEventos();
            ConfigurarPantallaCompleta();
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

        void ConfigurarPantallaCompleta()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            
            Rectangle LimitesPantalla = Screen.PrimaryScreen.Bounds;
            this.Size = new Size(LimitesPantalla.Width, LimitesPantalla.Height);
            this.Location = new Point(0, 0);
        }

        void ConfigurarEventos()
        {
            this.btnValidar.Click += btnValidar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
            this.chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            
            this.txtUser.KeyPress += (remitente, evento) => { if (evento.KeyChar == '\r') txtPass.Focus(); };
            this.txtPass.KeyPress += (remitente, evento) => { if (evento.KeyChar == '\r') btnValidar.PerformClick(); };
            
            this.KeyPreview = true;
            this.KeyDown += FormularioLogin_KeyDown;
            this.Load += FormularioLogin_Load;
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            
            this.Opacity = 0;
            Timer TemporizadorTransparencia = new Timer { Interval = 15 };
            TemporizadorTransparencia.Tick += (remitente, argumentos) =>
            {
                this.Opacity += 0.03;
                if (this.Opacity >= 1.0)
                {
                    this.Opacity = 1.0;
                    TemporizadorTransparencia.Stop();
                    TemporizadorTransparencia.Dispose();
                }
            };
            TemporizadorTransparencia.Start();
        }

        private void FormularioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancelar.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
            {
                AlternarPantallaCompleta();
            }
        }

        private void AlternarPantallaCompleta()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        void btnValidar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool CamposValidos = true;
            
            if (string.IsNullOrWhiteSpace(txtUser.Text)) 
            { 
                errorProvider1.SetError(txtUser, "El usuario es requerido"); 
                CamposValidos = false; 
            }
            
            if (string.IsNullOrWhiteSpace(txtPass.Text)) 
            { 
                errorProvider1.SetError(txtPass, "La contraseña es requerida"); 
                CamposValidos = false; 
            }
            
            if (!CamposValidos) 
            {
                MostrarMensaje("Por favor complete todos los campos requeridos", "Validación", MessageBoxIcon.Warning);
                return;
            }

            btnValidar.Enabled = false;
            btnValidar.Text = "Validando...";
            
            Timer TemporizadorProgreso = new Timer { Interval = 100 }; 
            int ProgresoValidacion = 0;
            TemporizadorProgreso.Tick += (remitente, argumentos) =>
            {
                ProgresoValidacion++;
                btnValidar.Text = "Validando" + new string('.', ProgresoValidacion % 4);
                
                if (ProgresoValidacion >= 10)
                {
                    TemporizadorProgreso.Stop();
                    TemporizadorProgreso.Dispose();
                    
                    btnValidar.Enabled = true;
                    btnValidar.Text = "INICIAR SESIÓN";

                    Negocio.NegocioLoginSeguridad negocio = new Negocio.NegocioLoginSeguridad(txtUser.Text.Trim(), txtPass.Text.Trim());
                    var resultado = negocio.Ejecutar();

                    if (resultado != null && resultado.Any())
                    {
                        DialogResult = DialogResult.OK;

                        Timer TemporizadorSalida = new Timer { Interval = 15 };
                        TemporizadorSalida.Tick += (remitente2, argumentos2) =>
                        {
                            this.Opacity -= 0.05;
                            if (this.Opacity <= 0)
                            {
                                TemporizadorSalida.Stop();
                                TemporizadorSalida.Dispose();
                                Close();
                            }
                        };
                        TemporizadorSalida.Start();
                    }
                    else
                    {
                        MostrarMensajeError();
                        txtPass.Clear();
                        txtUser.Focus();
                        AnimarPanelSacudida(panelRight);
                    }

                }
            };
            TemporizadorProgreso.Start();
        }

        private void MostrarMensajeError()
        {
            MessageBox.Show(this, 
                "Usuario o contraseña incorrectos.\n\nPor favor, verifique sus credenciales e intente nuevamente.", 
                "Error de autenticación", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        private void AnimarPanelSacudida(Panel PanelASacudir)
        {
            int PosicionOriginalX = PanelASacudir.Location.X;
            Timer TemporizadorSacudida = new Timer { Interval = 50 };
            int ContadorSacudidas = 0;
            
            TemporizadorSacudida.Tick += (remitente, argumentos) =>
            {
                if (ContadorSacudidas % 2 == 0)
                    PanelASacudir.Location = new Point(PosicionOriginalX + 5, PanelASacudir.Location.Y);
                else
                    PanelASacudir.Location = new Point(PosicionOriginalX - 5, PanelASacudir.Location.Y);
                
                ContadorSacudidas++;
                if (ContadorSacudidas >= 8)
                {
                    PanelASacudir.Location = new Point(PosicionOriginalX, PanelASacudir.Location.Y);
                    TemporizadorSacudida.Stop();
                    TemporizadorSacudida.Dispose();
                }
            };
            TemporizadorSacudida.Start();
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            var ResultadoConfirmacion = MessageBox.Show(this,
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (ResultadoConfirmacion == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
        }

        void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private DialogResult MostrarMensaje(string MensajeTexto, string TituloVentana, MessageBoxIcon IconoMensaje, MessageBoxButtons BotonesMensaje = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, MensajeTexto, TituloVentana, BotonesMensaje, IconoMensaje);
        }
    }
}

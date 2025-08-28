using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            InitializeSkin();
            ConfigureEvents();
            ConfigureFullScreen();
        }

        void InitializeSkin()
        {
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(
                Primary.Purple600, // #A587C3 - Color principal
                Primary.Purple700, // #8E6BA8 - Color más oscuro para hover
                Primary.Purple300, // #C8A8D8 - Color más claro para accents
                Accent.Purple200,  // Acento morado claro
                TextShade.WHITE
            );
        }

        void ConfigureFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            this.Size = new Size(screenBounds.Width, screenBounds.Height);
            this.Location = new Point(0, 0);
        }

        void ConfigureEvents()
        {
            this.btnValidar.Click += btnValidar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
            this.chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            
            this.txtUser.KeyPress += (s, e) => { if (e.KeyChar == '\r') txtPass.Focus(); };
            this.txtPass.KeyPress += (s, e) => { if (e.KeyChar == '\r') btnValidar.PerformClick(); };
            
            this.KeyPreview = true;
            this.KeyDown += FrmLogin_KeyDown;
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            
            this.Opacity = 0;
            Timer timer = new Timer { Interval = 15 };
            timer.Tick += (s, args) =>
            {
                this.Opacity += 0.03;
                if (this.Opacity >= 1.0)
                {
                    this.Opacity = 1.0;
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancelar.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
            {
                ToggleFullScreen();
            }
        }

        private void ToggleFullScreen()
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
            bool ok = true;
            
            if (string.IsNullOrWhiteSpace(txtUser.Text)) 
            { 
                errorProvider1.SetError(txtUser, "El usuario es requerido"); 
                ok = false; 
            }
            
            if (string.IsNullOrWhiteSpace(txtPass.Text)) 
            { 
                errorProvider1.SetError(txtPass, "La contraseña es requerida"); 
                ok = false; 
            }
            
            if (!ok) 
            {
                ShowMessage("Por favor complete todos los campos requeridos", "Validación", MessageBoxIcon.Warning);
                return;
            }

            btnValidar.Enabled = false;
            btnValidar.Text = "Validando...";
            
            Timer progressTimer = new Timer { Interval = 100 }; 
            int progress = 0;
            progressTimer.Tick += (s, args) =>
            {
                progress++;
                btnValidar.Text = "Validando" + new string('.', progress % 4);
                
                if (progress >= 10)
                {
                    progressTimer.Stop();
                    progressTimer.Dispose();
                    
                    btnValidar.Enabled = true;
                    btnValidar.Text = "INICIAR SESIÓN";
                    
                    if (txtUser.Text.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase) && txtPass.Text == "admin")
                    {
                        DialogResult = DialogResult.OK;
                        
                        Timer exitTimer = new Timer { Interval = 15 };
                        exitTimer.Tick += (s2, args2) =>
                        {
                            this.Opacity -= 0.05;
                            if (this.Opacity <= 0)
                            {
                                exitTimer.Stop();
                                exitTimer.Dispose();
                                Close();
                            }
                        };
                        exitTimer.Start();
                    }
                    else
                    {
                        ShowErrorMessage();
                        txtPass.Clear();
                        txtUser.Focus();
                        ShakePanel(panelRight);
                    }
                }
            };
            progressTimer.Start();
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show(this, 
                "Usuario o contraseña incorrectos.\n\nPor favor, verifique sus credenciales e intente nuevamente.", 
                "Error de autenticación", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        private void ShakePanel(Panel panel)
        {
            int originalX = panel.Location.X;
            Timer shakeTimer = new Timer { Interval = 50 };
            int shakeCount = 0;
            
            shakeTimer.Tick += (s, args) =>
            {
                if (shakeCount % 2 == 0)
                    panel.Location = new Point(originalX + 5, panel.Location.Y);
                else
                    panel.Location = new Point(originalX - 5, panel.Location.Y);
                
                shakeCount++;
                if (shakeCount >= 8)
                {
                    panel.Location = new Point(originalX, panel.Location.Y);
                    shakeTimer.Stop();
                    shakeTimer.Dispose();
                }
            };
            shakeTimer.Start();
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this,
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
        }

        void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private DialogResult ShowMessage(string message, string title, MessageBoxIcon icon, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, message, title, buttons, icon);
        }

        private Image CreateDefaultLoginImage()
        {
            Bitmap defaultImage = new Bitmap(400, 300);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                // Fondo morado principal en lugar de azul
                g.Clear(Color.FromArgb(165, 135, 195)); // #A587C3
                
                using (Brush brush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(brush, 150, 100, 100, 80);
                    g.FillRectangle(brush, 180, 180, 40, 20);
                    g.FillRectangle(brush, 170, 200, 60, 10);
                }
                
                using (Font font = new Font("Arial", 16, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    string text = "Sistema de\nFacturación";
                    SizeF textSize = g.MeasureString(text, font);
                    g.DrawString(text, font, textBrush, 
                        (defaultImage.Width - textSize.Width) / 2, 
                        defaultImage.Height - 80);
                }
            }
            return defaultImage;
        }
    }
}

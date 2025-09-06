using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    partial class frmLogin
    {
        System.ComponentModel.IContainer components = null;
        internal Panel panelLeft;
        internal Panel panelRight;
        MaterialLabel lblTitle;
        MaterialLabel lblSubtitle;
        MaterialLabel lblUser;
        MaterialLabel lblPass;
        internal MaterialTextBox2 txtUser;
        internal MaterialTextBox2 txtPass;
        MaterialButton btnValidar;
        MaterialButton btnCancelar;
        MaterialCheckbox chkMostrar;
        ErrorProvider errorProvider1;
        private ucFooter footerControl;
        private PictureBox pictureBox1;
        private Splitter splitterMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitterMain = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnValidar = new MaterialSkin.Controls.MaterialButton();
            this.chkMostrar = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPass = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblSubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.footerControl = new Pantallas_Sistema_facturación.ucFooter();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(650, 600);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitterMain
            // 
            this.splitterMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.splitterMain.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitterMain.Location = new System.Drawing.Point(653, 64);
            this.splitterMain.MinExtra = 300;
            this.splitterMain.MinSize = 400;
            this.splitterMain.Name = "splitterMain";
            this.splitterMain.Size = new System.Drawing.Size(6, 600);
            this.splitterMain.TabIndex = 10;
            this.splitterMain.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnCancelar);
            this.panelRight.Controls.Add(this.btnValidar);
            this.panelRight.Controls.Add(this.chkMostrar);
            this.panelRight.Controls.Add(this.txtPass);
            this.panelRight.Controls.Add(this.lblPass);
            this.panelRight.Controls.Add(this.txtUser);
            this.panelRight.Controls.Add(this.lblUser);
            this.panelRight.Controls.Add(this.lblSubtitle);
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(659, 64);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(50);
            this.panelRight.Size = new System.Drawing.Size(638, 600);
            this.panelRight.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(273, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCancelar.UseAccentColor = false;
            // 
            // btnValidar
            // 
            this.btnValidar.AutoSize = false;
            this.btnValidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidar.BackColor = System.Drawing.Color.White;
            this.btnValidar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnValidar.Depth = 0;
            this.btnValidar.HighEmphasis = true;
            this.btnValidar.Icon = null;
            this.btnValidar.Location = new System.Drawing.Point(53, 399);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnValidar.Size = new System.Drawing.Size(200, 45);
            this.btnValidar.TabIndex = 8;
            this.btnValidar.Text = "INICIAR SESIÓN";
            this.btnValidar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnValidar.UseAccentColor = false;
            this.btnValidar.UseVisualStyleBackColor = false;
            // 
            // chkMostrar
            // 
            this.chkMostrar.Depth = 0;
            this.chkMostrar.Location = new System.Drawing.Point(53, 339);
            this.chkMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.chkMostrar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.ReadOnly = false;
            this.chkMostrar.Ripple = true;
            this.chkMostrar.Size = new System.Drawing.Size(200, 37);
            this.chkMostrar.TabIndex = 7;
            this.chkMostrar.Text = "Mostrar contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.HideSelection = true;
            this.txtPass.Hint = "Ingrese su contraseña";
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(53, 269);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PrefixSuffixText = null;
            this.txtPass.ReadOnly = false;
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(538, 48);
            this.txtPass.TabIndex = 6;
            this.txtPass.TabStop = false;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.Depth = 0;
            this.lblPass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPass.Location = new System.Drawing.Point(53, 239);
            this.lblPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HideSelection = true;
            this.txtUser.Hint = "Ingrese su nombre de usuario";
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(53, 169);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(538, 48);
            this.txtUser.TabIndex = 4;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // lblUser
            // 
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(53, 139);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.Depth = 0;
            this.lblSubtitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(53, 79);
            this.lblSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(538, 30);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Sistema de Facturación - Ingrese sus credenciales";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitle.Location = new System.Drawing.Point(53, 19);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(538, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BIENVENIDO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // footerControl
            // 
            this.footerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.footerControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.footerControl.Location = new System.Drawing.Point(3, 664);
            this.footerControl.Name = "footerControl";
            this.footerControl.Size = new System.Drawing.Size(1294, 100);
            this.footerControl.TabIndex = 11;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnValidar;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1300, 767);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitterMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.footerControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación - Iniciar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularioLogin_KeyDown);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelContent;

        private MaterialLabel lblSistemaFacturacion;
        private MaterialButton btnPrincipal;
        private MaterialButton btnTablas;
        private MaterialButton btnFacturacion;
        private MaterialButton btnSeguridad;
        private MaterialButton materialButton1; // Ayuda

        // Módulo de Tablas
        private MaterialLabel lblModuloTablas;
        private MaterialButton btnProductosLeft;
        private MaterialButton btnClientesLeft;
        private MaterialButton btnCategoriasLeft;

        // Módulo de Facturación
        private MaterialLabel lblModuloFacturacion;
        private MaterialButton btnFacturacionLeft;
        private MaterialButton btnInformesLeft;

        private PictureBox pictureBoxLogo;
        private MaterialButton btnSalir;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelTop = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnSeguridad = new MaterialSkin.Controls.MaterialButton();
            this.btnFacturacion = new MaterialSkin.Controls.MaterialButton();
            this.btnTablas = new MaterialSkin.Controls.MaterialButton();
            this.btnPrincipal = new MaterialSkin.Controls.MaterialButton();
            this.lblSistemaFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.panelLeft = new System.Windows.Forms.Panel();

            // Tablas
            this.lblModuloTablas = new MaterialSkin.Controls.MaterialLabel();
            this.btnProductosLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnClientesLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnCategoriasLeft = new MaterialSkin.Controls.MaterialButton();

            // Facturación
            this.lblModuloFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.btnFacturacionLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnInformesLeft = new MaterialSkin.Controls.MaterialButton();

            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.FromArgb(165, 135, 195);
            this.panelTop.Controls.Add(this.materialButton1);
            this.panelTop.Controls.Add(this.btnSeguridad);
            this.panelTop.Controls.Add(this.btnFacturacion);
            this.panelTop.Controls.Add(this.btnTablas);
            this.panelTop.Controls.Add(this.btnPrincipal);
            this.panelTop.Controls.Add(this.lblSistemaFacturacion);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(3, 64);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(1294, 60);
            this.panelTop.TabIndex = 0;
            // 
            // materialButton1 (Ayuda)
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new Point(1171, 15);
            this.materialButton1.Margin = new Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = Color.Empty;
            this.materialButton1.Size = new Size(100, 30);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Ayuda";
            this.materialButton1.Type = MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;

            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AutoSize = false;
            this.btnSeguridad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnSeguridad.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnSeguridad.Depth = 0;
            this.btnSeguridad.HighEmphasis = false;
            this.btnSeguridad.Icon = null;
            this.btnSeguridad.Location = new Point(600, 15);
            this.btnSeguridad.Margin = new Padding(4, 6, 4, 6);
            this.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.NoAccentTextColor = Color.Empty;
            this.btnSeguridad.Size = new Size(100, 30);
            this.btnSeguridad.TabIndex = 4;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.Type = MaterialButton.MaterialButtonType.Text;
            this.btnSeguridad.UseAccentColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.menuSeguridad_Click);

            // 
            // btnFacturacion
            // 
            this.btnFacturacion.AutoSize = false;
            this.btnFacturacion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnFacturacion.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnFacturacion.Depth = 0;
            this.btnFacturacion.HighEmphasis = false;
            this.btnFacturacion.Icon = null;
            this.btnFacturacion.Location = new Point(470, 15);
            this.btnFacturacion.Margin = new Padding(4, 6, 4, 6);
            this.btnFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.NoAccentTextColor = Color.Empty;
            this.btnFacturacion.Size = new Size(120, 30);
            this.btnFacturacion.TabIndex = 3;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.Type = MaterialButton.MaterialButtonType.Text;
            this.btnFacturacion.UseAccentColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.menuFacturacion_Click);

            // 
            // btnTablas
            // 
            this.btnTablas.AutoSize = false;
            this.btnTablas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnTablas.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnTablas.Depth = 0;
            this.btnTablas.HighEmphasis = false;
            this.btnTablas.Icon = null;
            this.btnTablas.Location = new Point(360, 15);
            this.btnTablas.Margin = new Padding(4, 6, 4, 6);
            this.btnTablas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.NoAccentTextColor = Color.Empty;
            this.btnTablas.Size = new Size(100, 30);
            this.btnTablas.TabIndex = 2;
            this.btnTablas.Text = "Tablas";
            this.btnTablas.Type = MaterialButton.MaterialButtonType.Text;
            this.btnTablas.UseAccentColor = false;
            this.btnTablas.Click += new System.EventHandler(this.menuTablas_Click);

            // 
            // btnPrincipal
            // 
            this.btnPrincipal.AutoSize = false;
            this.btnPrincipal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnPrincipal.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnPrincipal.Depth = 0;
            this.btnPrincipal.HighEmphasis = false;
            this.btnPrincipal.Icon = null;
            this.btnPrincipal.Location = new Point(250, 15);
            this.btnPrincipal.Margin = new Padding(4, 6, 4, 6);
            this.btnPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.NoAccentTextColor = Color.Empty;
            this.btnPrincipal.Size = new Size(100, 30);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.Type = MaterialButton.MaterialButtonType.Text;
            this.btnPrincipal.UseAccentColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.menuPrincipal_Click);

            // 
            // lblSistemaFacturacion
            // 
            this.lblSistemaFacturacion.AutoSize = true;
            this.lblSistemaFacturacion.Depth = 0;
            this.lblSistemaFacturacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblSistemaFacturacion.ForeColor = Color.White;
            this.lblSistemaFacturacion.Location = new Point(20, 20);
            this.lblSistemaFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSistemaFacturacion.Name = "lblSistemaFacturacion";
            this.lblSistemaFacturacion.Size = new Size(168, 19);
            this.lblSistemaFacturacion.TabIndex = 0;
            this.lblSistemaFacturacion.Text = "Sistema de Facturación";

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = Color.FromArgb(220, 220, 220);
            this.panelLeft.Controls.Add(this.lblModuloFacturacion);
            this.panelLeft.Controls.Add(this.btnFacturacionLeft);
            this.panelLeft.Controls.Add(this.btnInformesLeft);
            this.panelLeft.Controls.Add(this.lblModuloTablas);
            this.panelLeft.Controls.Add(this.btnProductosLeft);
            this.panelLeft.Controls.Add(this.btnClientesLeft);
            this.panelLeft.Controls.Add(this.btnCategoriasLeft);
            this.panelLeft.Controls.Add(this.btnSalir);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Location = new Point(3, 124);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new Size(200, 640);
            this.panelLeft.TabIndex = 1;

            // 
            // lblModuloFacturacion
            // 
            this.lblModuloFacturacion.AutoSize = true;
            this.lblModuloFacturacion.Depth = 0;
            this.lblModuloFacturacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblModuloFacturacion.Location = new Point(20, 160);
            this.lblModuloFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloFacturacion.Name = "lblModuloFacturacion";
            this.lblModuloFacturacion.Size = new Size(180, 19);
            this.lblModuloFacturacion.TabIndex = 7;
            this.lblModuloFacturacion.Text = "Módulo de Facturación";
            this.lblModuloFacturacion.Visible = false;

            // 
            // btnFacturacionLeft
            // 
            this.btnFacturacionLeft.AutoSize = false;
            this.btnFacturacionLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnFacturacionLeft.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnFacturacionLeft.Depth = 0;
            this.btnFacturacionLeft.HighEmphasis = true;
            this.btnFacturacionLeft.Icon = null;
            this.btnFacturacionLeft.Location = new Point(20, 190);
            this.btnFacturacionLeft.Margin = new Padding(4, 6, 4, 6);
            this.btnFacturacionLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacionLeft.Name = "btnFacturacionLeft";
            this.btnFacturacionLeft.NoAccentTextColor = Color.Empty;
            this.btnFacturacionLeft.Size = new Size(160, 40);
            this.btnFacturacionLeft.TabIndex = 8;
            this.btnFacturacionLeft.Text = "FACTURACIÓN";
            this.btnFacturacionLeft.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnFacturacionLeft.UseAccentColor = false;
            this.btnFacturacionLeft.Visible = false;
            this.btnFacturacionLeft.Click += new System.EventHandler(this.btnFacturacionLeft_Click);

            // 
            // btnInformesLeft
            // 
            this.btnInformesLeft.AutoSize = false;
            this.btnInformesLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnInformesLeft.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnInformesLeft.Depth = 0;
            this.btnInformesLeft.HighEmphasis = true;
            this.btnInformesLeft.Icon = null;
            this.btnInformesLeft.Location = new Point(20, 240);
            this.btnInformesLeft.Margin = new Padding(4, 6, 4, 6);
            this.btnInformesLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInformesLeft.Name = "btnInformesLeft";
            this.btnInformesLeft.NoAccentTextColor = Color.Empty;
            this.btnInformesLeft.Size = new Size(160, 40);
            this.btnInformesLeft.TabIndex = 9;
            this.btnInformesLeft.Text = "INFORMES";
            this.btnInformesLeft.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnInformesLeft.UseAccentColor = false;
            this.btnInformesLeft.Visible = false;
            this.btnInformesLeft.Click += new System.EventHandler(this.btnInformesLeft_Click);

            // 
            // lblModuloTablas
            // 
            this.lblModuloTablas.AutoSize = true;
            this.lblModuloTablas.Depth = 0;
            this.lblModuloTablas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblModuloTablas.Location = new Point(20, 300);
            this.lblModuloTablas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloTablas.Name = "lblModuloTablas";
            this.lblModuloTablas.Size = new Size(129, 19);
            this.lblModuloTablas.TabIndex = 6;
            this.lblModuloTablas.Text = "Módulo de Tablas";
            this.lblModuloTablas.Visible = false;

            // 
            // btnProductosLeft
            // 
            this.btnProductosLeft.AutoSize = false;
            this.btnProductosLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnProductosLeft.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnProductosLeft.Depth = 0;
            this.btnProductosLeft.HighEmphasis = true;
            this.btnProductosLeft.Icon = null;
            this.btnProductosLeft.Location = new Point(20, 330);
            this.btnProductosLeft.Margin = new Padding(4, 6, 4, 6);
            this.btnProductosLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductosLeft.Name = "btnProductosLeft";
            this.btnProductosLeft.NoAccentTextColor = Color.Empty;
            this.btnProductosLeft.Size = new Size(160, 40);
            this.btnProductosLeft.TabIndex = 2;
            this.btnProductosLeft.Text = "PRODUCTOS";
            this.btnProductosLeft.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnProductosLeft.UseAccentColor = false;
            this.btnProductosLeft.Visible = false;
            this.btnProductosLeft.Click += new System.EventHandler(this.btnProductosLeft_Click);

            // 
            // btnClientesLeft
            // 
            this.btnClientesLeft.AutoSize = false;
            this.btnClientesLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnClientesLeft.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnClientesLeft.Depth = 0;
            this.btnClientesLeft.HighEmphasis = true;
            this.btnClientesLeft.Icon = null;
            this.btnClientesLeft.Location = new Point(20, 380);
            this.btnClientesLeft.Margin = new Padding(4, 6, 4, 6);
            this.btnClientesLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientesLeft.Name = "btnClientesLeft";
            this.btnClientesLeft.NoAccentTextColor = Color.Empty;
            this.btnClientesLeft.Size = new Size(160, 40);
            this.btnClientesLeft.TabIndex = 3;
            this.btnClientesLeft.Text = "CLIENTES";
            this.btnClientesLeft.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnClientesLeft.UseAccentColor = false;
            this.btnClientesLeft.Visible = false;
            this.btnClientesLeft.Click += new System.EventHandler(this.btnClientesLeft_Click);

            // 
            // btnCategoriasLeft
            // 
            this.btnCategoriasLeft.AutoSize = false;
            this.btnCategoriasLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnCategoriasLeft.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnCategoriasLeft.Depth = 0;
            this.btnCategoriasLeft.HighEmphasis = true;
            this.btnCategoriasLeft.Icon = null;
            this.btnCategoriasLeft.Location = new Point(20, 430);
            this.btnCategoriasLeft.Margin = new Padding(4, 6, 4, 6);
            this.btnCategoriasLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategoriasLeft.Name = "btnCategoriasLeft";
            this.btnCategoriasLeft.NoAccentTextColor = Color.Empty;
            this.btnCategoriasLeft.Size = new Size(160, 40);
            this.btnCategoriasLeft.TabIndex = 4;
            this.btnCategoriasLeft.Text = "CATEGORÍAS";
            this.btnCategoriasLeft.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnCategoriasLeft.UseAccentColor = false;
            this.btnCategoriasLeft.Visible = false;
            this.btnCategoriasLeft.Click += new System.EventHandler(this.btnCategoriasLeft_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new Point(20, 485);
            this.btnSalir.Margin = new Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = Color.Empty;
            this.btnSalir.Size = new Size(160, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir del sitio";
            this.btnSalir.Type = MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = Color.FromArgb(165, 135, 195);
            this.pictureBoxLogo.BackgroundImage = ((Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.Image = ((Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new Point(20, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Size(160, 120);
            this.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;

            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = Color.White;
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Location = new Point(203, 124);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new Size(1094, 640);
            this.panelContent.TabIndex = 2;

            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1300, 767);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación - Principal";
            this.WindowState = FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
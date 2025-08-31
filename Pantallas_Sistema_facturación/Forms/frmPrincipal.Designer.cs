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

        private MaterialLabel lblModuloTablas;
        private MaterialButton btnProductosLeft;
        private MaterialButton btnClientesLeft;
        private MaterialButton btnCategoriasLeft;

        private MaterialLabel lblModuloSeguridad;
        private MaterialButton btnEmpleadosLeft;
        private MaterialButton btnRolesLeft;
        private MaterialButton btnSeguridadLeft;

        private MaterialLabel lblModuloAyuda;
        private MaterialButton btnAyudaLeft;
        private MaterialButton btnAcercaDeLeft;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.lblModuloFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.btnFacturacionLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnInformesLeft = new MaterialSkin.Controls.MaterialButton();
            this.lblModuloTablas = new MaterialSkin.Controls.MaterialLabel();
            this.btnProductosLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnClientesLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnCategoriasLeft = new MaterialSkin.Controls.MaterialButton();
            this.lblModuloSeguridad = new MaterialSkin.Controls.MaterialLabel();
            this.btnEmpleadosLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnRolesLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnSeguridadLeft = new MaterialSkin.Controls.MaterialButton();
            this.lblModuloAyuda = new MaterialSkin.Controls.MaterialLabel();
            this.btnAyudaLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnAcercaDeLeft = new MaterialSkin.Controls.MaterialButton();
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
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.panelTop.Controls.Add(this.materialButton1);
            this.panelTop.Controls.Add(this.btnSeguridad);
            this.panelTop.Controls.Add(this.btnFacturacion);
            this.panelTop.Controls.Add(this.btnTablas);
            this.panelTop.Controls.Add(this.btnPrincipal);
            this.panelTop.Controls.Add(this.lblSistemaFacturacion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(4, 98);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1942, 92);
            this.panelTop.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1756, 23);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(150, 46);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Ayuda";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AutoSize = false;
            this.btnSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeguridad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeguridad.Depth = 0;
            this.btnSeguridad.HighEmphasis = false;
            this.btnSeguridad.Icon = null;
            this.btnSeguridad.Location = new System.Drawing.Point(900, 23);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeguridad.Size = new System.Drawing.Size(150, 46);
            this.btnSeguridad.TabIndex = 4;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSeguridad.UseAccentColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.menuSeguridad_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.AutoSize = false;
            this.btnFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFacturacion.Depth = 0;
            this.btnFacturacion.HighEmphasis = false;
            this.btnFacturacion.Icon = null;
            this.btnFacturacion.Location = new System.Drawing.Point(705, 23);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFacturacion.Size = new System.Drawing.Size(180, 46);
            this.btnFacturacion.TabIndex = 3;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnFacturacion.UseAccentColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.menuFacturacion_Click);
            // 
            // btnTablas
            // 
            this.btnTablas.AutoSize = false;
            this.btnTablas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTablas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTablas.Depth = 0;
            this.btnTablas.HighEmphasis = false;
            this.btnTablas.Icon = null;
            this.btnTablas.Location = new System.Drawing.Point(540, 23);
            this.btnTablas.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnTablas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTablas.Size = new System.Drawing.Size(150, 46);
            this.btnTablas.TabIndex = 2;
            this.btnTablas.Text = "Tablas";
            this.btnTablas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnTablas.UseAccentColor = false;
            this.btnTablas.Click += new System.EventHandler(this.menuTablas_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.AutoSize = false;
            this.btnPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrincipal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrincipal.Depth = 0;
            this.btnPrincipal.HighEmphasis = false;
            this.btnPrincipal.Icon = null;
            this.btnPrincipal.Location = new System.Drawing.Point(375, 23);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrincipal.Size = new System.Drawing.Size(150, 46);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPrincipal.UseAccentColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.menuPrincipal_Click);
            // 
            // lblSistemaFacturacion
            // 
            this.lblSistemaFacturacion.AutoSize = true;
            this.lblSistemaFacturacion.Depth = 0;
            this.lblSistemaFacturacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSistemaFacturacion.ForeColor = System.Drawing.Color.White;
            this.lblSistemaFacturacion.Location = new System.Drawing.Point(30, 31);
            this.lblSistemaFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSistemaFacturacion.Name = "lblSistemaFacturacion";
            this.lblSistemaFacturacion.Size = new System.Drawing.Size(168, 19);
            this.lblSistemaFacturacion.TabIndex = 0;
            this.lblSistemaFacturacion.Text = "Sistema de Facturación";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelLeft.Controls.Add(this.lblModuloFacturacion);
            this.panelLeft.Controls.Add(this.btnFacturacionLeft);
            this.panelLeft.Controls.Add(this.btnInformesLeft);
            this.panelLeft.Controls.Add(this.lblModuloTablas);
            this.panelLeft.Controls.Add(this.btnProductosLeft);
            this.panelLeft.Controls.Add(this.btnClientesLeft);
            this.panelLeft.Controls.Add(this.btnCategoriasLeft);
            this.panelLeft.Controls.Add(this.lblModuloSeguridad);
            this.panelLeft.Controls.Add(this.btnEmpleadosLeft);
            this.panelLeft.Controls.Add(this.btnRolesLeft);
            this.panelLeft.Controls.Add(this.btnSeguridadLeft);
            this.panelLeft.Controls.Add(this.lblModuloAyuda);
            this.panelLeft.Controls.Add(this.btnAyudaLeft);
            this.panelLeft.Controls.Add(this.btnAcercaDeLeft);
            this.panelLeft.Controls.Add(this.btnSalir);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(4, 190);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 985);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // lblModuloFacturacion
            // 
            this.lblModuloFacturacion.AutoSize = true;
            this.lblModuloFacturacion.Depth = 0;
            this.lblModuloFacturacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModuloFacturacion.Location = new System.Drawing.Point(30, 246);
            this.lblModuloFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloFacturacion.Name = "lblModuloFacturacion";
            this.lblModuloFacturacion.Size = new System.Drawing.Size(164, 19);
            this.lblModuloFacturacion.TabIndex = 7;
            this.lblModuloFacturacion.Text = "Módulo de Facturación";
            this.lblModuloFacturacion.Visible = false;
            this.lblModuloFacturacion.Click += new System.EventHandler(this.lblModuloFacturacion_Click);
            // 
            // btnFacturacionLeft
            // 
            this.btnFacturacionLeft.AutoSize = false;
            this.btnFacturacionLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturacionLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFacturacionLeft.Depth = 0;
            this.btnFacturacionLeft.HighEmphasis = true;
            this.btnFacturacionLeft.Icon = null;
            this.btnFacturacionLeft.Location = new System.Drawing.Point(30, 292);
            this.btnFacturacionLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFacturacionLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacionLeft.Name = "btnFacturacionLeft";
            this.btnFacturacionLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFacturacionLeft.Size = new System.Drawing.Size(240, 62);
            this.btnFacturacionLeft.TabIndex = 8;
            this.btnFacturacionLeft.Text = "FACTURACIÓN";
            this.btnFacturacionLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFacturacionLeft.UseAccentColor = false;
            this.btnFacturacionLeft.Visible = false;
            this.btnFacturacionLeft.Click += new System.EventHandler(this.btnFacturacionLeft_Click);
            // 
            // btnInformesLeft
            // 
            this.btnInformesLeft.AutoSize = false;
            this.btnInformesLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInformesLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInformesLeft.Depth = 0;
            this.btnInformesLeft.HighEmphasis = true;
            this.btnInformesLeft.Icon = null;
            this.btnInformesLeft.Location = new System.Drawing.Point(30, 369);
            this.btnInformesLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnInformesLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInformesLeft.Name = "btnInformesLeft";
            this.btnInformesLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInformesLeft.Size = new System.Drawing.Size(240, 62);
            this.btnInformesLeft.TabIndex = 9;
            this.btnInformesLeft.Text = "INFORMES";
            this.btnInformesLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInformesLeft.UseAccentColor = false;
            this.btnInformesLeft.Visible = false;
            this.btnInformesLeft.Click += new System.EventHandler(this.btnInformesLeft_Click);
            // 
            // lblModuloTablas
            // 
            this.lblModuloTablas.AutoSize = true;
            this.lblModuloTablas.Depth = 0;
            this.lblModuloTablas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModuloTablas.Location = new System.Drawing.Point(53, 246);
            this.lblModuloTablas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloTablas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloTablas.Name = "lblModuloTablas";
            this.lblModuloTablas.Size = new System.Drawing.Size(129, 19);
            this.lblModuloTablas.TabIndex = 6;
            this.lblModuloTablas.Text = "Módulo de Tablas";
            this.lblModuloTablas.Visible = false;
            // 
            // btnProductosLeft
            // 
            this.btnProductosLeft.AutoSize = false;
            this.btnProductosLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductosLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProductosLeft.Depth = 0;
            this.btnProductosLeft.HighEmphasis = true;
            this.btnProductosLeft.Icon = null;
            this.btnProductosLeft.Location = new System.Drawing.Point(30, 292);
            this.btnProductosLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnProductosLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductosLeft.Name = "btnProductosLeft";
            this.btnProductosLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProductosLeft.Size = new System.Drawing.Size(240, 62);
            this.btnProductosLeft.TabIndex = 2;
            this.btnProductosLeft.Text = "PRODUCTOS";
            this.btnProductosLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProductosLeft.UseAccentColor = false;
            this.btnProductosLeft.Visible = false;
            this.btnProductosLeft.Click += new System.EventHandler(this.btnProductosLeft_Click);
            // 
            // btnClientesLeft
            // 
            this.btnClientesLeft.AutoSize = false;
            this.btnClientesLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientesLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientesLeft.Depth = 0;
            this.btnClientesLeft.HighEmphasis = true;
            this.btnClientesLeft.Icon = null;
            this.btnClientesLeft.Location = new System.Drawing.Point(30, 372);
            this.btnClientesLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnClientesLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientesLeft.Name = "btnClientesLeft";
            this.btnClientesLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientesLeft.Size = new System.Drawing.Size(240, 62);
            this.btnClientesLeft.TabIndex = 3;
            this.btnClientesLeft.Text = "CLIENTES";
            this.btnClientesLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientesLeft.UseAccentColor = false;
            this.btnClientesLeft.Visible = false;
            this.btnClientesLeft.Click += new System.EventHandler(this.btnClientesLeft_Click);
            // 
            // btnCategoriasLeft
            // 
            this.btnCategoriasLeft.AutoSize = false;
            this.btnCategoriasLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategoriasLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCategoriasLeft.Depth = 0;
            this.btnCategoriasLeft.HighEmphasis = true;
            this.btnCategoriasLeft.Icon = null;
            this.btnCategoriasLeft.Location = new System.Drawing.Point(30, 452);
            this.btnCategoriasLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnCategoriasLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategoriasLeft.Name = "btnCategoriasLeft";
            this.btnCategoriasLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCategoriasLeft.Size = new System.Drawing.Size(240, 62);
            this.btnCategoriasLeft.TabIndex = 4;
            this.btnCategoriasLeft.Text = "CATEGORÍAS";
            this.btnCategoriasLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCategoriasLeft.UseAccentColor = false;
            this.btnCategoriasLeft.Visible = false;
            this.btnCategoriasLeft.Click += new System.EventHandler(this.btnCategoriasLeft_Click);
            // 
            // lblModuloSeguridad
            // 
            this.lblModuloSeguridad.AutoSize = true;
            this.lblModuloSeguridad.Depth = 0;
            this.lblModuloSeguridad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModuloSeguridad.Location = new System.Drawing.Point(30, 246);
            this.lblModuloSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloSeguridad.Name = "lblModuloSeguridad";
            this.lblModuloSeguridad.Size = new System.Drawing.Size(152, 19);
            this.lblModuloSeguridad.TabIndex = 6;
            this.lblModuloSeguridad.Text = "Módulo de Seguridad";
            this.lblModuloSeguridad.Visible = false;
            // 
            // btnEmpleadosLeft
            // 
            this.btnEmpleadosLeft.AutoSize = false;
            this.btnEmpleadosLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleadosLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleadosLeft.Depth = 0;
            this.btnEmpleadosLeft.HighEmphasis = true;
            this.btnEmpleadosLeft.Icon = null;
            this.btnEmpleadosLeft.Location = new System.Drawing.Point(30, 292);
            this.btnEmpleadosLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnEmpleadosLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleadosLeft.Name = "btnEmpleadosLeft";
            this.btnEmpleadosLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEmpleadosLeft.Size = new System.Drawing.Size(240, 62);
            this.btnEmpleadosLeft.TabIndex = 2;
            this.btnEmpleadosLeft.Text = "EMPLEADOS";
            this.btnEmpleadosLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleadosLeft.UseAccentColor = false;
            this.btnEmpleadosLeft.Visible = false;
            this.btnEmpleadosLeft.Click += new System.EventHandler(this.btnEmpleadosLeft_Click);
            // 
            // btnRolesLeft
            // 
            this.btnRolesLeft.AutoSize = false;
            this.btnRolesLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRolesLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRolesLeft.Depth = 0;
            this.btnRolesLeft.HighEmphasis = true;
            this.btnRolesLeft.Icon = null;
            this.btnRolesLeft.Location = new System.Drawing.Point(30, 369);
            this.btnRolesLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnRolesLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRolesLeft.Name = "btnRolesLeft";
            this.btnRolesLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRolesLeft.Size = new System.Drawing.Size(240, 62);
            this.btnRolesLeft.TabIndex = 3;
            this.btnRolesLeft.Text = "ROLES";
            this.btnRolesLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRolesLeft.UseAccentColor = false;
            this.btnRolesLeft.Visible = false;
            this.btnRolesLeft.Click += new System.EventHandler(this.btnRolesLeft_Click);
            // 
            // btnSeguridadLeft
            // 
            this.btnSeguridadLeft.AutoSize = false;
            this.btnSeguridadLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeguridadLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeguridadLeft.Depth = 0;
            this.btnSeguridadLeft.HighEmphasis = true;
            this.btnSeguridadLeft.Icon = null;
            this.btnSeguridadLeft.Location = new System.Drawing.Point(30, 446);
            this.btnSeguridadLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSeguridadLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridadLeft.Name = "btnSeguridadLeft";
            this.btnSeguridadLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeguridadLeft.Size = new System.Drawing.Size(240, 62);
            this.btnSeguridadLeft.TabIndex = 4;
            this.btnSeguridadLeft.Text = "SEGURIDAD";
            this.btnSeguridadLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeguridadLeft.UseAccentColor = false;
            this.btnSeguridadLeft.Visible = false;
            this.btnSeguridadLeft.Click += new System.EventHandler(this.btnSeguridadLeft_Click);
            // 
            // lblModuloAyuda
            // 
            this.lblModuloAyuda.AutoSize = true;
            this.lblModuloAyuda.Depth = 0;
            this.lblModuloAyuda.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModuloAyuda.Location = new System.Drawing.Point(30, 246);
            this.lblModuloAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModuloAyuda.Name = "lblModuloAyuda";
            this.lblModuloAyuda.Size = new System.Drawing.Size(125, 19);
            this.lblModuloAyuda.TabIndex = 7;
            this.lblModuloAyuda.Text = "Módulo de Ayuda";
            this.lblModuloAyuda.Visible = false;
            // 
            // btnAyudaLeft
            // 
            this.btnAyudaLeft.AutoSize = false;
            this.btnAyudaLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAyudaLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAyudaLeft.Depth = 0;
            this.btnAyudaLeft.HighEmphasis = true;
            this.btnAyudaLeft.Icon = null;
            this.btnAyudaLeft.Location = new System.Drawing.Point(30, 292);
            this.btnAyudaLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnAyudaLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAyudaLeft.Name = "btnAyudaLeft";
            this.btnAyudaLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAyudaLeft.Size = new System.Drawing.Size(240, 62);
            this.btnAyudaLeft.TabIndex = 4;
            this.btnAyudaLeft.Text = "AYUDA";
            this.btnAyudaLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAyudaLeft.UseAccentColor = false;
            this.btnAyudaLeft.Visible = false;
            this.btnAyudaLeft.Click += new System.EventHandler(this.btnAyudaLeft_Click);
            // 
            // btnAcercaDeLeft
            // 
            this.btnAcercaDeLeft.AutoSize = false;
            this.btnAcercaDeLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcercaDeLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcercaDeLeft.Depth = 0;
            this.btnAcercaDeLeft.HighEmphasis = true;
            this.btnAcercaDeLeft.Icon = null;
            this.btnAcercaDeLeft.Location = new System.Drawing.Point(30, 369);
            this.btnAcercaDeLeft.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnAcercaDeLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcercaDeLeft.Name = "btnAcercaDeLeft";
            this.btnAcercaDeLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcercaDeLeft.Size = new System.Drawing.Size(240, 62);
            this.btnAcercaDeLeft.TabIndex = 4;
            this.btnAcercaDeLeft.Text = "ACERCA DE";
            this.btnAcercaDeLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcercaDeLeft.UseAccentColor = false;
            this.btnAcercaDeLeft.Visible = false;
            this.btnAcercaDeLeft.Click += new System.EventHandler(this.btnAcercaDeLeft_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(30, 746);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(240, 62);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir del sitio";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 31);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(240, 185);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(304, 190);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1642, 985);
            this.panelContent.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1950, 1180);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialButton materialButton1;
    }
}

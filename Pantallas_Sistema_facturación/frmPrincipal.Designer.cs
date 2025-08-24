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
        private MaterialButton btnClientes;
        
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
            this.btnClientes = new MaterialSkin.Controls.MaterialButton();
            this.btnSeguridad = new MaterialSkin.Controls.MaterialButton();
            this.btnFacturacion = new MaterialSkin.Controls.MaterialButton();
            this.btnTablas = new MaterialSkin.Controls.MaterialButton();
            this.btnPrincipal = new MaterialSkin.Controls.MaterialButton();
            this.lblSistemaFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
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
            this.panelTop.Controls.Add(this.btnClientes);
            this.panelTop.Controls.Add(this.btnSeguridad);
            this.panelTop.Controls.Add(this.btnFacturacion);
            this.panelTop.Controls.Add(this.btnTablas);
            this.panelTop.Controls.Add(this.btnPrincipal);
            this.panelTop.Controls.Add(this.lblSistemaFacturacion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 64);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1294, 60);
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
            this.materialButton1.Location = new System.Drawing.Point(1171, 15);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 30);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Ayuda";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.HighEmphasis = false;
            this.btnClientes.Icon = null;
            this.btnClientes.Location = new System.Drawing.Point(710, 15);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientes.Size = new System.Drawing.Size(100, 30);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AutoSize = false;
            this.btnSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeguridad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeguridad.Depth = 0;
            this.btnSeguridad.HighEmphasis = false;
            this.btnSeguridad.Icon = null;
            this.btnSeguridad.Location = new System.Drawing.Point(600, 15);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeguridad.Size = new System.Drawing.Size(100, 30);
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
            this.btnFacturacion.Location = new System.Drawing.Point(470, 15);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFacturacion.Size = new System.Drawing.Size(120, 30);
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
            this.btnTablas.Location = new System.Drawing.Point(360, 15);
            this.btnTablas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTablas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTablas.Size = new System.Drawing.Size(100, 30);
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
            this.btnPrincipal.Location = new System.Drawing.Point(250, 15);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrincipal.Size = new System.Drawing.Size(100, 30);
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
            this.lblSistemaFacturacion.Location = new System.Drawing.Point(20, 20);
            this.lblSistemaFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSistemaFacturacion.Name = "lblSistemaFacturacion";
            this.lblSistemaFacturacion.Size = new System.Drawing.Size(168, 19);
            this.lblSistemaFacturacion.TabIndex = 0;
            this.lblSistemaFacturacion.Text = "Sistema de Facturación";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelLeft.Controls.Add(this.btnSalir);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 124);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 640);
            this.panelLeft.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(20, 480);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(160, 40);
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
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(160, 120);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(203, 124);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1094, 640);
            this.panelContent.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 767);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialButton materialButton1;
    }
}
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Ayuda
{
    partial class ucAcercaDe
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private MaterialSkin.Controls.MaterialLabel lblFramework;
        private MaterialSkin.Controls.MaterialLabel lblCopyright;
        private MaterialSkin.Controls.MaterialLabel lblLicencia;
        private MaterialSkin.Controls.MaterialLabel lblProveedores;
        private MaterialSkin.Controls.MaterialLabel lblDetalle;
        private MaterialSkin.Controls.MaterialLabel lblAdvertencia;

        private MaterialSkin.Controls.MaterialTextBox txtVersion;
        private MaterialSkin.Controls.MaterialTextBox txtFramework;
        private MaterialSkin.Controls.MaterialTextBox txtCopyright;
        private MaterialSkin.Controls.MaterialTextBox txtLicencia;
        private MaterialSkin.Controls.MaterialComboBox cmbProveedores;
        private MaterialSkin.Controls.MaterialTextBox txtDetalle;

        private MaterialSkin.Controls.MaterialButton btnCopiar;
        private MaterialSkin.Controls.MaterialButton btnInfoSistema;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnAceptar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAcercaDe));
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.lblFramework = new MaterialSkin.Controls.MaterialLabel();
            this.lblCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.lblLicencia = new MaterialSkin.Controls.MaterialLabel();
            this.lblProveedores = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalle = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdvertencia = new MaterialSkin.Controls.MaterialLabel();
            this.txtVersion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFramework = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCopyright = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLicencia = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbProveedores = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDetalle = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCopiar = new MaterialSkin.Controls.MaterialButton();
            this.btnInfoSistema = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(18, 5);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ACERCA DEL SISTEMA DE FACTURACIÓN";
            // 
            // lblVersion
            // 
            this.lblVersion.Depth = 0;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVersion.Location = new System.Drawing.Point(3, 4);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(154, 41);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versión";
            // 
            // lblFramework
            // 
            this.lblFramework.Depth = 0;
            this.lblFramework.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFramework.Location = new System.Drawing.Point(3, 4);
            this.lblFramework.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFramework.Name = "lblFramework";
            this.lblFramework.Size = new System.Drawing.Size(120, 25);
            this.lblFramework.TabIndex = 3;
            this.lblFramework.Text = ".NET Framework";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Depth = 0;
            this.lblCopyright.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCopyright.Location = new System.Drawing.Point(3, 4);
            this.lblCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(100, 25);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblLicencia
            // 
            this.lblLicencia.Depth = 0;
            this.lblLicencia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLicencia.Location = new System.Drawing.Point(3, 0);
            this.lblLicencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(100, 25);
            this.lblLicencia.TabIndex = 7;
            this.lblLicencia.Text = "Licencia";
            // 
            // lblProveedores
            // 
            this.lblProveedores.Depth = 0;
            this.lblProveedores.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProveedores.Location = new System.Drawing.Point(400, 0);
            this.lblProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(180, 25);
            this.lblProveedores.TabIndex = 9;
            this.lblProveedores.Text = "Componentes instalados";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetalle.Depth = 0;
            this.lblDetalle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDetalle.Location = new System.Drawing.Point(3, 129);
            this.lblDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(180, 25);
            this.lblDetalle.TabIndex = 11;
            this.lblDetalle.Text = "Detalles del producto";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Depth = 0;
            this.lblAdvertencia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAdvertencia.Location = new System.Drawing.Point(2, 8);
            this.lblAdvertencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(376, 137);
            this.lblAdvertencia.TabIndex = 17;
            this.lblAdvertencia.Text = resources.GetString("lblAdvertencia.Text");
            // 
            // txtVersion
            // 
            this.txtVersion.AnimateReadOnly = false;
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVersion.Depth = 0;
            this.txtVersion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVersion.Hint = "v2.1.4";
            this.txtVersion.LeadingIcon = null;
            this.txtVersion.Location = new System.Drawing.Point(3, 3);
            this.txtVersion.MaxLength = 50;
            this.txtVersion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVersion.Multiline = false;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(180, 50);
            this.txtVersion.TabIndex = 2;
            this.txtVersion.Text = "";
            this.txtVersion.TrailingIcon = null;
            // 
            // txtFramework
            // 
            this.txtFramework.AnimateReadOnly = false;
            this.txtFramework.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFramework.Depth = 0;
            this.txtFramework.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFramework.Hint = "4.8.03752";
            this.txtFramework.LeadingIcon = null;
            this.txtFramework.Location = new System.Drawing.Point(256, 3);
            this.txtFramework.MaxLength = 50;
            this.txtFramework.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFramework.Multiline = false;
            this.txtFramework.Name = "txtFramework";
            this.txtFramework.Size = new System.Drawing.Size(180, 50);
            this.txtFramework.TabIndex = 4;
            this.txtFramework.Text = "";
            this.txtFramework.TrailingIcon = null;
            // 
            // txtCopyright
            // 
            this.txtCopyright.AnimateReadOnly = false;
            this.txtCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCopyright.Depth = 0;
            this.txtCopyright.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCopyright.Hint = "© 2025 Mi Empresa";
            this.txtCopyright.LeadingIcon = null;
            this.txtCopyright.Location = new System.Drawing.Point(501, 3);
            this.txtCopyright.MaxLength = 50;
            this.txtCopyright.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCopyright.Multiline = false;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(180, 50);
            this.txtCopyright.TabIndex = 6;
            this.txtCopyright.Text = "";
            this.txtCopyright.TrailingIcon = null;
            // 
            // txtLicencia
            // 
            this.txtLicencia.AnimateReadOnly = false;
            this.txtLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicencia.Depth = 0;
            this.txtLicencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLicencia.Hint = "GPL v3";
            this.txtLicencia.LeadingIcon = null;
            this.txtLicencia.Location = new System.Drawing.Point(3, 31);
            this.txtLicencia.MaxLength = 50;
            this.txtLicencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLicencia.Multiline = false;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(370, 50);
            this.txtLicencia.TabIndex = 8;
            this.txtLicencia.Text = "";
            this.txtLicencia.TrailingIcon = null;
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.AutoResize = false;
            this.cmbProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProveedores.Depth = 0;
            this.cmbProveedores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProveedores.DropDownHeight = 174;
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.DropDownWidth = 121;
            this.cmbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbProveedores.IntegralHeight = false;
            this.cmbProveedores.ItemHeight = 43;
            this.cmbProveedores.Location = new System.Drawing.Point(400, 31);
            this.cmbProveedores.MaxDropDownItems = 4;
            this.cmbProveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(180, 49);
            this.cmbProveedores.StartIndex = 0;
            this.cmbProveedores.TabIndex = 10;
            // 
            // txtDetalle
            // 
            this.txtDetalle.AnimateReadOnly = false;
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalle.Depth = 0;
            this.txtDetalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDetalle.Hint = "Visual Studio 2022, C#";
            this.txtDetalle.LeadingIcon = null;
            this.txtDetalle.Location = new System.Drawing.Point(3, 157);
            this.txtDetalle.MaxLength = 50;
            this.txtDetalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDetalle.Multiline = false;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(370, 50);
            this.txtDetalle.TabIndex = 12;
            this.txtDetalle.Text = "";
            this.txtDetalle.TrailingIcon = null;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopiar.Depth = 0;
            this.btnCopiar.HighEmphasis = true;
            this.btnCopiar.Icon = null;
            this.btnCopiar.Location = new System.Drawing.Point(507, 110);
            this.btnCopiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopiar.Size = new System.Drawing.Size(177, 36);
            this.btnCopiar.TabIndex = 13;
            this.btnCopiar.Text = "Copiar información";
            this.btnCopiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopiar.UseAccentColor = false;
            // 
            // btnInfoSistema
            // 
            this.btnInfoSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfoSistema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInfoSistema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInfoSistema.Depth = 0;
            this.btnInfoSistema.HighEmphasis = true;
            this.btnInfoSistema.Icon = null;
            this.btnInfoSistema.Location = new System.Drawing.Point(518, 171);
            this.btnInfoSistema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInfoSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInfoSistema.Name = "btnInfoSistema";
            this.btnInfoSistema.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInfoSistema.Size = new System.Drawing.Size(154, 36);
            this.btnInfoSistema.TabIndex = 14;
            this.btnInfoSistema.Text = "Info. del sistema";
            this.btnInfoSistema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInfoSistema.UseAccentColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(156, 22);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(19, 22);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 62);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFramework);
            this.panel2.Location = new System.Drawing.Point(259, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 45);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCopyright);
            this.panel3.Location = new System.Drawing.Point(502, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 45);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.80321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.19679F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel2.Controls.Add(this.txtVersion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFramework, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCopyright, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 109);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 75);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtLicencia, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbProveedores, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblProveedores, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblLicencia, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDetalle, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblDetalle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnCopiar, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnInfoSistema, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 190);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 225);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblAdvertencia);
            this.panel4.Location = new System.Drawing.Point(14, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 157);
            this.panel4.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(480, 462);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(251, 81);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel4);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Controls.Add(this.lblTitulo);
            this.panel5.Location = new System.Drawing.Point(9, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(817, 594);
            this.panel5.TabIndex = 23;
            // 
            // ucAyuda
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Name = "ucAyuda";
            this.Size = new System.Drawing.Size(827, 622);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel5;
    }
}
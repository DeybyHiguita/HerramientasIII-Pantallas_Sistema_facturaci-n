using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Facturacion.UserControls
{
    partial class ucFacturacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblNroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCliente = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTotalIVA = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalIVA = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTotalFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.lblObservaciones = new MaterialSkin.Controls.MaterialLabel();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.chkFacturaPagada = new System.Windows.Forms.CheckBox();
            this.tlpNroFactura = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFecha = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmpleado = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEstado = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDescuento = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTotalIVA = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTotalFactura = new System.Windows.Forms.TableLayoutPanel();
            this.tlpObservaciones = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNroFactura.SuspendLayout();
            this.tlpFecha.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.tlpEmpleado.SuspendLayout();
            this.tlpEstado.SuspendLayout();
            this.tlpDescuento.SuspendLayout();
            this.tlpTotalIVA.SuspendLayout();
            this.tlpTotalFactura.SuspendLayout();
            this.tlpObservaciones.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Depth = 0;
            this.lblNroFactura.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNroFactura.Location = new System.Drawing.Point(3, 0);
            this.lblNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(88, 19);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Nro. Factura";
            this.lblNroFactura.Click += new System.EventHandler(this.lblNroFactura_Click);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.AnimateReadOnly = false;
            this.txtNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroFactura.Depth = 0;
            this.txtNroFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNroFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroFactura.LeadingIcon = null;
            this.txtNroFactura.Location = new System.Drawing.Point(3, 32);
            this.txtNroFactura.MaxLength = 20;
            this.txtNroFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroFactura.Multiline = false;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(239, 50);
            this.txtNroFactura.TabIndex = 1;
            this.txtNroFactura.Text = "";
            this.txtNroFactura.TrailingIcon = null;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFecha.Location = new System.Drawing.Point(3, 0);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.White;
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(3, 32);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCliente.Location = new System.Drawing.Point(3, 0);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoResize = false;
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCliente.Depth = 0;
            this.cmbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCliente.DropDownHeight = 174;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.DropDownWidth = 121;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.ItemHeight = 43;
            this.cmbCliente.Location = new System.Drawing.Point(3, 32);
            this.cmbCliente.MaxDropDownItems = 4;
            this.cmbCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(242, 49);
            this.cmbCliente.StartIndex = 0;
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpleado.Location = new System.Drawing.Point(3, 0);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(72, 19);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.AutoResize = false;
            this.cmbEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpleado.Depth = 0;
            this.cmbEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpleado.DropDownHeight = 174;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.DropDownWidth = 121;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.ItemHeight = 43;
            this.cmbEmpleado.Location = new System.Drawing.Point(3, 32);
            this.cmbEmpleado.MaxDropDownItems = 4;
            this.cmbEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(239, 49);
            this.cmbEmpleado.StartIndex = 0;
            this.cmbEmpleado.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstado.Location = new System.Drawing.Point(3, 0);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 19);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.Depth = 0;
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(3, 32);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(239, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 1;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Depth = 0;
            this.lblDescuento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescuento.Location = new System.Drawing.Point(3, 0);
            this.lblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 19);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(3, 32);
            this.txtDescuento.MaxLength = 10;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(242, 50);
            this.txtDescuento.TabIndex = 1;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            // 
            // lblTotalIVA
            // 
            this.lblTotalIVA.AutoSize = true;
            this.lblTotalIVA.Depth = 0;
            this.lblTotalIVA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalIVA.Location = new System.Drawing.Point(3, 0);
            this.lblTotalIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalIVA.Name = "lblTotalIVA";
            this.lblTotalIVA.Size = new System.Drawing.Size(66, 19);
            this.lblTotalIVA.TabIndex = 0;
            this.lblTotalIVA.Text = "Total IVA";
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.AnimateReadOnly = false;
            this.txtTotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalIVA.Depth = 0;
            this.txtTotalIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalIVA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalIVA.LeadingIcon = null;
            this.txtTotalIVA.Location = new System.Drawing.Point(3, 32);
            this.txtTotalIVA.MaxLength = 15;
            this.txtTotalIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalIVA.Multiline = false;
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.Size = new System.Drawing.Size(239, 50);
            this.txtTotalIVA.TabIndex = 1;
            this.txtTotalIVA.Text = "";
            this.txtTotalIVA.TrailingIcon = null;
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Depth = 0;
            this.lblTotalFactura.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalFactura.Location = new System.Drawing.Point(3, 0);
            this.lblTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(96, 19);
            this.lblTotalFactura.TabIndex = 0;
            this.lblTotalFactura.Text = "Total Factura";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.AnimateReadOnly = false;
            this.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalFactura.LeadingIcon = null;
            this.txtTotalFactura.Location = new System.Drawing.Point(3, 32);
            this.txtTotalFactura.MaxLength = 15;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalFactura.Multiline = false;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(239, 50);
            this.txtTotalFactura.TabIndex = 1;
            this.txtTotalFactura.Text = "";
            this.txtTotalFactura.TrailingIcon = null;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Depth = 0;
            this.lblObservaciones.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblObservaciones.Location = new System.Drawing.Point(3, 0);
            this.lblObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(105, 19);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtObservaciones.Location = new System.Drawing.Point(3, 32);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(744, 74);
            this.txtObservaciones.TabIndex = 1;
            this.txtObservaciones.TabStop = false;
            this.txtObservaciones.Text = "";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(4, 19);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(116, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "GUARDAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(128, 19);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(116, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkFacturaPagada
            // 
            this.chkFacturaPagada.AutoSize = true;
            this.chkFacturaPagada.Location = new System.Drawing.Point(30, 60);
            this.chkFacturaPagada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFacturaPagada.Name = "chkFacturaPagada";
            this.chkFacturaPagada.Size = new System.Drawing.Size(149, 24);
            this.chkFacturaPagada.TabIndex = 1;
            this.chkFacturaPagada.Text = "Factura Pagada";
            this.chkFacturaPagada.UseVisualStyleBackColor = true;
            // 
            // tlpNroFactura
            // 
            this.tlpNroFactura.ColumnCount = 1;
            this.tlpNroFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNroFactura.Controls.Add(this.lblNroFactura, 0, 0);
            this.tlpNroFactura.Controls.Add(this.txtNroFactura, 0, 1);
            this.tlpNroFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNroFactura.Location = new System.Drawing.Point(3, 3);
            this.tlpNroFactura.Name = "tlpNroFactura";
            this.tlpNroFactura.RowCount = 2;
            this.tlpNroFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpNroFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNroFactura.Size = new System.Drawing.Size(245, 112);
            this.tlpNroFactura.TabIndex = 2;
            // 
            // tlpFecha
            // 
            this.tlpFecha.ColumnCount = 1;
            this.tlpFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFecha.Controls.Add(this.lblFecha, 0, 0);
            this.tlpFecha.Controls.Add(this.dtpFecha, 0, 1);
            this.tlpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFecha.Location = new System.Drawing.Point(254, 3);
            this.tlpFecha.Name = "tlpFecha";
            this.tlpFecha.RowCount = 2;
            this.tlpFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFecha.Size = new System.Drawing.Size(245, 112);
            this.tlpFecha.TabIndex = 3;
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 1;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.Controls.Add(this.lblCliente, 0, 0);
            this.tlpCliente.Controls.Add(this.cmbCliente, 0, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(505, 3);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 2;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.Size = new System.Drawing.Size(248, 112);
            this.tlpCliente.TabIndex = 4;
            // 
            // tlpEmpleado
            // 
            this.tlpEmpleado.ColumnCount = 1;
            this.tlpEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmpleado.Controls.Add(this.lblEmpleado, 0, 0);
            this.tlpEmpleado.Controls.Add(this.cmbEmpleado, 0, 1);
            this.tlpEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmpleado.Location = new System.Drawing.Point(3, 121);
            this.tlpEmpleado.Name = "tlpEmpleado";
            this.tlpEmpleado.RowCount = 2;
            this.tlpEmpleado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpEmpleado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmpleado.Size = new System.Drawing.Size(245, 112);
            this.tlpEmpleado.TabIndex = 5;
            // 
            // tlpEstado
            // 
            this.tlpEstado.ColumnCount = 1;
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstado.Controls.Add(this.lblEstado, 0, 0);
            this.tlpEstado.Controls.Add(this.cmbEstado, 0, 1);
            this.tlpEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEstado.Location = new System.Drawing.Point(254, 121);
            this.tlpEstado.Name = "tlpEstado";
            this.tlpEstado.RowCount = 2;
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstado.Size = new System.Drawing.Size(245, 112);
            this.tlpEstado.TabIndex = 6;
            // 
            // tlpDescuento
            // 
            this.tlpDescuento.ColumnCount = 1;
            this.tlpDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescuento.Controls.Add(this.lblDescuento, 0, 0);
            this.tlpDescuento.Controls.Add(this.txtDescuento, 0, 1);
            this.tlpDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDescuento.Location = new System.Drawing.Point(505, 121);
            this.tlpDescuento.Name = "tlpDescuento";
            this.tlpDescuento.RowCount = 2;
            this.tlpDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescuento.Size = new System.Drawing.Size(248, 112);
            this.tlpDescuento.TabIndex = 7;
            // 
            // tlpTotalIVA
            // 
            this.tlpTotalIVA.ColumnCount = 1;
            this.tlpTotalIVA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalIVA.Controls.Add(this.lblTotalIVA, 0, 0);
            this.tlpTotalIVA.Controls.Add(this.txtTotalIVA, 0, 1);
            this.tlpTotalIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalIVA.Location = new System.Drawing.Point(3, 239);
            this.tlpTotalIVA.Name = "tlpTotalIVA";
            this.tlpTotalIVA.RowCount = 2;
            this.tlpTotalIVA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTotalIVA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalIVA.Size = new System.Drawing.Size(245, 112);
            this.tlpTotalIVA.TabIndex = 8;
            // 
            // tlpTotalFactura
            // 
            this.tlpTotalFactura.ColumnCount = 1;
            this.tlpTotalFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalFactura.Controls.Add(this.lblTotalFactura, 0, 0);
            this.tlpTotalFactura.Controls.Add(this.txtTotalFactura, 0, 1);
            this.tlpTotalFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalFactura.Location = new System.Drawing.Point(254, 239);
            this.tlpTotalFactura.Name = "tlpTotalFactura";
            this.tlpTotalFactura.RowCount = 2;
            this.tlpTotalFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTotalFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalFactura.Size = new System.Drawing.Size(245, 112);
            this.tlpTotalFactura.TabIndex = 9;
            // 
            // tlpObservaciones
            // 
            this.tlpObservaciones.ColumnCount = 1;
            this.tlpPrincipal.SetColumnSpan(this.tlpObservaciones, 3);
            this.tlpObservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObservaciones.Controls.Add(this.lblObservaciones, 0, 0);
            this.tlpObservaciones.Controls.Add(this.txtObservaciones, 0, 1);
            this.tlpObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpObservaciones.Location = new System.Drawing.Point(3, 357);
            this.tlpObservaciones.Name = "tlpObservaciones";
            this.tlpObservaciones.RowCount = 2;
            this.tlpObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObservaciones.Size = new System.Drawing.Size(750, 109);
            this.tlpObservaciones.TabIndex = 10;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 2, 4);
            this.tlpPrincipal.Controls.Add(this.tlpNroFactura, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpFecha, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tlpCliente, 2, 0);
            this.tlpPrincipal.Controls.Add(this.tlpEmpleado, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpEstado, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpDescuento, 2, 1);
            this.tlpPrincipal.Controls.Add(this.tlpTotalIVA, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpTotalFactura, 1, 2);
            this.tlpPrincipal.Controls.Add(this.tlpObservaciones, 0, 3);
            this.tlpPrincipal.Location = new System.Drawing.Point(30, 94);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.Size = new System.Drawing.Size(756, 551);
            this.tlpPrincipal.TabIndex = 10;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalir, 1, 0);
            this.tlpBotones.Controls.Add(this.btnActualizar, 0, 0);
            this.tlpBotones.Location = new System.Drawing.Point(505, 473);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(248, 74);
            this.tlpBotones.TabIndex = 13;
            // 
            // ucFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.chkFacturaPagada);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ucFacturacion";
            this.Size = new System.Drawing.Size(825, 692);
            this.Load += new System.EventHandler(this.ucFacturacion_Load);
            this.tlpNroFactura.ResumeLayout(false);
            this.tlpNroFactura.PerformLayout();
            this.tlpFecha.ResumeLayout(false);
            this.tlpFecha.PerformLayout();
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.tlpEmpleado.ResumeLayout(false);
            this.tlpEmpleado.PerformLayout();
            this.tlpEstado.ResumeLayout(false);
            this.tlpEstado.PerformLayout();
            this.tlpDescuento.ResumeLayout(false);
            this.tlpDescuento.PerformLayout();
            this.tlpTotalIVA.ResumeLayout(false);
            this.tlpTotalIVA.PerformLayout();
            this.tlpTotalFactura.ResumeLayout(false);
            this.tlpTotalFactura.PerformLayout();
            this.tlpObservaciones.ResumeLayout(false);
            this.tlpObservaciones.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitulo;
        private System.Windows.Forms.CheckBox chkFacturaPagada;
        private MaterialLabel lblNroFactura;
        private MaterialTextBox txtNroFactura;
        private MaterialLabel lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialLabel lblCliente;
        private MaterialComboBox cmbCliente;
        private MaterialLabel lblEmpleado;
        private MaterialComboBox cmbEmpleado;
        private MaterialLabel lblEstado;
        private MaterialComboBox cmbEstado;
        private MaterialLabel lblDescuento;
        private MaterialTextBox txtDescuento;
        private MaterialLabel lblTotalIVA;
        private MaterialTextBox txtTotalIVA;
        private MaterialLabel lblTotalFactura;
        private MaterialTextBox txtTotalFactura;
        private MaterialLabel lblObservaciones;
        private MaterialMultiLineTextBox txtObservaciones;
        private MaterialButton btnActualizar;
        private MaterialButton btnSalir;

        // TableLayoutPanels
        private System.Windows.Forms.TableLayoutPanel tlpNroFactura;
        private System.Windows.Forms.TableLayoutPanel tlpFecha;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.TableLayoutPanel tlpEmpleado;
        private System.Windows.Forms.TableLayoutPanel tlpEstado;
        private System.Windows.Forms.TableLayoutPanel tlpDescuento;
        private System.Windows.Forms.TableLayoutPanel tlpTotalIVA;
        private System.Windows.Forms.TableLayoutPanel tlpTotalFactura;
        private System.Windows.Forms.TableLayoutPanel tlpObservaciones;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
    }
}
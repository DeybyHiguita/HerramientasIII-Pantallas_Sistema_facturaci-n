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
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblProductos = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(271, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroFactura.Depth = 0;
            this.lblNroFactura.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNroFactura.Location = new System.Drawing.Point(3, 5);
            this.lblNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(169, 23);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Nro Factura";
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
            this.txtNroFactura.Location = new System.Drawing.Point(3, 43);
            this.txtNroFactura.MaxLength = 20;
            this.txtNroFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroFactura.Multiline = false;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(209, 50);
            this.txtNroFactura.TabIndex = 1;
            this.txtNroFactura.Text = "";
            this.txtNroFactura.TrailingIcon = null;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFecha.Location = new System.Drawing.Point(3, 5);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Location = new System.Drawing.Point(218, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCliente.Location = new System.Drawing.Point(3, 5);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 23);
            this.lblCliente.TabIndex = 7;
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
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.ItemHeight = 43;
            this.cmbCliente.Location = new System.Drawing.Point(3, 210);
            this.cmbCliente.MaxDropDownItems = 4;
            this.cmbCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(209, 49);
            this.cmbCliente.StartIndex = 0;
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpleado.Location = new System.Drawing.Point(0, 6);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(123, 23);
            this.lblEmpleado.TabIndex = 9;
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
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.ItemHeight = 43;
            this.cmbEmpleado.Location = new System.Drawing.Point(218, 210);
            this.cmbEmpleado.MaxDropDownItems = 4;
            this.cmbEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(209, 49);
            this.cmbEmpleado.StartIndex = 0;
            this.cmbEmpleado.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstado.Location = new System.Drawing.Point(3, 5);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 23);
            this.lblEstado.TabIndex = 4;
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
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(433, 43);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(209, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 5;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuento.Depth = 0;
            this.lblDescuento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescuento.Location = new System.Drawing.Point(3, 7);
            this.lblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(132, 23);
            this.lblDescuento.TabIndex = 11;
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
            this.txtDescuento.Location = new System.Drawing.Point(433, 210);
            this.txtDescuento.MaxLength = 10;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(209, 50);
            this.txtDescuento.TabIndex = 12;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            // 
            // lblTotalIVA
            // 
            this.lblTotalIVA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalIVA.Depth = 0;
            this.lblTotalIVA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalIVA.Location = new System.Drawing.Point(3, 6);
            this.lblTotalIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalIVA.Name = "lblTotalIVA";
            this.lblTotalIVA.Size = new System.Drawing.Size(100, 23);
            this.lblTotalIVA.TabIndex = 13;
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
            this.txtTotalIVA.Location = new System.Drawing.Point(648, 210);
            this.txtTotalIVA.MaxLength = 10;
            this.txtTotalIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalIVA.Multiline = false;
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.Size = new System.Drawing.Size(209, 50);
            this.txtTotalIVA.TabIndex = 14;
            this.txtTotalIVA.Text = "";
            this.txtTotalIVA.TrailingIcon = null;
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalFactura.Depth = 0;
            this.lblTotalFactura.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalFactura.Location = new System.Drawing.Point(3, 420);
            this.lblTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(100, 23);
            this.lblTotalFactura.TabIndex = 15;
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
            this.txtTotalFactura.Location = new System.Drawing.Point(218, 377);
            this.txtTotalFactura.MaxLength = 10;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalFactura.Multiline = false;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(209, 50);
            this.txtTotalFactura.TabIndex = 16;
            this.txtTotalFactura.Text = "";
            this.txtTotalFactura.TrailingIcon = null;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(47, 22);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(4, 22);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 4;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.Controls.Add(this.txtNroFactura, 0, 1);
            this.tlpPrincipal.Controls.Add(this.dtpFecha, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cmbEstado, 2, 1);
            this.tlpPrincipal.Controls.Add(this.cmbCliente, 0, 3);
            this.tlpPrincipal.Controls.Add(this.cmbEmpleado, 1, 3);
            this.tlpPrincipal.Controls.Add(this.txtDescuento, 2, 3);
            this.tlpPrincipal.Controls.Add(this.txtTotalIVA, 3, 3);
            this.tlpPrincipal.Controls.Add(this.txtTotalFactura, 1, 4);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 3, 4);
            this.tlpPrincipal.Controls.Add(this.dgvProductos, 0, 6);
            this.tlpPrincipal.Controls.Add(this.lblProductos, 0, 5);
            this.tlpPrincipal.Controls.Add(this.lblTotalFactura, 0, 4);
            this.tlpPrincipal.Controls.Add(this.panel1, 2, 4);
            this.tlpPrincipal.Controls.Add(this.panel2, 2, 0);
            this.tlpPrincipal.Controls.Add(this.panel3, 1, 0);
            this.tlpPrincipal.Controls.Add(this.panel4, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panel7, 2, 2);
            this.tlpPrincipal.Controls.Add(this.panel8, 3, 2);
            this.tlpPrincipal.Controls.Add(this.panel5, 1, 2);
            this.tlpPrincipal.Controls.Add(this.panel6, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(860, 576);
            this.tlpPrincipal.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(648, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 78);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeight = 34;
            this.tlpPrincipal.SetColumnSpan(this.dgvProductos, 4);
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 571);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.Size = new System.Drawing.Size(854, 2);
            this.dgvProductos.TabIndex = 20;
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpPrincipal.SetColumnSpan(this.lblProductos, 4);
            this.lblProductos.Depth = 0;
            this.lblProductos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductos.Location = new System.Drawing.Point(3, 517);
            this.lblProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(100, 23);
            this.lblProductos.TabIndex = 18;
            this.lblProductos.Text = "Productos Facturados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Location = new System.Drawing.Point(433, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 78);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Location = new System.Drawing.Point(433, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 34);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Location = new System.Drawing.Point(218, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 34);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblNroFactura);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 34);
            this.panel4.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel7.Controls.Add(this.lblDescuento);
            this.panel7.Location = new System.Drawing.Point(433, 147);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 38);
            this.panel7.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel8.Controls.Add(this.lblTotalIVA);
            this.panel8.Location = new System.Drawing.Point(648, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(126, 32);
            this.panel8.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.Controls.Add(this.lblCliente);
            this.panel5.Location = new System.Drawing.Point(218, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 33);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.Controls.Add(this.lblEmpleado);
            this.panel6.Location = new System.Drawing.Point(3, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 35);
            this.panel6.TabIndex = 26;
            // 
            // ucFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ucFacturacion";
            this.Size = new System.Drawing.Size(860, 600);
            this.Load += new System.EventHandler(this.ucFacturacion_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitulo;
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
        private MaterialButton btnActualizar;
        private MaterialButton btnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialLabel lblProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}
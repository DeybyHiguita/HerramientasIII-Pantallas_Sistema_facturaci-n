using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Facturacion.UserControls
{
    partial class ucInforme
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
            this.lblTipoInforme = new MaterialSkin.Controls.MaterialLabel();
            this.cmbInforme = new MaterialSkin.Controls.MaterialComboBox();
            this.lblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbOrdenarPor = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFormato = new MaterialSkin.Controls.MaterialLabel();
            this.rbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.tlpTipoInforme = new System.Windows.Forms.TableLayoutPanel();
            this.tlpOrdenarPor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFechaInicio = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFechaFinal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFormatos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTipoInforme.SuspendLayout();
            this.tlpOrdenarPor.SuspendLayout();
            this.tlpFechaInicio.SuspendLayout();
            this.tlpFechaFinal.SuspendLayout();
            this.tlpFormatos.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(247, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GENERADOR DE INFORMES";
            // 
            // lblTipoInforme
            // 
            this.lblTipoInforme.AutoSize = true;
            this.lblTipoInforme.Depth = 0;
            this.lblTipoInforme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipoInforme.Location = new System.Drawing.Point(3, 0);
            this.lblTipoInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoInforme.Name = "lblTipoInforme";
            this.lblTipoInforme.Size = new System.Drawing.Size(92, 19);
            this.lblTipoInforme.TabIndex = 0;
            this.lblTipoInforme.Text = "Tipo Informe";
            // 
            // cmbInforme
            // 
            this.cmbInforme.AutoResize = false;
            this.cmbInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbInforme.Depth = 0;
            this.cmbInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInforme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbInforme.DropDownHeight = 174;
            this.cmbInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInforme.DropDownWidth = 121;
            this.cmbInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInforme.FormattingEnabled = true;
            this.cmbInforme.IntegralHeight = false;
            this.cmbInforme.ItemHeight = 43;
            this.cmbInforme.Location = new System.Drawing.Point(3, 32);
            this.cmbInforme.MaxDropDownItems = 4;
            this.cmbInforme.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInforme.Name = "cmbInforme";
            this.cmbInforme.Size = new System.Drawing.Size(238, 49);
            this.cmbInforme.StartIndex = 0;
            this.cmbInforme.TabIndex = 1;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Depth = 0;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrdenarPor.Location = new System.Drawing.Point(3, 0);
            this.lblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(84, 19);
            this.lblOrdenarPor.TabIndex = 0;
            this.lblOrdenarPor.Text = "Ordenar por";
            // 
            // cmbOrdenarPor
            // 
            this.cmbOrdenarPor.AutoResize = false;
            this.cmbOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrdenarPor.Depth = 0;
            this.cmbOrdenarPor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbOrdenarPor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrdenarPor.DropDownHeight = 174;
            this.cmbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenarPor.DropDownWidth = 121;
            this.cmbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrdenarPor.FormattingEnabled = true;
            this.cmbOrdenarPor.IntegralHeight = false;
            this.cmbOrdenarPor.ItemHeight = 43;
            this.cmbOrdenarPor.Location = new System.Drawing.Point(3, 32);
            this.cmbOrdenarPor.MaxDropDownItems = 4;
            this.cmbOrdenarPor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(239, 49);
            this.cmbOrdenarPor.StartIndex = 0;
            this.cmbOrdenarPor.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 0);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 19);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BackColor = System.Drawing.Color.White;
            this.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(3, 32);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(238, 26);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaFinal.Location = new System.Drawing.Point(3, 0);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(83, 19);
            this.lblFechaFinal.TabIndex = 0;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.BackColor = System.Drawing.Color.White;
            this.dtpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(3, 32);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(239, 26);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Depth = 0;
            this.lblFormato.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFormato.Location = new System.Drawing.Point(3, 0);
            this.lblFormato.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(61, 19);
            this.lblFormato.TabIndex = 0;
            this.lblFormato.Text = "Formato";
            // 
            // rbEnPantalla
            // 
            this.rbEnPantalla.AutoSize = true;
            this.rbEnPantalla.Depth = 0;
            this.rbEnPantalla.Location = new System.Drawing.Point(0, 29);
            this.rbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEnPantalla.Name = "rbEnPantalla";
            this.rbEnPantalla.Ripple = true;
            this.rbEnPantalla.Size = new System.Drawing.Size(116, 37);
            this.rbEnPantalla.TabIndex = 1;
            this.rbEnPantalla.Text = "En Pantalla";
            this.rbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Depth = 0;
            this.rbPdf.Location = new System.Drawing.Point(164, 29);
            this.rbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Ripple = true;
            this.rbPdf.Size = new System.Drawing.Size(65, 37);
            this.rbPdf.TabIndex = 2;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Depth = 0;
            this.rbExcel.Location = new System.Drawing.Point(328, 29);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Ripple = true;
            this.rbExcel.Size = new System.Drawing.Size(72, 37);
            this.rbExcel.TabIndex = 3;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerar.Depth = 0;
            this.btnGenerar.HighEmphasis = true;
            this.btnGenerar.Icon = null;
            this.btnGenerar.Location = new System.Drawing.Point(4, 19);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerar.Size = new System.Drawing.Size(239, 36);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "GENERAR INFORME";
            this.btnGenerar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerar.UseAccentColor = false;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(251, 19);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(240, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tlpTipoInforme
            // 
            this.tlpTipoInforme.ColumnCount = 1;
            this.tlpTipoInforme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTipoInforme.Controls.Add(this.lblTipoInforme, 0, 0);
            this.tlpTipoInforme.Controls.Add(this.cmbInforme, 0, 1);
            this.tlpTipoInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTipoInforme.Location = new System.Drawing.Point(3, 3);
            this.tlpTipoInforme.Name = "tlpTipoInforme";
            this.tlpTipoInforme.RowCount = 2;
            this.tlpTipoInforme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTipoInforme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTipoInforme.Size = new System.Drawing.Size(244, 112);
            this.tlpTipoInforme.TabIndex = 2;
            // 
            // tlpOrdenarPor
            // 
            this.tlpOrdenarPor.ColumnCount = 1;
            this.tlpOrdenarPor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdenarPor.Controls.Add(this.lblOrdenarPor, 0, 0);
            this.tlpOrdenarPor.Controls.Add(this.cmbOrdenarPor, 0, 1);
            this.tlpOrdenarPor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrdenarPor.Location = new System.Drawing.Point(253, 3);
            this.tlpOrdenarPor.Name = "tlpOrdenarPor";
            this.tlpOrdenarPor.RowCount = 2;
            this.tlpOrdenarPor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpOrdenarPor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdenarPor.Size = new System.Drawing.Size(245, 112);
            this.tlpOrdenarPor.TabIndex = 3;
            // 
            // tlpFechaInicio
            // 
            this.tlpFechaInicio.ColumnCount = 1;
            this.tlpFechaInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFechaInicio.Controls.Add(this.lblFechaInicio, 0, 0);
            this.tlpFechaInicio.Controls.Add(this.dtpFechaInicio, 0, 1);
            this.tlpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFechaInicio.Location = new System.Drawing.Point(3, 121);
            this.tlpFechaInicio.Name = "tlpFechaInicio";
            this.tlpFechaInicio.RowCount = 2;
            this.tlpFechaInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFechaInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFechaInicio.Size = new System.Drawing.Size(244, 112);
            this.tlpFechaInicio.TabIndex = 4;
            // 
            // tlpFechaFinal
            // 
            this.tlpFechaFinal.ColumnCount = 1;
            this.tlpFechaFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFechaFinal.Controls.Add(this.lblFechaFinal, 0, 0);
            this.tlpFechaFinal.Controls.Add(this.dtpFechaFinal, 0, 1);
            this.tlpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFechaFinal.Location = new System.Drawing.Point(253, 121);
            this.tlpFechaFinal.Name = "tlpFechaFinal";
            this.tlpFechaFinal.RowCount = 2;
            this.tlpFechaFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFechaFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFechaFinal.Size = new System.Drawing.Size(245, 112);
            this.tlpFechaFinal.TabIndex = 5;
            // 
            // tlpFormatos
            // 
            this.tlpFormatos.ColumnCount = 3;
            this.tlpPrincipal.SetColumnSpan(this.tlpFormatos, 2);
            this.tlpFormatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpFormatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpFormatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpFormatos.Controls.Add(this.lblFormato, 0, 0);
            this.tlpFormatos.Controls.Add(this.rbEnPantalla, 0, 1);
            this.tlpFormatos.Controls.Add(this.rbPdf, 1, 1);
            this.tlpFormatos.Controls.Add(this.rbExcel, 2, 1);
            this.tlpFormatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormatos.Location = new System.Drawing.Point(3, 239);
            this.tlpFormatos.Name = "tlpFormatos";
            this.tlpFormatos.RowCount = 2;
            this.tlpFormatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFormatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormatos.Size = new System.Drawing.Size(495, 112);
            this.tlpFormatos.TabIndex = 6;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 0, 3);
            this.tlpPrincipal.Controls.Add(this.tlpTipoInforme, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpOrdenarPor, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tlpFechaInicio, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpFechaFinal, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpFormatos, 0, 2);
            this.tlpPrincipal.Location = new System.Drawing.Point(30, 94);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.Size = new System.Drawing.Size(501, 435);
            this.tlpPrincipal.TabIndex = 10;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpBotones, 2);
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalir, 1, 0);
            this.tlpBotones.Controls.Add(this.btnGenerar, 0, 0);
            this.tlpBotones.Location = new System.Drawing.Point(3, 357);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(495, 75);
            this.tlpBotones.TabIndex = 13;
            // 
            // ucInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ucInforme";
            this.Size = new System.Drawing.Size(570, 569);
            this.tlpTipoInforme.ResumeLayout(false);
            this.tlpTipoInforme.PerformLayout();
            this.tlpOrdenarPor.ResumeLayout(false);
            this.tlpOrdenarPor.PerformLayout();
            this.tlpFechaInicio.ResumeLayout(false);
            this.tlpFechaInicio.PerformLayout();
            this.tlpFechaFinal.ResumeLayout(false);
            this.tlpFechaFinal.PerformLayout();
            this.tlpFormatos.ResumeLayout(false);
            this.tlpFormatos.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitulo;
        private MaterialLabel lblTipoInforme;
        private MaterialComboBox cmbInforme;
        private MaterialLabel lblOrdenarPor;
        private MaterialComboBox cmbOrdenarPor;
        private MaterialLabel lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private MaterialLabel lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private MaterialLabel lblFormato;
        private MaterialRadioButton rbEnPantalla;
        private MaterialRadioButton rbPdf;
        private MaterialRadioButton rbExcel;
        private MaterialButton btnGenerar;
        private MaterialButton btnSalir;

        // TableLayoutPanels
        private System.Windows.Forms.TableLayoutPanel tlpTipoInforme;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenarPor;
        private System.Windows.Forms.TableLayoutPanel tlpFechaInicio;
        private System.Windows.Forms.TableLayoutPanel tlpFechaFinal;
        private System.Windows.Forms.TableLayoutPanel tlpFormatos;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
    }
}
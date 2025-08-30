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
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.cmbInforme = new MaterialSkin.Controls.MaterialComboBox();
            this.lblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbOrdenarPor = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.grpFormato = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialButton();
            this.grpFormato.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblTitulo, 2);
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitulo.Location = new System.Drawing.Point(4, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(862, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(3, 54);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(165, 19);
            this.lblSeleccioneInforme.TabIndex = 1;
            this.lblSeleccioneInforme.Text = "SELECCIONE INFORME";
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
            this.cmbInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInforme.FormattingEnabled = true;
            this.cmbInforme.IntegralHeight = false;
            this.cmbInforme.ItemHeight = 43;
            this.cmbInforme.Location = new System.Drawing.Point(3, 83);
            this.cmbInforme.MaxDropDownItems = 4;
            this.cmbInforme.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInforme.Name = "cmbInforme";
            this.cmbInforme.Size = new System.Drawing.Size(429, 49);
            this.cmbInforme.StartIndex = 0;
            this.cmbInforme.TabIndex = 1;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Depth = 0;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrdenarPor.Location = new System.Drawing.Point(438, 54);
            this.lblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(88, 19);
            this.lblOrdenarPor.TabIndex = 2;
            this.lblOrdenarPor.Text = "Ordenar por:";
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
            this.cmbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrdenarPor.FormattingEnabled = true;
            this.cmbOrdenarPor.IntegralHeight = false;
            this.cmbOrdenarPor.ItemHeight = 43;
            this.cmbOrdenarPor.Location = new System.Drawing.Point(438, 83);
            this.cmbOrdenarPor.MaxDropDownItems = 4;
            this.cmbOrdenarPor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(429, 49);
            this.cmbOrdenarPor.StartIndex = 0;
            this.cmbOrdenarPor.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 8);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 19);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(3, 190);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(429, 26);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaFinal.Location = new System.Drawing.Point(0, 9);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(83, 19);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Final";
            this.lblFechaFinal.Click += new System.EventHandler(this.lblFechaFinal_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(438, 190);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(429, 26);
            this.dtpFechaFinal.TabIndex = 4;
            // 
            // grpFormato
            // 
            this.tlpPrincipal.SetColumnSpan(this.grpFormato, 2);
            this.grpFormato.Controls.Add(this.panel5);
            this.grpFormato.Controls.Add(this.panel4);
            this.grpFormato.Controls.Add(this.panel3);
            this.grpFormato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpFormato.Location = new System.Drawing.Point(3, 261);
            this.grpFormato.Name = "grpFormato";
            this.grpFormato.Size = new System.Drawing.Size(864, 143);
            this.grpFormato.TabIndex = 5;
            this.grpFormato.TabStop = false;
            this.grpFormato.Text = "Formato de informe";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbExcel);
            this.panel5.Location = new System.Drawing.Point(587, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 61);
            this.panel5.TabIndex = 12;
            // 
            // rbExcel
            // 
            this.rbExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbExcel.AutoSize = true;
            this.rbExcel.Depth = 0;
            this.rbExcel.Location = new System.Drawing.Point(10, 15);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Ripple = true;
            this.rbExcel.Size = new System.Drawing.Size(72, 37);
            this.rbExcel.TabIndex = 8;
            this.rbExcel.Text = "Excel";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbPdf);
            this.panel4.Location = new System.Drawing.Point(318, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 55);
            this.panel4.TabIndex = 12;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Depth = 0;
            this.rbPdf.Location = new System.Drawing.Point(14, 8);
            this.rbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Ripple = true;
            this.rbPdf.Size = new System.Drawing.Size(60, 37);
            this.rbPdf.TabIndex = 7;
            this.rbPdf.Text = "Pdf";
            this.rbPdf.CheckedChanged += new System.EventHandler(this.rbPdf_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbEnPantalla);
            this.panel3.Location = new System.Drawing.Point(36, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 12;
            // 
            // rbEnPantalla
            // 
            this.rbEnPantalla.AutoSize = true;
            this.rbEnPantalla.Depth = 0;
            this.rbEnPantalla.Location = new System.Drawing.Point(15, 8);
            this.rbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEnPantalla.Name = "rbEnPantalla";
            this.rbEnPantalla.Ripple = true;
            this.rbEnPantalla.Size = new System.Drawing.Size(116, 37);
            this.rbEnPantalla.TabIndex = 6;
            this.rbEnPantalla.Text = "En Pantalla";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.panel7, 1, 3);
            this.tlpPrincipal.Controls.Add(this.panel6, 0, 3);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.cmbInforme, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblOrdenarPor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cmbOrdenarPor, 1, 2);
            this.tlpPrincipal.Controls.Add(this.dtpFechaInicio, 0, 4);
            this.tlpPrincipal.Controls.Add(this.dtpFechaFinal, 1, 4);
            this.tlpPrincipal.Controls.Add(this.grpFormato, 0, 5);
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 0, 6);
            this.tlpPrincipal.Controls.Add(this.lblSeleccioneInforme, 0, 1);
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrincipal.Size = new System.Drawing.Size(870, 484);
            this.tlpPrincipal.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblFechaFinal);
            this.panel7.Location = new System.Drawing.Point(438, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 39);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblFechaInicio);
            this.panel6.Location = new System.Drawing.Point(3, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 39);
            this.panel6.TabIndex = 13;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpBotones, 2);
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.panel2, 1, 0);
            this.tlpBotones.Controls.Add(this.panel1, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(3, 410);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.Size = new System.Drawing.Size(864, 71);
            this.tlpBotones.TabIndex = 11;
            this.tlpBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBotones_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Location = new System.Drawing.Point(435, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 36);
            this.panel2.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(200, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarInforme);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 11;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerarInforme.HighEmphasis = true;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarInforme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarInforme.Size = new System.Drawing.Size(200, 36);
            this.btnGenerarInforme.TabIndex = 10;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarInforme.UseAccentColor = false;
            this.btnGenerarInforme.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ucInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "ucInforme";
            this.Size = new System.Drawing.Size(870, 420);
            this.grpFormato.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialLabel lblTitulo;
        private MaterialLabel lblSeleccioneInforme;
        private MaterialComboBox cmbInforme;
        private MaterialLabel lblOrdenarPor;
        private MaterialComboBox cmbOrdenarPor;
        private MaterialLabel lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private MaterialLabel lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.GroupBox grpFormato;
        private MaterialRadioButton rbEnPantalla;
        private MaterialRadioButton rbPdf;
        private MaterialRadioButton rbExcel;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Panel panel2;
        private MaterialButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private MaterialButton btnGenerarInforme;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}
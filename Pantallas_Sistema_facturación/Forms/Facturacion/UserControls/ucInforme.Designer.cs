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
            this.rbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.grpFormato.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
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
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(3, 35);
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
            this.cmbInforme.Location = new System.Drawing.Point(3, 59);
            this.cmbInforme.MaxDropDownItems = 4;
            this.cmbInforme.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInforme.Name = "cmbInforme";
            this.cmbInforme.Size = new System.Drawing.Size(429, 49);
            this.cmbInforme.StartIndex = 0;
            this.cmbInforme.TabIndex = 1;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Depth = 0;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrdenarPor.Location = new System.Drawing.Point(438, 35);
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
            this.cmbOrdenarPor.Location = new System.Drawing.Point(438, 59);
            this.cmbOrdenarPor.MaxDropDownItems = 4;
            this.cmbOrdenarPor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(429, 49);
            this.cmbOrdenarPor.StartIndex = 0;
            this.cmbOrdenarPor.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 105);
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(3, 162);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(429, 26);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaFinal.Location = new System.Drawing.Point(438, 105);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(83, 19);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(438, 162);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(429, 26);
            this.dtpFechaFinal.TabIndex = 4;
            // 
            // grpFormato
            // 
            this.tlpPrincipal.SetColumnSpan(this.grpFormato, 2);
            this.grpFormato.Controls.Add(this.rbEnPantalla);
            this.grpFormato.Controls.Add(this.rbPdf);
            this.grpFormato.Controls.Add(this.rbExcel);
            this.grpFormato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpFormato.Location = new System.Drawing.Point(3, 228);
            this.grpFormato.Name = "grpFormato";
            this.grpFormato.Size = new System.Drawing.Size(864, 66);
            this.grpFormato.TabIndex = 5;
            this.grpFormato.TabStop = false;
            this.grpFormato.Text = "Formato de informe";
            // 
            // rbEnPantalla
            // 
            this.rbEnPantalla.AutoSize = true;
            this.rbEnPantalla.Depth = 0;
            this.rbEnPantalla.Location = new System.Drawing.Point(10, 22);
            this.rbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEnPantalla.Name = "rbEnPantalla";
            this.rbEnPantalla.Ripple = true;
            this.rbEnPantalla.Size = new System.Drawing.Size(116, 37);
            this.rbEnPantalla.TabIndex = 6;
            this.rbEnPantalla.Text = "En Pantalla";
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Depth = 0;
            this.rbPdf.Location = new System.Drawing.Point(100, 22);
            this.rbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Ripple = true;
            this.rbPdf.Size = new System.Drawing.Size(60, 37);
            this.rbPdf.TabIndex = 7;
            this.rbPdf.Text = "Pdf";
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Depth = 0;
            this.rbExcel.Location = new System.Drawing.Point(170, 22);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Ripple = true;
            this.rbExcel.Size = new System.Drawing.Size(72, 37);
            this.rbExcel.TabIndex = 8;
            this.rbExcel.Text = "Excel";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerarInforme.HighEmphasis = true;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(4, 6);
            this.btnGenerarInforme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarInforme.Size = new System.Drawing.Size(424, 105);
            this.btnGenerarInforme.TabIndex = 9;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarInforme.UseAccentColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(436, 6);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(424, 105);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblSeleccioneInforme, 0, 1);
            this.tlpPrincipal.Controls.Add(this.cmbInforme, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblOrdenarPor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cmbOrdenarPor, 1, 2);
            this.tlpPrincipal.Controls.Add(this.dtpFechaInicio, 0, 4);
            this.tlpPrincipal.Controls.Add(this.dtpFechaFinal, 1, 4);
            this.tlpPrincipal.Controls.Add(this.grpFormato, 0, 5);
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 0, 6);
            this.tlpPrincipal.Controls.Add(this.lblFechaFinal, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblFechaInicio, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrincipal.Size = new System.Drawing.Size(870, 420);
            this.tlpPrincipal.TabIndex = 12;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpBotones, 2);
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnGenerarInforme, 0, 0);
            this.tlpBotones.Controls.Add(this.btnSalir, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(3, 300);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(864, 117);
            this.tlpBotones.TabIndex = 11;
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
            this.grpFormato.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
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
        private MaterialButton btnGenerarInforme;
        private MaterialButton btnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
    }
}
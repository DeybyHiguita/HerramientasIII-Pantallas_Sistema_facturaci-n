namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    partial class ucCliente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpNombreProducto = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpCodigoReferencia = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoReferencia = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoReferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpPrecioCompra = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioCompra = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpPrecioVenta = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioVenta = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpNombreProducto.SuspendLayout();
            this.tlpCodigoReferencia.SuspendLayout();
            this.tlpPrecioCompra.SuspendLayout();
            this.tlpPrecioVenta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(291, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpNombreProducto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpCodigoReferencia, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tlpPrecioCompra, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpPrecioVenta, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 1, 4);
            this.tlpPrincipal.Location = new System.Drawing.Point(38, 89);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.Size = new System.Drawing.Size(750, 408);
            this.tlpPrincipal.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialTextBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 74);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Correo electronico";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(3, 28);
            this.materialTextBox1.MaxLength = 10;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(363, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // tlpNombreProducto
            // 
            this.tlpNombreProducto.ColumnCount = 1;
            this.tlpNombreProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Controls.Add(this.lblNombreProducto, 0, 0);
            this.tlpNombreProducto.Controls.Add(this.txtNombreProducto, 0, 1);
            this.tlpNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNombreProducto.Location = new System.Drawing.Point(3, 3);
            this.tlpNombreProducto.Name = "tlpNombreProducto";
            this.tlpNombreProducto.RowCount = 2;
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Size = new System.Drawing.Size(369, 74);
            this.tlpNombreProducto.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Depth = 0;
            this.lblNombreProducto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreProducto.Location = new System.Drawing.Point(3, 0);
            this.lblNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(109, 19);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Cliente";
            this.lblNombreProducto.Click += new System.EventHandler(this.lblNombreProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AnimateReadOnly = false;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProducto.LeadingIcon = null;
            this.txtNombreProducto.Location = new System.Drawing.Point(3, 28);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(363, 50);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.Text = "";
            this.txtNombreProducto.TrailingIcon = null;
            // 
            // tlpCodigoReferencia
            // 
            this.tlpCodigoReferencia.ColumnCount = 1;
            this.tlpCodigoReferencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Controls.Add(this.lblCodigoReferencia, 0, 0);
            this.tlpCodigoReferencia.Controls.Add(this.txtCodigoReferencia, 0, 1);
            this.tlpCodigoReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCodigoReferencia.Location = new System.Drawing.Point(378, 3);
            this.tlpCodigoReferencia.Name = "tlpCodigoReferencia";
            this.tlpCodigoReferencia.RowCount = 2;
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Size = new System.Drawing.Size(369, 74);
            this.tlpCodigoReferencia.TabIndex = 3;
            // 
            // lblCodigoReferencia
            // 
            this.lblCodigoReferencia.AutoSize = true;
            this.lblCodigoReferencia.Depth = 0;
            this.lblCodigoReferencia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoReferencia.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoReferencia.Name = "lblCodigoReferencia";
            this.lblCodigoReferencia.Size = new System.Drawing.Size(83, 19);
            this.lblCodigoReferencia.TabIndex = 0;
            this.lblCodigoReferencia.Text = "Documento";
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.AnimateReadOnly = false;
            this.txtCodigoReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoReferencia.Depth = 0;
            this.txtCodigoReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoReferencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoReferencia.LeadingIcon = null;
            this.txtCodigoReferencia.Location = new System.Drawing.Point(3, 28);
            this.txtCodigoReferencia.MaxLength = 50;
            this.txtCodigoReferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoReferencia.Multiline = false;
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.Size = new System.Drawing.Size(363, 50);
            this.txtCodigoReferencia.TabIndex = 1;
            this.txtCodigoReferencia.Text = "";
            this.txtCodigoReferencia.TrailingIcon = null;
            // 
            // tlpPrecioCompra
            // 
            this.tlpPrecioCompra.ColumnCount = 1;
            this.tlpPrecioCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioCompra.Controls.Add(this.lblPrecioCompra, 0, 0);
            this.tlpPrecioCompra.Controls.Add(this.txtPrecioCompra, 0, 1);
            this.tlpPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrecioCompra.Location = new System.Drawing.Point(3, 83);
            this.tlpPrecioCompra.Name = "tlpPrecioCompra";
            this.tlpPrecioCompra.RowCount = 2;
            this.tlpPrecioCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPrecioCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioCompra.Size = new System.Drawing.Size(369, 74);
            this.tlpPrecioCompra.TabIndex = 4;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Depth = 0;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioCompra.Location = new System.Drawing.Point(3, 0);
            this.lblPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(67, 19);
            this.lblPrecioCompra.TabIndex = 0;
            this.lblPrecioCompra.Text = "Direccion";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.AnimateReadOnly = false;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCompra.LeadingIcon = null;
            this.txtPrecioCompra.Location = new System.Drawing.Point(3, 28);
            this.txtPrecioCompra.MaxLength = 20;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(363, 50);
            this.txtPrecioCompra.TabIndex = 1;
            this.txtPrecioCompra.Text = "";
            this.txtPrecioCompra.TrailingIcon = null;
            // 
            // tlpPrecioVenta
            // 
            this.tlpPrecioVenta.ColumnCount = 1;
            this.tlpPrecioVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioVenta.Controls.Add(this.lblPrecioVenta, 0, 0);
            this.tlpPrecioVenta.Controls.Add(this.txtPrecioVenta, 0, 1);
            this.tlpPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrecioVenta.Location = new System.Drawing.Point(378, 83);
            this.tlpPrecioVenta.Name = "tlpPrecioVenta";
            this.tlpPrecioVenta.RowCount = 2;
            this.tlpPrecioVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPrecioVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioVenta.Size = new System.Drawing.Size(369, 74);
            this.tlpPrecioVenta.TabIndex = 5;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Depth = 0;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioVenta.Location = new System.Drawing.Point(3, 0);
            this.lblPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(64, 19);
            this.lblPrecioVenta.TabIndex = 0;
            this.lblPrecioVenta.Text = "Telefono";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AnimateReadOnly = false;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioVenta.LeadingIcon = null;
            this.txtPrecioVenta.Location = new System.Drawing.Point(3, 28);
            this.txtPrecioVenta.MaxLength = 20;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(363, 50);
            this.txtPrecioVenta.TabIndex = 1;
            this.txtPrecioVenta.Text = "";
            this.txtPrecioVenta.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(378, 323);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 82);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(188, 23);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(177, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(4, 23);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(176, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ucCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCliente";
            this.Size = new System.Drawing.Size(825, 538);
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpNombreProducto.ResumeLayout(false);
            this.tlpNombreProducto.PerformLayout();
            this.tlpCodigoReferencia.ResumeLayout(false);
            this.tlpCodigoReferencia.PerformLayout();
            this.tlpPrecioCompra.ResumeLayout(false);
            this.tlpPrecioCompra.PerformLayout();
            this.tlpPrecioVenta.ResumeLayout(false);
            this.tlpPrecioVenta.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private System.Windows.Forms.TableLayoutPanel tlpNombreProducto;
        private MaterialSkin.Controls.MaterialLabel lblNombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txtNombreProducto;
        private System.Windows.Forms.TableLayoutPanel tlpCodigoReferencia;
        private MaterialSkin.Controls.MaterialLabel lblCodigoReferencia;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoReferencia;
        private System.Windows.Forms.TableLayoutPanel tlpPrecioCompra;
        private MaterialSkin.Controls.MaterialLabel lblPrecioCompra;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompra;
        private System.Windows.Forms.TableLayoutPanel tlpPrecioVenta;
        private MaterialSkin.Controls.MaterialLabel lblPrecioVenta;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}

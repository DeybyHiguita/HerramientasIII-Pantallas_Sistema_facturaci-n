namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    partial class ucCategoriasProductos
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
            this.tlpNombreProducto = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpCodigoReferencia = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoReferencia = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombrecategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal.SuspendLayout();
            this.tlpNombreProducto.SuspendLayout();
            this.tlpCodigoReferencia.SuspendLayout();
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
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CATEGORIAS DE PRODUCTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.Controls.Add(this.tlpNombreProducto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpCodigoReferencia, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 1, 4);
            this.tlpPrincipal.Location = new System.Drawing.Point(22, 40);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.Size = new System.Drawing.Size(500, 265);
            this.tlpPrincipal.TabIndex = 12;
            // 
            // tlpNombreProducto
            // 
            this.tlpNombreProducto.ColumnCount = 1;
            this.tlpNombreProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Controls.Add(this.lblNombreProducto, 0, 0);
            this.tlpNombreProducto.Controls.Add(this.txtId, 0, 1);
            this.tlpNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNombreProducto.Location = new System.Drawing.Point(2, 2);
            this.tlpNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.tlpNombreProducto.Name = "tlpNombreProducto";
            this.tlpNombreProducto.RowCount = 2;
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Size = new System.Drawing.Size(245, 48);
            this.tlpNombreProducto.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Depth = 0;
            this.lblNombreProducto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreProducto.Location = new System.Drawing.Point(2, 0);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(14, 16);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(2, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaxLength = 100;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(241, 50);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            // 
            // tlpCodigoReferencia
            // 
            this.tlpCodigoReferencia.ColumnCount = 1;
            this.tlpCodigoReferencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Controls.Add(this.lblCodigoReferencia, 0, 0);
            this.tlpCodigoReferencia.Controls.Add(this.txtNombrecategoria, 0, 1);
            this.tlpCodigoReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCodigoReferencia.Location = new System.Drawing.Point(251, 2);
            this.tlpCodigoReferencia.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCodigoReferencia.Name = "tlpCodigoReferencia";
            this.tlpCodigoReferencia.RowCount = 2;
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Size = new System.Drawing.Size(247, 48);
            this.tlpCodigoReferencia.TabIndex = 3;
            // 
            // lblCodigoReferencia
            // 
            this.lblCodigoReferencia.AutoSize = true;
            this.lblCodigoReferencia.Depth = 0;
            this.lblCodigoReferencia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoReferencia.Location = new System.Drawing.Point(2, 0);
            this.lblCodigoReferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoReferencia.Name = "lblCodigoReferencia";
            this.lblCodigoReferencia.Size = new System.Drawing.Size(129, 16);
            this.lblCodigoReferencia.TabIndex = 0;
            this.lblCodigoReferencia.Text = "Nombre Categoria";
            // 
            // txtNombrecategoria
            // 
            this.txtNombrecategoria.AnimateReadOnly = false;
            this.txtNombrecategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrecategoria.Depth = 0;
            this.txtNombrecategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombrecategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombrecategoria.LeadingIcon = null;
            this.txtNombrecategoria.Location = new System.Drawing.Point(2, 18);
            this.txtNombrecategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrecategoria.MaxLength = 50;
            this.txtNombrecategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombrecategoria.Multiline = false;
            this.txtNombrecategoria.Name = "txtNombrecategoria";
            this.txtNombrecategoria.Size = new System.Drawing.Size(243, 50);
            this.txtNombrecategoria.TabIndex = 1;
            this.txtNombrecategoria.Text = "";
            this.txtNombrecategoria.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(251, 210);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 53);
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
            this.btnSalir.Location = new System.Drawing.Point(126, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(118, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(3, 8);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(117, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // ucCategoriasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ucCategoriasProductos";
            this.Size = new System.Drawing.Size(555, 364);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpNombreProducto.ResumeLayout(false);
            this.tlpNombreProducto.PerformLayout();
            this.tlpCodigoReferencia.ResumeLayout(false);
            this.tlpCodigoReferencia.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpNombreProducto;
        private MaterialSkin.Controls.MaterialLabel lblNombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private System.Windows.Forms.TableLayoutPanel tlpCodigoReferencia;
        private MaterialSkin.Controls.MaterialLabel lblCodigoReferencia;
        private MaterialSkin.Controls.MaterialTextBox txtNombrecategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
    }
}

using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    partial class ucProducto
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
            this.lblNombreProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCodigoReferencia = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoReferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrecioCompra = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrecioVenta = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCantidadStock = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.lblRutaImagen = new MaterialSkin.Controls.MaterialLabel();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSeleccionarImagen = new MaterialSkin.Controls.MaterialButton();
            this.lblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtDetallesProducto = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.tlpNombreProducto = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCodigoReferencia = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrecioCompra = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrecioVenta = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCantidadStock = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRutaImagen = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetallesProducto = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtIdProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridViewListaProductos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNombreProducto.SuspendLayout();
            this.tlpCodigoReferencia.SuspendLayout();
            this.tlpPrecioCompra.SuspendLayout();
            this.tlpPrecioVenta.SuspendLayout();
            this.tlpCantidadStock.SuspendLayout();
            this.tlpCategoria.SuspendLayout();
            this.tlpRutaImagen.SuspendLayout();
            this.tlpDetallesProducto.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProductos)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE PRODUCTOS";
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
            this.lblNombreProducto.Size = new System.Drawing.Size(125, 16);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AnimateReadOnly = false;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProducto.LeadingIcon = null;
            this.txtNombreProducto.Location = new System.Drawing.Point(2, 18);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(156, 50);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.Text = "";
            this.txtNombreProducto.TrailingIcon = null;
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
            this.lblCodigoReferencia.Size = new System.Drawing.Size(130, 16);
            this.lblCodigoReferencia.TabIndex = 0;
            this.lblCodigoReferencia.Text = "Código Referencia";
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.AnimateReadOnly = false;
            this.txtCodigoReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoReferencia.Depth = 0;
            this.txtCodigoReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoReferencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoReferencia.LeadingIcon = null;
            this.txtCodigoReferencia.Location = new System.Drawing.Point(2, 18);
            this.txtCodigoReferencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoReferencia.MaxLength = 50;
            this.txtCodigoReferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoReferencia.Multiline = false;
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.Size = new System.Drawing.Size(156, 50);
            this.txtCodigoReferencia.TabIndex = 1;
            this.txtCodigoReferencia.Text = "";
            this.txtCodigoReferencia.TrailingIcon = null;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Depth = 0;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioCompra.Location = new System.Drawing.Point(2, 0);
            this.lblPrecioCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(105, 16);
            this.lblPrecioCompra.TabIndex = 0;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.AnimateReadOnly = false;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCompra.LeadingIcon = null;
            this.txtPrecioCompra.Location = new System.Drawing.Point(2, 18);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCompra.MaxLength = 20;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(156, 50);
            this.txtPrecioCompra.TabIndex = 1;
            this.txtPrecioCompra.Text = "";
            this.txtPrecioCompra.TrailingIcon = null;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Depth = 0;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioVenta.Location = new System.Drawing.Point(2, 0);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(90, 16);
            this.lblPrecioVenta.TabIndex = 0;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AnimateReadOnly = false;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioVenta.LeadingIcon = null;
            this.txtPrecioVenta.Location = new System.Drawing.Point(2, 18);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVenta.MaxLength = 20;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(156, 50);
            this.txtPrecioVenta.TabIndex = 1;
            this.txtPrecioVenta.Text = "";
            this.txtPrecioVenta.TrailingIcon = null;
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Depth = 0;
            this.lblCantidadStock.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidadStock.Location = new System.Drawing.Point(2, 0);
            this.lblCantidadStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(107, 16);
            this.lblCantidadStock.TabIndex = 0;
            this.lblCantidadStock.Text = "Cantidad stock";
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.AnimateReadOnly = false;
            this.txtCantidadStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantidadStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadStock.LeadingIcon = null;
            this.txtCantidadStock.Location = new System.Drawing.Point(2, 18);
            this.txtCantidadStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadStock.MaxLength = 10;
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadStock.Multiline = false;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(157, 50);
            this.txtCantidadStock.TabIndex = 1;
            this.txtCantidadStock.Text = "";
            this.txtCantidadStock.TrailingIcon = null;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoria.Location = new System.Drawing.Point(2, 0);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoResize = false;
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoria.Depth = 0;
            this.cmbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoria.DropDownHeight = 174;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.DropDownWidth = 121;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.ItemHeight = 43;
            this.cmbCategoria.Location = new System.Drawing.Point(2, 18);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.MaxDropDownItems = 4;
            this.cmbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(157, 49);
            this.cmbCategoria.StartIndex = 0;
            this.cmbCategoria.TabIndex = 1;
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.tlpRutaImagen.SetColumnSpan(this.lblRutaImagen, 2);
            this.lblRutaImagen.Depth = 0;
            this.lblRutaImagen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRutaImagen.Location = new System.Drawing.Point(2, 0);
            this.lblRutaImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(91, 16);
            this.lblRutaImagen.TabIndex = 0;
            this.lblRutaImagen.Text = "Ruta Imagen";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.AnimateReadOnly = false;
            this.txtRutaImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRutaImagen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRutaImagen.LeadingIcon = null;
            this.txtRutaImagen.Location = new System.Drawing.Point(2, 18);
            this.txtRutaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtRutaImagen.MaxLength = 255;
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRutaImagen.Multiline = false;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.ReadOnly = true;
            this.txtRutaImagen.Size = new System.Drawing.Size(387, 50);
            this.txtRutaImagen.TabIndex = 1;
            this.txtRutaImagen.Text = "";
            this.txtRutaImagen.TrailingIcon = null;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionarImagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeleccionarImagen.Depth = 0;
            this.btnSeleccionarImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionarImagen.HighEmphasis = true;
            this.btnSeleccionarImagen.Icon = null;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(394, 20);
            this.btnSeleccionarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeleccionarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(92, 24);
            this.btnSeleccionarImagen.TabIndex = 2;
            this.btnSeleccionarImagen.Text = "EXPLORAR";
            this.btnSeleccionarImagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeleccionarImagen.UseAccentColor = false;
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // lblDetallesProducto
            // 
            this.lblDetallesProducto.AutoSize = true;
            this.lblDetallesProducto.Depth = 0;
            this.lblDetallesProducto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDetallesProducto.Location = new System.Drawing.Point(2, 0);
            this.lblDetallesProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetallesProducto.Name = "lblDetallesProducto";
            this.lblDetallesProducto.Size = new System.Drawing.Size(125, 16);
            this.lblDetallesProducto.TabIndex = 0;
            this.lblDetallesProducto.Text = "Detalles producto";
            // 
            // txtDetallesProducto
            // 
            this.txtDetallesProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDetallesProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetallesProducto.Depth = 0;
            this.txtDetallesProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetallesProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDetallesProducto.Location = new System.Drawing.Point(2, 18);
            this.txtDetallesProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetallesProducto.MaxLength = 500;
            this.txtDetallesProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDetallesProducto.Name = "txtDetallesProducto";
            this.txtDetallesProducto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDetallesProducto.Size = new System.Drawing.Size(485, 91);
            this.txtDetallesProducto.TabIndex = 1;
            this.txtDetallesProducto.TabStop = false;
            this.txtDetallesProducto.Text = "Escribe...";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(83, 4);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(74, 27);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Eliminar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(3, 3);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 1;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // tlpNombreProducto
            // 
            this.tlpNombreProducto.ColumnCount = 1;
            this.tlpNombreProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Controls.Add(this.lblNombreProducto, 0, 0);
            this.tlpNombreProducto.Controls.Add(this.txtNombreProducto, 0, 1);
            this.tlpNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNombreProducto.Location = new System.Drawing.Point(2, 2);
            this.tlpNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.tlpNombreProducto.Name = "tlpNombreProducto";
            this.tlpNombreProducto.RowCount = 2;
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpNombreProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNombreProducto.Size = new System.Drawing.Size(160, 48);
            this.tlpNombreProducto.TabIndex = 2;
            // 
            // tlpCodigoReferencia
            // 
            this.tlpCodigoReferencia.ColumnCount = 1;
            this.tlpCodigoReferencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Controls.Add(this.lblCodigoReferencia, 0, 0);
            this.tlpCodigoReferencia.Controls.Add(this.txtCodigoReferencia, 0, 1);
            this.tlpCodigoReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCodigoReferencia.Location = new System.Drawing.Point(166, 2);
            this.tlpCodigoReferencia.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCodigoReferencia.Name = "tlpCodigoReferencia";
            this.tlpCodigoReferencia.RowCount = 2;
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpCodigoReferencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodigoReferencia.Size = new System.Drawing.Size(160, 48);
            this.tlpCodigoReferencia.TabIndex = 3;
            // 
            // tlpPrecioCompra
            // 
            this.tlpPrecioCompra.ColumnCount = 1;
            this.tlpPrecioCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioCompra.Controls.Add(this.lblPrecioCompra, 0, 0);
            this.tlpPrecioCompra.Controls.Add(this.txtPrecioCompra, 0, 1);
            this.tlpPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrecioCompra.Location = new System.Drawing.Point(2, 54);
            this.tlpPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrecioCompra.Name = "tlpPrecioCompra";
            this.tlpPrecioCompra.RowCount = 2;
            this.tlpPrecioCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrecioCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioCompra.Size = new System.Drawing.Size(160, 48);
            this.tlpPrecioCompra.TabIndex = 4;
            // 
            // tlpPrecioVenta
            // 
            this.tlpPrecioVenta.ColumnCount = 1;
            this.tlpPrecioVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioVenta.Controls.Add(this.lblPrecioVenta, 0, 0);
            this.tlpPrecioVenta.Controls.Add(this.txtPrecioVenta, 0, 1);
            this.tlpPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrecioVenta.Location = new System.Drawing.Point(166, 54);
            this.tlpPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrecioVenta.Name = "tlpPrecioVenta";
            this.tlpPrecioVenta.RowCount = 2;
            this.tlpPrecioVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrecioVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecioVenta.Size = new System.Drawing.Size(160, 48);
            this.tlpPrecioVenta.TabIndex = 5;
            // 
            // tlpCantidadStock
            // 
            this.tlpCantidadStock.ColumnCount = 1;
            this.tlpCantidadStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCantidadStock.Controls.Add(this.lblCantidadStock, 0, 0);
            this.tlpCantidadStock.Controls.Add(this.txtCantidadStock, 0, 1);
            this.tlpCantidadStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCantidadStock.Location = new System.Drawing.Point(330, 54);
            this.tlpCantidadStock.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCantidadStock.Name = "tlpCantidadStock";
            this.tlpCantidadStock.RowCount = 2;
            this.tlpCantidadStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpCantidadStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCantidadStock.Size = new System.Drawing.Size(161, 48);
            this.tlpCantidadStock.TabIndex = 6;
            // 
            // tlpCategoria
            // 
            this.tlpCategoria.ColumnCount = 1;
            this.tlpCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoria.Controls.Add(this.lblCategoria, 0, 0);
            this.tlpCategoria.Controls.Add(this.cmbCategoria, 0, 1);
            this.tlpCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCategoria.Location = new System.Drawing.Point(330, 2);
            this.tlpCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCategoria.Name = "tlpCategoria";
            this.tlpCategoria.RowCount = 2;
            this.tlpCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoria.Size = new System.Drawing.Size(161, 48);
            this.tlpCategoria.TabIndex = 7;
            // 
            // tlpRutaImagen
            // 
            this.tlpRutaImagen.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpRutaImagen, 3);
            this.tlpRutaImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpRutaImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRutaImagen.Controls.Add(this.lblRutaImagen, 0, 0);
            this.tlpRutaImagen.Controls.Add(this.txtRutaImagen, 0, 1);
            this.tlpRutaImagen.Controls.Add(this.btnSeleccionarImagen, 1, 1);
            this.tlpRutaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRutaImagen.Location = new System.Drawing.Point(2, 106);
            this.tlpRutaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.tlpRutaImagen.Name = "tlpRutaImagen";
            this.tlpRutaImagen.RowCount = 2;
            this.tlpRutaImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpRutaImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRutaImagen.Size = new System.Drawing.Size(489, 48);
            this.tlpRutaImagen.TabIndex = 8;
            // 
            // tlpDetallesProducto
            // 
            this.tlpDetallesProducto.ColumnCount = 1;
            this.tlpPrincipal.SetColumnSpan(this.tlpDetallesProducto, 3);
            this.tlpDetallesProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetallesProducto.Controls.Add(this.lblDetallesProducto, 0, 0);
            this.tlpDetallesProducto.Controls.Add(this.txtDetallesProducto, 0, 1);
            this.tlpDetallesProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetallesProducto.Location = new System.Drawing.Point(2, 158);
            this.tlpDetallesProducto.Margin = new System.Windows.Forms.Padding(2);
            this.tlpDetallesProducto.Name = "tlpDetallesProducto";
            this.tlpDetallesProducto.RowCount = 2;
            this.tlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetallesProducto.Size = new System.Drawing.Size(489, 111);
            this.tlpDetallesProducto.TabIndex = 9;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel3, 2, 4);
            this.tlpPrincipal.Controls.Add(this.tlpNombreProducto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpCodigoReferencia, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tlpCategoria, 2, 0);
            this.tlpPrincipal.Controls.Add(this.tlpPrecioCompra, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpPrecioVenta, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpCantidadStock, 2, 1);
            this.tlpPrincipal.Controls.Add(this.tlpRutaImagen, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpDetallesProducto, 0, 3);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 1, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(2, 59);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrincipal.Size = new System.Drawing.Size(493, 552);
            this.tlpPrincipal.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.materialButton3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLimpiar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(330, 394);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(161, 35);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(83, 4);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(75, 27);
            this.materialButton3.TabIndex = 12;
            this.materialButton3.Text = "SALIR";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 4);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(74, 27);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.materialButton2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 394);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 35);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(83, 4);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(74, 27);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "CREAR";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.materialButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(166, 394);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 35);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(3, 4);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(74, 27);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Actualizar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.AnimateReadOnly = false;
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProducto.Depth = 0;
            this.txtIdProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdProducto.LeadingIcon = null;
            this.txtIdProducto.Location = new System.Drawing.Point(942, 3);
            this.txtIdProducto.MaxLength = 50;
            this.txtIdProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdProducto.Multiline = false;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(62, 50);
            this.txtIdProducto.TabIndex = 11;
            this.txtIdProducto.Text = "1";
            this.txtIdProducto.TrailingIcon = null;
            // 
            // dataGridViewListaProductos
            // 
            this.dataGridViewListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaProductos.Location = new System.Drawing.Point(506, 56);
            this.dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            this.dataGridViewListaProductos.Size = new System.Drawing.Size(498, 613);
            this.dataGridViewListaProductos.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewListaProductos, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtIdProducto, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.886905F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.1131F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1007, 672);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tlpPrincipal, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.chkActivo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.380235F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.61977F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(497, 613);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // ucProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucProducto";
            this.Size = new System.Drawing.Size(1007, 672);
            this.Load += new System.EventHandler(this.ucProducto_Load);
            this.tlpNombreProducto.ResumeLayout(false);
            this.tlpNombreProducto.PerformLayout();
            this.tlpCodigoReferencia.ResumeLayout(false);
            this.tlpCodigoReferencia.PerformLayout();
            this.tlpPrecioCompra.ResumeLayout(false);
            this.tlpPrecioCompra.PerformLayout();
            this.tlpPrecioVenta.ResumeLayout(false);
            this.tlpPrecioVenta.PerformLayout();
            this.tlpCantidadStock.ResumeLayout(false);
            this.tlpCantidadStock.PerformLayout();
            this.tlpCategoria.ResumeLayout(false);
            this.tlpCategoria.PerformLayout();
            this.tlpRutaImagen.ResumeLayout(false);
            this.tlpRutaImagen.PerformLayout();
            this.tlpDetallesProducto.ResumeLayout(false);
            this.tlpDetallesProducto.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProductos)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialLabel lblTitulo;
        private System.Windows.Forms.CheckBox chkActivo;
        private MaterialLabel lblNombreProducto;
        private MaterialTextBox txtNombreProducto;
        private MaterialLabel lblCodigoReferencia;
        private MaterialTextBox txtCodigoReferencia;
        private MaterialLabel lblPrecioCompra;
        private MaterialTextBox txtPrecioCompra;
        private MaterialLabel lblPrecioVenta;
        private MaterialTextBox txtPrecioVenta;
        private MaterialLabel lblCantidadStock;
        private MaterialTextBox txtCantidadStock;
        private MaterialLabel lblCategoria;
        private MaterialComboBox cmbCategoria;
        private MaterialLabel lblRutaImagen;
        private MaterialTextBox txtRutaImagen;
        private MaterialButton btnSeleccionarImagen;
        private MaterialLabel lblDetallesProducto;
        private MaterialMultiLineTextBox txtDetallesProducto;
        private MaterialButton btnActualizar;

        // TableLayoutPanels
        private System.Windows.Forms.TableLayoutPanel tlpNombreProducto;
        private System.Windows.Forms.TableLayoutPanel tlpCodigoReferencia;
        private System.Windows.Forms.TableLayoutPanel tlpPrecioCompra;
        private System.Windows.Forms.TableLayoutPanel tlpPrecioVenta;
        private System.Windows.Forms.TableLayoutPanel tlpCantidadStock;
        private System.Windows.Forms.TableLayoutPanel tlpCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpRutaImagen;
        private System.Windows.Forms.TableLayoutPanel tlpDetallesProducto;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialButton materialButton1;
        private MaterialButton materialButton2;
        private MaterialTextBox txtIdProducto;
        private System.Windows.Forms.DataGridView dataGridViewListaProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialButton materialButton3;
        private MaterialButton btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

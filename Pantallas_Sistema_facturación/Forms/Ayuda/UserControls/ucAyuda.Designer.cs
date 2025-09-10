using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Ayuda.UserControls
{
    partial class ucAyuda
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloAyuda = new MaterialSkin.Controls.MaterialLabel();
            this.tlpSeccionBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblPreguntaDuda = new MaterialSkin.Controls.MaterialLabel();
            this.txtDuda = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.tlpSeccionContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcionAyuda = new MaterialSkin.Controls.MaterialLabel();
            this.tlpOpcionesAyuda = new System.Windows.Forms.TableLayoutPanel();
            this.tlpActualizarDatos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIconoActualizar = new System.Windows.Forms.Panel();
            this.lblComoActualizarDatos = new MaterialSkin.Controls.MaterialLabel();
            this.tlpGenerarReporte = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIconoReporte = new System.Windows.Forms.Panel();
            this.lblGenerarReporte = new MaterialSkin.Controls.MaterialLabel();
            this.tlpOlvidoContrasena = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIconoContrasena = new System.Windows.Forms.Panel();
            this.lblOlvidoContraseña = new MaterialSkin.Controls.MaterialLabel();
            this.tlpSeccionBotones = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal.SuspendLayout();
            this.tlpSeccionBusqueda.SuspendLayout();
            this.tlpSeccionContenido.SuspendLayout();
            this.tlpOpcionesAyuda.SuspendLayout();
            this.tlpActualizarDatos.SuspendLayout();
            this.tlpGenerarReporte.SuspendLayout();
            this.tlpOlvidoContrasena.SuspendLayout();
            this.tlpSeccionBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPrincipal.Controls.Add(this.lblTituloAyuda, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpSeccionBusqueda, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpSeccionContenido, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpSeccionBotones, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(30);
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(969, 756);
            this.tlpPrincipal.TabIndex = 0;
            this.tlpPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpPrincipal_Paint);
            // 
            // lblTituloAyuda
            // 
            this.lblTituloAyuda.AutoSize = true;
            this.lblTituloAyuda.Depth = 0;
            this.lblTituloAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloAyuda.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTituloAyuda.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTituloAyuda.Location = new System.Drawing.Point(34, 30);
            this.lblTituloAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.lblTituloAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloAyuda.Name = "lblTituloAyuda";
            this.lblTituloAyuda.Size = new System.Drawing.Size(628, 65);
            this.lblTituloAyuda.TabIndex = 0;
            this.lblTituloAyuda.Text = "CENTRO DE AYUDA";
            this.lblTituloAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSeccionBusqueda
            // 
            this.tlpSeccionBusqueda.ColumnCount = 2;
            this.tlpSeccionBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpSeccionBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSeccionBusqueda.Controls.Add(this.lblPreguntaDuda, 0, 0);
            this.tlpSeccionBusqueda.Controls.Add(this.txtDuda, 0, 1);
            this.tlpSeccionBusqueda.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlpSeccionBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeccionBusqueda.Location = new System.Drawing.Point(34, 115);
            this.tlpSeccionBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpSeccionBusqueda.Name = "tlpSeccionBusqueda";
            this.tlpSeccionBusqueda.RowCount = 2;
            this.tlpSeccionBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeccionBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeccionBusqueda.Size = new System.Drawing.Size(628, 140);
            this.tlpSeccionBusqueda.TabIndex = 1;
            // 
            // lblPreguntaDuda
            // 
            this.lblPreguntaDuda.AutoSize = true;
            this.lblPreguntaDuda.Depth = 0;
            this.lblPreguntaDuda.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPreguntaDuda.Location = new System.Drawing.Point(4, 0);
            this.lblPreguntaDuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblPreguntaDuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPreguntaDuda.Name = "lblPreguntaDuda";
            this.lblPreguntaDuda.Size = new System.Drawing.Size(157, 19);
            this.lblPreguntaDuda.TabIndex = 0;
            this.lblPreguntaDuda.Text = "¿Tienes alguna duda?";
            // 
            // txtDuda
            // 
            this.txtDuda.AnimateReadOnly = false;
            this.txtDuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuda.Depth = 0;
            this.txtDuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDuda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDuda.Hint = "Escribe tu pregunta aquí...";
            this.txtDuda.LeadingIcon = null;
            this.txtDuda.Location = new System.Drawing.Point(4, 48);
            this.txtDuda.Margin = new System.Windows.Forms.Padding(4, 8, 15, 8);
            this.txtDuda.MaxLength = 250;
            this.txtDuda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDuda.Multiline = false;
            this.txtDuda.Name = "txtDuda";
            this.txtDuda.Size = new System.Drawing.Size(452, 50);
            this.txtDuda.TabIndex = 1;
            this.txtDuda.Text = "";
            this.txtDuda.TrailingIcon = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(4, 8);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(143, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            // 
            // tlpSeccionContenido
            // 
            this.tlpSeccionContenido.ColumnCount = 1;
            this.tlpSeccionContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeccionContenido.Controls.Add(this.lblDescripcionAyuda, 0, 0);
            this.tlpSeccionContenido.Controls.Add(this.tlpOpcionesAyuda, 0, 1);
            this.tlpSeccionContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeccionContenido.Location = new System.Drawing.Point(34, 265);
            this.tlpSeccionContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpSeccionContenido.Name = "tlpSeccionContenido";
            this.tlpSeccionContenido.RowCount = 2;
            this.tlpSeccionContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSeccionContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeccionContenido.Size = new System.Drawing.Size(628, 356);
            this.tlpSeccionContenido.TabIndex = 2;
            // 
            // lblDescripcionAyuda
            // 
            this.lblDescripcionAyuda.AutoSize = true;
            this.lblDescripcionAyuda.Depth = 0;
            this.lblDescripcionAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionAyuda.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionAyuda.Location = new System.Drawing.Point(4, 0);
            this.lblDescripcionAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.lblDescripcionAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionAyuda.Name = "lblDescripcionAyuda";
            this.lblDescripcionAyuda.Size = new System.Drawing.Size(620, 45);
            this.lblDescripcionAyuda.TabIndex = 0;
            this.lblDescripcionAyuda.Text = "Encuentra información útil sobre cómo utilizar el sistema de facturación. Haz cli" +
    "c en cualquiera de las opciones para obtener ayuda específica.";
            this.lblDescripcionAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpOpcionesAyuda
            // 
            this.tlpOpcionesAyuda.ColumnCount = 3;
            this.tlpOpcionesAyuda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpOpcionesAyuda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpOpcionesAyuda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpOpcionesAyuda.Controls.Add(this.tlpActualizarDatos, 0, 0);
            this.tlpOpcionesAyuda.Controls.Add(this.tlpGenerarReporte, 1, 0);
            this.tlpOpcionesAyuda.Controls.Add(this.tlpOlvidoContrasena, 2, 0);
            this.tlpOpcionesAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOpcionesAyuda.Location = new System.Drawing.Point(4, 75);
            this.tlpOpcionesAyuda.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.tlpOpcionesAyuda.Name = "tlpOpcionesAyuda";
            this.tlpOpcionesAyuda.RowCount = 1;
            this.tlpOpcionesAyuda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOpcionesAyuda.Size = new System.Drawing.Size(620, 276);
            this.tlpOpcionesAyuda.TabIndex = 1;
            // 
            // tlpActualizarDatos
            // 
            this.tlpActualizarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tlpActualizarDatos.ColumnCount = 1;
            this.tlpActualizarDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActualizarDatos.Controls.Add(this.pnlIconoActualizar, 0, 0);
            this.tlpActualizarDatos.Controls.Add(this.lblComoActualizarDatos, 0, 1);
            this.tlpActualizarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpActualizarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActualizarDatos.Location = new System.Drawing.Point(8, 8);
            this.tlpActualizarDatos.Margin = new System.Windows.Forms.Padding(8);
            this.tlpActualizarDatos.Name = "tlpActualizarDatos";
            this.tlpActualizarDatos.Padding = new System.Windows.Forms.Padding(15);
            this.tlpActualizarDatos.RowCount = 2;
            this.tlpActualizarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpActualizarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpActualizarDatos.Size = new System.Drawing.Size(190, 260);
            this.tlpActualizarDatos.TabIndex = 0;
            // 
            // pnlIconoActualizar
            // 
            this.pnlIconoActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.pnlIconoActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIconoActualizar.Location = new System.Drawing.Point(18, 18);
            this.pnlIconoActualizar.Name = "pnlIconoActualizar";
            this.pnlIconoActualizar.Size = new System.Drawing.Size(154, 143);
            this.pnlIconoActualizar.TabIndex = 0;
            // 
            // lblComoActualizarDatos
            // 
            this.lblComoActualizarDatos.AutoSize = true;
            this.lblComoActualizarDatos.Depth = 0;
            this.lblComoActualizarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComoActualizarDatos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblComoActualizarDatos.Location = new System.Drawing.Point(18, 164);
            this.lblComoActualizarDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblComoActualizarDatos.Name = "lblComoActualizarDatos";
            this.lblComoActualizarDatos.Size = new System.Drawing.Size(154, 81);
            this.lblComoActualizarDatos.TabIndex = 1;
            this.lblComoActualizarDatos.Text = "¿Cómo actualizar mis datos?";
            this.lblComoActualizarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpGenerarReporte
            // 
            this.tlpGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tlpGenerarReporte.ColumnCount = 1;
            this.tlpGenerarReporte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGenerarReporte.Controls.Add(this.pnlIconoReporte, 0, 0);
            this.tlpGenerarReporte.Controls.Add(this.lblGenerarReporte, 0, 1);
            this.tlpGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpGenerarReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGenerarReporte.Location = new System.Drawing.Point(214, 8);
            this.tlpGenerarReporte.Margin = new System.Windows.Forms.Padding(8);
            this.tlpGenerarReporte.Name = "tlpGenerarReporte";
            this.tlpGenerarReporte.Padding = new System.Windows.Forms.Padding(15);
            this.tlpGenerarReporte.RowCount = 2;
            this.tlpGenerarReporte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpGenerarReporte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpGenerarReporte.Size = new System.Drawing.Size(190, 260);
            this.tlpGenerarReporte.TabIndex = 1;
            // 
            // pnlIconoReporte
            // 
            this.pnlIconoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(107)))), ((int)(((byte)(168)))));
            this.pnlIconoReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIconoReporte.Location = new System.Drawing.Point(18, 18);
            this.pnlIconoReporte.Name = "pnlIconoReporte";
            this.pnlIconoReporte.Size = new System.Drawing.Size(154, 143);
            this.pnlIconoReporte.TabIndex = 0;
            // 
            // lblGenerarReporte
            // 
            this.lblGenerarReporte.AutoSize = true;
            this.lblGenerarReporte.Depth = 0;
            this.lblGenerarReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenerarReporte.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGenerarReporte.Location = new System.Drawing.Point(18, 164);
            this.lblGenerarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenerarReporte.Name = "lblGenerarReporte";
            this.lblGenerarReporte.Size = new System.Drawing.Size(154, 81);
            this.lblGenerarReporte.TabIndex = 1;
            this.lblGenerarReporte.Text = "¿Cómo generar un reporte?";
            this.lblGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpOlvidoContrasena
            // 
            this.tlpOlvidoContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tlpOlvidoContrasena.ColumnCount = 1;
            this.tlpOlvidoContrasena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOlvidoContrasena.Controls.Add(this.pnlIconoContrasena, 0, 0);
            this.tlpOlvidoContrasena.Controls.Add(this.lblOlvidoContraseña, 0, 1);
            this.tlpOlvidoContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpOlvidoContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOlvidoContrasena.Location = new System.Drawing.Point(420, 8);
            this.tlpOlvidoContrasena.Margin = new System.Windows.Forms.Padding(8);
            this.tlpOlvidoContrasena.Name = "tlpOlvidoContrasena";
            this.tlpOlvidoContrasena.Padding = new System.Windows.Forms.Padding(15);
            this.tlpOlvidoContrasena.RowCount = 2;
            this.tlpOlvidoContrasena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpOlvidoContrasena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpOlvidoContrasena.Size = new System.Drawing.Size(192, 260);
            this.tlpOlvidoContrasena.TabIndex = 2;
            // 
            // pnlIconoContrasena
            // 
            this.pnlIconoContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(216)))));
            this.pnlIconoContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIconoContrasena.Location = new System.Drawing.Point(18, 18);
            this.pnlIconoContrasena.Name = "pnlIconoContrasena";
            this.pnlIconoContrasena.Size = new System.Drawing.Size(156, 143);
            this.pnlIconoContrasena.TabIndex = 0;
            // 
            // lblOlvidoContraseña
            // 
            this.lblOlvidoContraseña.AutoSize = true;
            this.lblOlvidoContraseña.Depth = 0;
            this.lblOlvidoContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOlvidoContraseña.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOlvidoContraseña.Location = new System.Drawing.Point(18, 164);
            this.lblOlvidoContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOlvidoContraseña.Name = "lblOlvidoContraseña";
            this.lblOlvidoContraseña.Size = new System.Drawing.Size(156, 81);
            this.lblOlvidoContraseña.TabIndex = 1;
            this.lblOlvidoContraseña.Text = "¿Qué hacer si olvido mi contraseña?";
            this.lblOlvidoContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSeccionBotones
            // 
            this.tlpSeccionBotones.ColumnCount = 3;
            this.tlpSeccionBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeccionBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlpSeccionBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSeccionBotones.Controls.Add(this.btnSalir, 1, 0);
            this.tlpSeccionBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeccionBotones.Location = new System.Drawing.Point(34, 631);
            this.tlpSeccionBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpSeccionBotones.Name = "tlpSeccionBotones";
            this.tlpSeccionBotones.RowCount = 2;
            this.tlpSeccionBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeccionBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSeccionBotones.Size = new System.Drawing.Size(628, 70);
            this.tlpSeccionBotones.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(474, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(448, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(156, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ucAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "ucAyuda";
            this.Size = new System.Drawing.Size(969, 756);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpSeccionBusqueda.ResumeLayout(false);
            this.tlpSeccionBusqueda.PerformLayout();
            this.tlpSeccionContenido.ResumeLayout(false);
            this.tlpSeccionContenido.PerformLayout();
            this.tlpOpcionesAyuda.ResumeLayout(false);
            this.tlpActualizarDatos.ResumeLayout(false);
            this.tlpActualizarDatos.PerformLayout();
            this.tlpGenerarReporte.ResumeLayout(false);
            this.tlpGenerarReporte.PerformLayout();
            this.tlpOlvidoContrasena.ResumeLayout(false);
            this.tlpOlvidoContrasena.PerformLayout();
            this.tlpSeccionBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private MaterialLabel lblTituloAyuda;
        private System.Windows.Forms.TableLayoutPanel tlpSeccionBusqueda;
        private MaterialLabel lblPreguntaDuda;
        private MaterialTextBox txtDuda;
        private MaterialButton btnBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpSeccionContenido;
        private MaterialLabel lblDescripcionAyuda;
        private System.Windows.Forms.TableLayoutPanel tlpOpcionesAyuda;
        private System.Windows.Forms.TableLayoutPanel tlpActualizarDatos;
        private System.Windows.Forms.Panel pnlIconoActualizar;
        private MaterialLabel lblComoActualizarDatos;
        private System.Windows.Forms.TableLayoutPanel tlpGenerarReporte;
        private System.Windows.Forms.Panel pnlIconoReporte;
        private MaterialLabel lblGenerarReporte;
        private System.Windows.Forms.TableLayoutPanel tlpOlvidoContrasena;
        private System.Windows.Forms.Panel pnlIconoContrasena;
        private MaterialLabel lblOlvidoContraseña;
        private System.Windows.Forms.TableLayoutPanel tlpSeccionBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialButton btnSalir;
    }
}

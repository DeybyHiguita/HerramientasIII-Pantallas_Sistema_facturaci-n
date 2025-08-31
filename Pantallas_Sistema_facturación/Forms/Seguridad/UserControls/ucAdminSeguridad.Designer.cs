using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Seguridad.UserControls
{
    partial class ucAdminSeguridad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.txtDescripcionRol = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreRol = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.lblRolEmpleado);
            this.panel1.Location = new System.Drawing.Point(50, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 213);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnActualizar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDescripcionRol, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtNombreRol, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDescripcionRol, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNombreRol, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(75, 69);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 90);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(118, 62);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(113, 26);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(2, 62);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(112, 26);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.AnimateReadOnly = false;
            this.txtDescripcionRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionRol.Depth = 0;
            this.txtDescripcionRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcionRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionRol.LeadingIcon = null;
            this.txtDescripcionRol.Location = new System.Drawing.Point(118, 32);
            this.txtDescripcionRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcionRol.MaxLength = 200;
            this.txtDescripcionRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionRol.Multiline = false;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(113, 50);
            this.txtDescripcionRol.TabIndex = 5;
            this.txtDescripcionRol.Text = "";
            this.txtDescripcionRol.TrailingIcon = null;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.AnimateReadOnly = false;
            this.txtNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreRol.LeadingIcon = null;
            this.txtNombreRol.Location = new System.Drawing.Point(118, 2);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreRol.MaxLength = 50;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreRol.Multiline = false;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(113, 50);
            this.txtNombreRol.TabIndex = 3;
            this.txtNombreRol.Text = "";
            this.txtNombreRol.TrailingIcon = null;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionRol.Location = new System.Drawing.Point(2, 30);
            this.lblDescripcionRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(112, 30);
            this.lblDescripcionRol.TabIndex = 4;
            this.lblDescripcionRol.Text = "Descripción Rol";
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Depth = 0;
            this.lblNombreRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreRol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreRol.Location = new System.Drawing.Point(2, 0);
            this.lblNombreRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(112, 30);
            this.lblNombreRol.TabIndex = 0;
            this.lblNombreRol.Text = "Nombre de Rol";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRolEmpleado.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblRolEmpleado.Location = new System.Drawing.Point(0, 0);
            this.lblRolEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(130, 24);
            this.lblRolEmpleado.TabIndex = 1;
            this.lblRolEmpleado.Text = "ROL EMPLEADO";
            // 
            // ucAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucAdminSeguridad";
            this.Size = new System.Drawing.Size(510, 300);
            this.Load += new System.EventHandler(this.ucAdminSeguridad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialLabel lblRolEmpleado;
        private MaterialLabel lblNombreRol;
        private MaterialButton btnSalir;
        private MaterialButton btnActualizar;
        private MaterialLabel lblDescripcionRol;
        private MaterialTextBox txtNombreRol;
        private MaterialTextBox txtDescripcionRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

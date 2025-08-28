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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblDescripcionRol = new System.Windows.Forms.Label();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();

            // Estilos de fuente
            System.Drawing.Font fuenteBold = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fuenteRegular = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Color colorNegro = System.Drawing.Color.Black;

            // panel1
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.lblRolEmpleado);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(75, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 328);
            this.panel1.TabIndex = 0;

            // lblRolEmpleado (Título principal)
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Location = new System.Drawing.Point(248, 11);
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(109, 20);
            this.lblRolEmpleado.TabIndex = 1;
            this.lblRolEmpleado.Text = "Rol Empleado";
            this.lblRolEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.Black;

            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcionRol, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcionRol, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreRol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreRol, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 181);
            this.tableLayoutPanel1.TabIndex = 0;

            // lblNombreRol
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Location = new System.Drawing.Point(3, 0);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(115, 20);
            this.lblNombreRol.TabIndex = 0;
            this.lblNombreRol.Text = "Nombre de Rol";
            this.lblNombreRol.Font = fuenteBold;
            this.lblNombreRol.ForeColor = System.Drawing.Color.Black;

            // txtNombreRol
            this.txtNombreRol.Location = new System.Drawing.Point(3, 31);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(360, 26);
            this.txtNombreRol.TabIndex = 3;
            this.txtNombreRol.Font = fuenteRegular;

            // lblDescripcionRol
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Location = new System.Drawing.Point(3, 86);
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(120, 20);
            this.lblDescripcionRol.TabIndex = 4;
            this.lblDescripcionRol.Text = "Descripción Rol";
            this.lblDescripcionRol.Font = fuenteBold;
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.Black;

            // txtDescripcionRol
            this.txtDescripcionRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcionRol.Location = new System.Drawing.Point(3, 142);
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(360, 26);
            this.txtDescripcionRol.TabIndex = 5;
            this.txtDescripcionRol.Font = fuenteRegular;

            // tableLayoutPanel2
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(299, 262);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 45);
            this.tableLayoutPanel2.TabIndex = 2;

            // btnActualizar
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Font = fuenteBold;
            this.btnActualizar.BackColor = System.Drawing.Color.Purple;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(3, 3);
            this.btnActualizar.Size = new System.Drawing.Size(94, 39);
            this.btnActualizar.UseVisualStyleBackColor = false;

            // btnSalir
            this.btnSalir.Text = "Salir";
            this.btnSalir.Font = fuenteBold;
            this.btnSalir.BackColor = System.Drawing.Color.Purple;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(103, 3);
            this.btnSalir.Size = new System.Drawing.Size(94, 39);
            this.btnSalir.UseVisualStyleBackColor = false;

            // ucAdminSeguridad
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucAdminSeguridad";
            this.Size = new System.Drawing.Size(765, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDescripcionRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
    }
}

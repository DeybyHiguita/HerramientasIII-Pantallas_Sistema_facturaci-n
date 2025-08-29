
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblDescripcionRol = new System.Windows.Forms.Label();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.lblRolEmpleado);
            this.panel1.Location = new System.Drawing.Point(75, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 328);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(112, 106);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 139);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Purple;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(177, 95);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 41);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Purple;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(3, 95);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(168, 41);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcionRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcionRol.Location = new System.Drawing.Point(177, 49);
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(169, 34);
            this.txtDescripcionRol.TabIndex = 5;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreRol.Location = new System.Drawing.Point(177, 3);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(169, 34);
            this.txtNombreRol.TabIndex = 3;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(3, 46);
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(168, 46);
            this.lblDescripcionRol.TabIndex = 4;
            this.lblDescripcionRol.Text = "Descripción Rol";
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreRol.ForeColor = System.Drawing.Color.Black;
            this.lblNombreRol.Location = new System.Drawing.Point(3, 0);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(168, 46);
            this.lblNombreRol.TabIndex = 0;
            this.lblNombreRol.Text = "Nombre de Rol";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(0, 0);
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(196, 32);
            this.lblRolEmpleado.TabIndex = 1;
            this.lblRolEmpleado.Text = "ROL EMPLEADO";
            // 
            // ucAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucAdminSeguridad";
            this.Size = new System.Drawing.Size(765, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDescripcionRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

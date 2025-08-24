namespace Pantallas_Sistema_facturación.UserControls
{
    partial class ucDashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        // Controles del dashboard
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblSubtitle;
        private System.Windows.Forms.Panel panelStats;

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
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblSubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 30);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Principal";
            
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Depth = 0;
            this.lblSubtitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(50, 80);
            this.lblSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Bienvenido al Sistema de Facturación";
            
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelStats.Location = new System.Drawing.Point(50, 130);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(700, 200);
            this.panelStats.TabIndex = 2;
            
            // 
            // ucDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(800, 600);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
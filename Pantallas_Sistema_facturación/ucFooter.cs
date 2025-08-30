using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class ucFooter : UserControl
    {
        public ucFooter()
        {
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.lblDesarrolladoPor = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.lblCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblDesarrolladoPor
            // 
            this.lblDesarrolladoPor.AutoSize = true;
            this.lblDesarrolladoPor.Depth = 0;
            this.lblDesarrolladoPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDesarrolladoPor.Location = new System.Drawing.Point(500, 15);
            this.lblDesarrolladoPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesarrolladoPor.Name = "lblDesarrolladoPor";
            this.lblDesarrolladoPor.Size = new System.Drawing.Size(261, 19);
            this.lblDesarrolladoPor.TabIndex = 0;
            this.lblDesarrolladoPor.Text = "Desarrollado por Jhon Deyby Higuita, Santiago Catano y David Paredes";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(500, 38);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(216, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "✉ davehiguitapro@gmail.com";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTelefono.Location = new System.Drawing.Point(500, 58);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(154, 19);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "📞 +57 302 239 00 00";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Depth = 0;
            this.lblCopyright.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCopyright.Location = new System.Drawing.Point(500, 78);
            this.lblCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(339, 19);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "© GoWork 2025, todos los derechos reservados.";
            // 
            // ucFooter
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDesarrolladoPor);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.Name = "ucFooter";
            this.Size = new System.Drawing.Size(1502, 100);
            this.Load += new System.EventHandler(this.ControlPiePagina_Load);
            this.Resize += new System.EventHandler(this.ControlPiePagina_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void ControlPiePagina_Load(object sender, EventArgs e)
        {
            // Configurar colores después de que se cargue el control
            EstablecerColoresPersonalizados();
            CentrarEtiquetas();
        }
        
        private void EstablecerColoresPersonalizados()
        {
            // Configurar colores personalizados para MaterialLabels en tiempo de ejecución
            lblDesarrolladoPor.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;
            lblTelefono.ForeColor = Color.White;
            lblCopyright.ForeColor = Color.FromArgb(220, 220, 220);
        }
        
        private void ControlPiePagina_Resize(object sender, EventArgs e)
        {
            CentrarEtiquetas();
        }
        
        private void CentrarEtiquetas()
        {
            if (this.Width > 0)
            {
                // Calcular el centro horizontal del control
                int CentroHorizontal = this.Width / 2;
                
                // Centrar cada label horizontalmente
                if (lblDesarrolladoPor != null)
                    lblDesarrolladoPor.Left = CentroHorizontal - (lblDesarrolladoPor.Width / 2);
                    
                if (lblEmail != null)
                    lblEmail.Left = CentroHorizontal - (lblEmail.Width / 2);
                    
                if (lblTelefono != null)
                    lblTelefono.Left = CentroHorizontal - (lblTelefono.Width / 2);
                    
                if (lblCopyright != null)
                    lblCopyright.Left = CentroHorizontal - (lblCopyright.Width / 2);
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CentrarEtiquetas();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ucFooter
            // 
            this.Name = "ucFooter";
            this.ResumeLayout(false);

        }
    }
}
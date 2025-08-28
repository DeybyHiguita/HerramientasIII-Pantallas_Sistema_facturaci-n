using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.UserControls
{
    /// <summary>
    /// Clase base para UserControls responsivos
    /// </summary>
    public class ResponsiveUserControl : UserControl
    {
        protected Size _minimumContentSize = new Size(800, 600);
        protected bool _enableResponsiveLayout = true;
        
        public ResponsiveUserControl()
        {
            InitializeResponsiveFeatures();
        }
        
        /// <summary>
        /// Tamaño mínimo del contenido del UserControl
        /// </summary>
        public Size MinimumContentSize
        {
            get { return _minimumContentSize; }
            set 
            { 
                _minimumContentSize = value;
                this.MinimumSize = value;
            }
        }
        
        /// <summary>
        /// Habilita o deshabilita el layout responsivo
        /// </summary>
        public bool EnableResponsiveLayout
        {
            get { return _enableResponsiveLayout; }
            set { _enableResponsiveLayout = value; }
        }
        
        private void InitializeResponsiveFeatures()
        {
            // Configurar scroll automático
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            
            // Establecer color de fondo predeterminado
            this.BackColor = Color.White;
            
            // Suscribirse a eventos de redimensionamiento
            this.Resize += ResponsiveUserControl_Resize;
            this.Load += ResponsiveUserControl_Load;
        }
        
        private void ResponsiveUserControl_Load(object sender, EventArgs e)
        {
            if (_enableResponsiveLayout)
            {
                ConfigureInitialLayout();
            }
        }
        
        private void ResponsiveUserControl_Resize(object sender, EventArgs e)
        {
            if (_enableResponsiveLayout)
            {
                AdjustResponsiveLayout();
            }
        }
        
        /// <summary>
        /// Configura el layout inicial cuando se carga el control
        /// </summary>
        protected virtual void ConfigureInitialLayout()
        {
            // Los controles derivados pueden sobrescribir este método
            AdjustResponsiveLayout();
        }
        
        /// <summary>
        /// Ajusta el layout cuando cambia el tamaño del control
        /// </summary>
        protected virtual void AdjustResponsiveLayout()
        {
            // Los controles derivados pueden sobrescribir este método
            // para implementar su lógica de layout específica
        }
        
        /// <summary>
        /// Configura un control para que sea responsivo
        /// </summary>
        /// <param name="control">Control a configurar</param>
        /// <param name="anchor">Anclaje del control</param>
        protected void ConfigureControlResponsive(Control control, AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Left)
        {
            if (control != null)
            {
                control.Anchor = anchor;
            }
        }
        
        /// <summary>
        /// Centra un control horizontalmente en el UserControl
        /// </summary>
        /// <param name="control">Control a centrar</param>
        protected void CenterControlHorizontally(Control control)
        {
            if (control != null && this.Width > 0)
            {
                control.Left = (this.Width - control.Width) / 2;
            }
        }
        
        /// <summary>
        /// Ajusta el ancho de un control basado en el ancho disponible
        /// </summary>
        /// <param name="control">Control a ajustar</param>
        /// <param name="percentage">Porcentaje del ancho disponible (0.0 a 1.0)</param>
        /// <param name="maxWidth">Ancho máximo permitido</param>
        protected void AdjustControlWidth(Control control, double percentage = 0.8, int maxWidth = 500)
        {
            if (control != null && this.Width > 0)
            {
                int availableWidth = this.Width - 40; // Márgenes
                int newWidth = Math.Min((int)(availableWidth * percentage), maxWidth);
                control.Width = Math.Max(newWidth, control.MinimumSize.Width);
            }
        }
        
        /// <summary>
        /// Organiza controles en dos columnas
        /// </summary>
        /// <param name="leftControls">Controles de la columna izquierda</param>
        /// <param name="rightControls">Controles de la columna derecha</param>
        protected void ArrangeInTwoColumns(Control[] leftControls, Control[] rightControls)
        {
            if (this.Width < _minimumContentSize.Width) return;
            
            int availableWidth = this.Width - 60; // Márgenes
            int columnWidth = (availableWidth - 40) / 2; // Espacio entre columnas
            int leftColumnX = 30;
            int rightColumnX = leftColumnX + columnWidth + 40;
            
            // Ajustar controles de la columna izquierda
            foreach (var control in leftControls)
            {
                if (control != null)
                {
                    control.Left = leftColumnX;
                    if (control.Width > columnWidth)
                    {
                        control.Width = columnWidth;
                    }
                }
            }
            
            // Ajustar controles de la columna derecha
            foreach (var control in rightControls)
            {
                if (control != null)
                {
                    control.Left = rightColumnX;
                    if (control.Width > columnWidth)
                    {
                        control.Width = columnWidth;
                    }
                }
            }
        }
    }
}
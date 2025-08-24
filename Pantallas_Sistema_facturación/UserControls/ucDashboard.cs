using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.UserControls
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            LoadDashboardContent();
        }
        
        private void LoadDashboardContent()
        {
            // Crear las cards de estadísticas en tiempo de ejecución
            CreateStatsCards();
        }
        
        private void CreateStatsCards()
        {
            // Limpiar el panel primero
            panelStats.Controls.Clear();
            
            // Crear las cards de estadísticas con paleta de morados
            var cardFacturas = CreateStatsCard("Facturas del Mes", "150", Color.FromArgb(165, 135, 195), 0); // Morado principal
            var cardClientes = CreateStatsCard("Clientes Activos", "85", Color.FromArgb(142, 107, 168), 180); // Morado más oscuro
            var cardVentas = CreateStatsCard("Ventas Totales", "$125,000", Color.FromArgb(200, 168, 216), 360); // Morado más claro
            var cardPendientes = CreateStatsCard("Pendientes", "12", Color.FromArgb(120, 120, 120), 540); // Gris elegante
            
            // Agregar las cards al panel
            panelStats.Controls.Add(cardFacturas);
            panelStats.Controls.Add(cardClientes);
            panelStats.Controls.Add(cardVentas);
            panelStats.Controls.Add(cardPendientes);
        }
        
        private Panel CreateStatsCard(string title, string value, Color color, int x)
        {
            var card = new Panel
            {
                Location = new Point(x, 20),
                Size = new Size(160, 120),
                BackColor = color,
                Margin = new Padding(10)
            };
            
            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 15),
                Size = new Size(140, 40),
                TextAlign = ContentAlignment.TopCenter
            };
            
            var lblValue = new Label
            {
                Text = value,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(10, 60),
                Size = new Size(140, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            
            return card;
        }
    }
}
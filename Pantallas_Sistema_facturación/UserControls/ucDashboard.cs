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
            ConfigureDashboard();
            LoadDashboardContent();
        }
        
        private void ConfigureDashboard()
        {
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            this.MinimumSize = new Size(600, 400);
            this.BackColor = Color.White;
            
            this.Resize += UcDashboard_Resize;
        }
        
        private void UcDashboard_Resize(object sender, EventArgs e)
        {
            if (panelStats != null)
            {
                AdjustStatsCardsLayout();
            }
        }
        
        private void LoadDashboardContent()
        {
            CreateStatsCards();
        }
        
        private void CreateStatsCards()
        {
            if (panelStats != null)
            {
                panelStats.Controls.Clear();
            }
            
            var cardFacturas = CreateStatsCard("Facturas del Mes", "150", Color.FromArgb(165, 135, 195), 0); // Morado principal
            var cardClientes = CreateStatsCard("Clientes Activos", "85", Color.FromArgb(142, 107, 168), 1); // Morado más oscuro
            var cardVentas = CreateStatsCard("Ventas Totales", "$125,000", Color.FromArgb(200, 168, 216), 2); // Morado más claro
            var cardPendientes = CreateStatsCard("Pendientes", "12", Color.FromArgb(120, 120, 120), 3); // Gris elegante
            
            if (panelStats != null)
            {
                panelStats.Controls.Add(cardFacturas);
                panelStats.Controls.Add(cardClientes);
                panelStats.Controls.Add(cardVentas);
                panelStats.Controls.Add(cardPendientes);
            }
            
            AdjustStatsCardsLayout();
        }
        
        private void AdjustStatsCardsLayout()
        {
            if (panelStats == null || panelStats.Controls.Count == 0) return;
            
            int availableWidth = this.Width - 40;
            int cardWidth = 160;
            int cardHeight = 120;
            int spacing = 20;
            
            int cardsPerRow = Math.Max(1, (availableWidth + spacing) / (cardWidth + spacing));
            
            if (cardsPerRow > 4)
            {
                cardsPerRow = 4;
                cardWidth = (availableWidth - (spacing * (cardsPerRow - 1))) / cardsPerRow;
            }
            
            for (int i = 0; i < panelStats.Controls.Count; i++)
            {
                var card = panelStats.Controls[i];
                int row = i / cardsPerRow;
                int col = i % cardsPerRow;
                
                int x = col * (cardWidth + spacing);
                int y = 20 + row * (cardHeight + spacing);
                
                card.Location = new Point(x, y);
                card.Size = new Size(cardWidth, cardHeight);
            }
            
            int totalRows = (panelStats.Controls.Count + cardsPerRow - 1) / cardsPerRow;
            panelStats.Height = 40 + totalRows * (cardHeight + spacing);
        }
        
        private Panel CreateStatsCard(string title, string value, Color color, int index)
        {
            var card = new Panel
            {
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
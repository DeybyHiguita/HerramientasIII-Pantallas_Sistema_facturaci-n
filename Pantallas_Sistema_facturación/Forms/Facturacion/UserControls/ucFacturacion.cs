using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Facturacion.UserControls
{
    public partial class ucFacturacion : UserControl
    {
        public ucFacturacion()
        {
            InitializeComponent();
        }

        // Método manejador para el evento Load
        private void ucFacturacion_Load(object sender, EventArgs e)
        {
            // Aquí va el código que quieres ejecutar al cargar el control
        }

        // Método manejador para el evento SelectedIndexChanged del combo de cliente
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí va el código que quieres ejecutar cuando cambie el cliente seleccionado
        }

        private void lblNroFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        // Si tienes otros eventos, así se agregan:
        // private void btnSalir_Click(object sender, EventArgs e)
        // {
        //     // Código para el botón salir
        // }
    }
}
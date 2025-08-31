using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Ayuda.UserControls
{
    public partial class ucAcercaDe : UserControl
    {
        public ucAcercaDe()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var ResultadoConfirmacion = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResultadoConfirmacion == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
    }
}

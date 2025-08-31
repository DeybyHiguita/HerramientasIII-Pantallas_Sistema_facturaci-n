using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Seguridad.UserControls
{
    public partial class ucEmpleado : UserControl
    {
        public ucEmpleado()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show(
                "¿Está seguro que desea salir sin guardar?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                this.Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            void Limpiar(Control Control)
            {
                switch (Control)
                {
                    case TextBoxBase CuadroTexto:
                        CuadroTexto.Clear();
                        break;
                    case ComboBox ComboBox:
                        ComboBox.SelectedIndex = -1;
                        ComboBox.Text = string.Empty;
                        break;
                    case CheckBox CasillaVerificacion:
                        CasillaVerificacion.Checked = false;
                        break;
                    case RadioButton BotonRadio:
                        BotonRadio.Checked = false;
                        break;
                    case NumericUpDown ControlNumerico:
                        ControlNumerico.Value = ControlNumerico.Minimum;
                        break;
                    case DateTimePicker SelectorFecha:
                        SelectorFecha.Value = DateTime.Now;
                        break;
                }

                foreach (Control ControlHijo in Control.Controls)
                    Limpiar(ControlHijo);
            }

            Limpiar(this);
        }
    }
}

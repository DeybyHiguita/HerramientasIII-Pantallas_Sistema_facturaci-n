using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Seguridad.UserControls
{
    public partial class ucAdminSeguridad : UserControl
    {
        public ucAdminSeguridad()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucAdminSeguridad_Load(object sender, EventArgs e)
        {
            ConfigurarValidacion();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
        }

        private void ConfigurarValidacion()
        {
            if (txtNombreRol != null)
            {
                txtNombreRol.KeyPress += ValidarTextoAlfanumerico_KeyPress;
            }
        }

        private void ValidarTextoAlfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string Mensaje = $"Configuración de seguridad actualizada:\n\n" +
                                $"Rol: {txtNombreRol.Text}\n" +
                                $"Descripción: {txtDescripcionRol.Text}";
                
                MessageBox.Show(Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("El nombre del rol es requerido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreRol.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionRol.Text))
            {
                MessageBox.Show("La descripción del rol es requerida", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcionRol.Focus();
                return false;
            }

            return true;
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

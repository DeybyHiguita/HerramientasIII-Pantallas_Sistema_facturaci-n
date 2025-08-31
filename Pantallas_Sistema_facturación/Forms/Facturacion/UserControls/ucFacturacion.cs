using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Models;

namespace Pantallas_Sistema_facturación.Forms.Facturacion.UserControls
{
    public partial class ucFacturacion : UserControl
    {
        private bool FechaEnFocus = false;

        public ucFacturacion()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucFacturacion_Load(object sender, EventArgs e)
        {
            InicializarComboBoxes();
            ConfigurarValidacion();
            ConectarManejadoresEventos();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            
            dtpFecha.Value = DateTime.Now;
            GenerarNumeroFactura();
            ConfigurarEstiloDateTimePicker();
        }

        private void ConfigurarEstiloDateTimePicker()
        {
            if (dtpFecha != null)
            {
                dtpFecha.BackColor = Color.White;
                dtpFecha.ForeColor = Color.FromArgb(222, 0, 0, 0);
                dtpFecha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
                dtpFecha.Format = DateTimePickerFormat.Custom;
                dtpFecha.CustomFormat = "dd/MM/yyyy";
                dtpFecha.Enter += DateTimePicker_Enter;
                dtpFecha.Leave += DateTimePicker_Leave;
                
                if (tlpFecha != null)
                {
                    tlpFecha.Paint += TlpFecha_Paint;
                    tlpFecha.BackColor = Color.White;
                }
            }
        }

        private void TlpFecha_Paint(object sender, PaintEventArgs e)
        {
            var tlp = sender as TableLayoutPanel;
            if (tlp != null)
            {
                Color colorBorde = FechaEnFocus ? Color.FromArgb(165, 135, 195) : Color.FromArgb(200, 200, 200);
                int grosorBorde = FechaEnFocus ? 2 : 1;
                
                using (var pen = new Pen(colorBorde, grosorBorde))
                {
                    e.Graphics.DrawLine(pen, 2, tlp.Height - 3, tlp.Width - 4, tlp.Height - 3);
                }
                
                using (var penSuperior = new Pen(Color.FromArgb(240, 240, 240), 1))
                {
                    e.Graphics.DrawLine(penSuperior, 2, 20, tlp.Width - 4, 20);
                }
                
                using (var penLateral = new Pen(Color.FromArgb(245, 245, 245), 1))
                {
                    e.Graphics.DrawLine(penLateral, 2, 20, 2, tlp.Height - 3);
                    e.Graphics.DrawLine(penLateral, tlp.Width - 3, 20, tlp.Width - 3, tlp.Height - 3);
                }
            }
        }

        private void DateTimePicker_Enter(object sender, EventArgs e)
        {
            FechaEnFocus = true;
            if (tlpFecha != null)
                tlpFecha.Invalidate();
        }

        private void DateTimePicker_Leave(object sender, EventArgs e)
        {
            FechaEnFocus = false;
            if (tlpFecha != null)
                tlpFecha.Invalidate();
        }

        private void ConectarManejadoresEventos()
        {
            if (btnActualizar != null)
            {
                btnActualizar.Click -= btnActualizar_Click;
                btnActualizar.Click += btnActualizar_Click;
            }
            
            if (btnSalir != null)
            {
                btnSalir.Click -= btnSalir_Click;
                btnSalir.Click += btnSalir_Click;
            }

            if (cmbCliente != null)
            {
                cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;
                cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            }
        }

        private void GenerarNumeroFactura()
        {
            string NumeroFactura = DateTime.Now.ToString("yyyyMMddHHmmss");
            txtNroFactura.Text = $"FAC-{NumeroFactura}";
        }

        private void InicializarComboBoxes()
        {
            if (cmbCliente != null)
            {
                cmbCliente.Items.Clear();
                cmbCliente.Items.Add("Juan Pérez Martínez");
                cmbCliente.Items.Add("María González López");
                cmbCliente.Items.Add("Carlos Rodríguez Sánchez");
                cmbCliente.Items.Add("Ana Fernández Torres");
                cmbCliente.Items.Add("Luis Martín García");
                cmbCliente.Items.Add("Carmen Jiménez Ruiz");
                cmbCliente.Items.Add("Francisco Moreno Díaz");
                cmbCliente.Items.Add("Isabel Romero Herrera");
                
                if (cmbCliente.Items.Count > 0)
                    cmbCliente.SelectedIndex = 0;
            }

            if (cmbEmpleado != null)
            {
                cmbEmpleado.Items.Clear();
                cmbEmpleado.Items.Add("David Paredes - Vendedor");
                cmbEmpleado.Items.Add("Santiago Castaño - Supervisor");
                cmbEmpleado.Items.Add("Jhon Higuita - Administrador");
                cmbEmpleado.Items.Add("Andrea Silva - Cajera");
                cmbEmpleado.Items.Add("Carlos Ruiz - Vendedor");
                cmbEmpleado.Items.Add("Laura Gómez - Asistente");
                
                if (cmbEmpleado.Items.Count > 0)
                    cmbEmpleado.SelectedIndex = 0;
            }

            if (cmbEstado != null)
            {
                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("Pendiente");
                cmbEstado.Items.Add("Procesando");
                cmbEstado.Items.Add("Pagada");
                cmbEstado.Items.Add("Entregada");
                cmbEstado.Items.Add("Cancelada");
                cmbEstado.Items.Add("Anulada");
                
                if (cmbEstado.Items.Count > 0)
                    cmbEstado.SelectedIndex = 0;
            }
        }

        private void ConfigurarValidacion()
        {
            if (txtDescuento != null) txtDescuento.KeyPress += ValidarTextoNumerico_KeyPress;
            if (txtTotalIVA != null) txtTotalIVA.KeyPress += ValidarTextoNumerico_KeyPress;
            if (txtTotalFactura != null) txtTotalFactura.KeyPress += ValidarTextoNumerico_KeyPress;
            if (txtNroFactura != null) txtNroFactura.KeyPress += ValidarTextoAlfanumerico_KeyPress;

            if (txtDescuento != null) txtDescuento.TextChanged += CalcularTotales;
            if (txtTotalIVA != null) txtTotalIVA.TextChanged += CalcularTotales;
        }

        private void ValidarTextoNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as MaterialTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValidarTextoAlfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && 
                e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void CalcularTotales(object sender, EventArgs e)
        {
            try
            {
                decimal Subtotal = 100000;
                decimal Descuento = 0;
                decimal IVA = 0;

                if (decimal.TryParse(txtDescuento.Text, out Descuento))
                {
                    Subtotal -= Descuento;
                }

                if (decimal.TryParse(txtTotalIVA.Text, out IVA))
                {
                }
                else
                {
                    IVA = Subtotal * 0.19m;
                    txtTotalIVA.Text = IVA.ToString("N2");
                }

                decimal TotalFactura = Subtotal + IVA;
                txtTotalFactura.Text = TotalFactura.ToString("N2");
            }
            catch
            {
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DatosFactura DatosDeLaFactura = ObtenerDatosFactura();
                
                string MensajeExito = $"💾 FACTURA GUARDADA EXITOSAMENTE\n\n" +
                                     $"Número: {DatosDeLaFactura.NumeroFactura}\n" +
                                     $"Cliente: {DatosDeLaFactura.Cliente}\n" +
                                     $"Fecha: {DatosDeLaFactura.FechaFactura:dd/MM/yyyy}\n" +
                                     $"Total: ${DatosDeLaFactura.TotalFactura:N2}\n" +
                                     $"Estado: {DatosDeLaFactura.Estado}";
                
                MessageBox.Show(MensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var ResultadoConfirmacion = MessageBox.Show("¿Está seguro que desea salir sin guardar?", 
                "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (ResultadoConfirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
                this.Visible = false;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                MessageBox.Show("El número de factura es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroFactura.Focus();
                return false;
            }

            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return false;
            }

            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalFactura.Text))
            {
                MessageBox.Show("El total de la factura es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalFactura.Focus();
                return false;
            }

            if (!decimal.TryParse(txtTotalFactura.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("El total de la factura debe ser un valor válido mayor a cero", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalFactura.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            GenerarNumeroFactura();
            dtpFecha.Value = DateTime.Now;
            if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0;
            if (cmbEmpleado.Items.Count > 0) cmbEmpleado.SelectedIndex = 0;
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;
            txtDescuento.Clear();
            txtTotalIVA.Clear();
            txtTotalFactura.Clear();
            txtObservaciones.Clear();
            chkFacturaPagada.Checked = false;
            
            txtNroFactura.Focus();
        }

        private void lblNroFactura_Click(object sender, EventArgs e)
        {
            GenerarNumeroFactura();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex >= 0)
            {
                string ClienteSeleccionado = cmbCliente.SelectedItem.ToString();
                CalcularTotales(sender, e);
            }
        }

        public DatosFactura ObtenerDatosFactura()
        {
            if (!ValidarCampos()) return null;

            return new DatosFactura
            {
                NumeroFactura = txtNroFactura.Text.Trim(),
                FechaFactura = dtpFecha.Value,
                Cliente = cmbCliente.SelectedItem?.ToString() ?? "",
                Empleado = cmbEmpleado.SelectedItem?.ToString() ?? "",
                Estado = cmbEstado.SelectedItem?.ToString() ?? "Pendiente",
                Descuento = decimal.TryParse(txtDescuento.Text, out decimal desc) ? desc : 0,
                TotalIVA = decimal.TryParse(txtTotalIVA.Text, out decimal iva) ? iva : 0,
                TotalFactura = decimal.TryParse(txtTotalFactura.Text, out decimal total) ? total : 0,
                Observaciones = txtObservaciones.Text.Trim(),
                EsPagada = chkFacturaPagada.Checked,
                FechaCreacion = DateTime.Now
            };
        }

        public void CargarFactura(DatosFactura FacturaCarga)
        {
            if (FacturaCarga != null)
            {
                txtNroFactura.Text = FacturaCarga.NumeroFactura;
                dtpFecha.Value = FacturaCarga.FechaFactura;
                
                for (int i = 0; i < cmbCliente.Items.Count; i++)
                {
                    if (cmbCliente.Items[i].ToString().Contains(FacturaCarga.Cliente))
                    {
                        cmbCliente.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cmbEmpleado.Items.Count; i++)
                {
                    if (cmbEmpleado.Items[i].ToString().Contains(FacturaCarga.Empleado))
                    {
                        cmbEmpleado.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cmbEstado.Items.Count; i++)
                {
                    if (cmbEstado.Items[i].ToString() == FacturaCarga.Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }

                txtDescuento.Text = FacturaCarga.Descuento.ToString("N2");
                txtTotalIVA.Text = FacturaCarga.TotalIVA.ToString("N2");
                txtTotalFactura.Text = FacturaCarga.TotalFactura.ToString("N2");
                txtObservaciones.Text = FacturaCarga.Observaciones;
                chkFacturaPagada.Checked = FacturaCarga.EsPagada;
            }
        }
    }
}

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Models;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucCliente : UserControl
    {
        public ucCliente()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucCliente_Load(object sender, EventArgs e)
        {
            ConfigurarValidacion();
            ConectarManejadoresEventos();
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
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            RenombrarControles();
        }
        
        private void RenombrarControles()
        {
            if (lblNombreProducto != null) lblNombreProducto.Text = "Nombre Cliente";
            if (txtNombreProducto != null) txtNombreProducto.Name = "txtNombreCliente";
            
            if (lblCodigoReferencia != null) lblCodigoReferencia.Text = "Documento";
            if (txtCodigoReferencia != null) txtCodigoReferencia.Name = "txtDocumento";
            
            if (lblPrecioCompra != null) lblPrecioCompra.Text = "Dirección";
            if (txtPrecioCompra != null) txtPrecioCompra.Name = "txtDireccion";
            
            if (lblPrecioVenta != null) lblPrecioVenta.Text = "Teléfono";
            if (txtPrecioVenta != null) txtPrecioVenta.Name = "txtTelefono";
            
            if (materialLabel1 != null) materialLabel1.Text = "Correo Electrónico";
            if (materialTextBox1 != null) materialTextBox1.Name = "txtEmail";
            
            AgregarCasillasVerificacion();
            AgregarCampoObservaciones();
        }

        private void AgregarCasillasVerificacion()
        {
            CheckBox CasillaActivo = new CheckBox
            {
                Text = "Activo",
                Name = "chkActivo",
                Location = new Point(25, 39),
                Size = new Size(56, 17),
                Checked = true
            };
            
            this.Controls.Add(CasillaActivo);
        }
        
        private void AgregarCampoObservaciones()
        {
            TableLayoutPanel PanelObservaciones = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Fill,
                Name = "tlpNotas"
            };
            
            PanelObservaciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelObservaciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            PanelObservaciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            
            MaterialLabel EtiquetaObservaciones = new MaterialLabel
            {
                Text = "Observaciones",
                Depth = 0,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
                MouseState = MaterialSkin.MouseState.HOVER,
                Name = "lblNotas",
                AutoSize = true
            };
            
            MaterialMultiLineTextBox CampoObservaciones = new MaterialMultiLineTextBox
            {
                BackColor = Color.FromArgb(255, 255, 255),
                BorderStyle = BorderStyle.None,
                Depth = 0,
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
                ForeColor = Color.FromArgb(222, 0, 0, 0),
                MaxLength = 500,
                MouseState = MaterialSkin.MouseState.OUT,
                Name = "txtNotas",
                ScrollBars = RichTextBoxScrollBars.Vertical,
                TabStop = false
            };
            
            PanelObservaciones.Controls.Add(EtiquetaObservaciones, 0, 0);
            PanelObservaciones.Controls.Add(CampoObservaciones, 0, 1);
            
            tlpPrincipal.SetColumnSpan(PanelObservaciones, 2);
            tlpPrincipal.Controls.Add(PanelObservaciones, 0, 3);
        }

        private void ConfigurarValidacion()
        {
            if (txtPrecioVenta != null) txtPrecioVenta.KeyPress += ValidarTextoTelefono_KeyPress;
            if (txtCodigoReferencia != null) txtCodigoReferencia.KeyPress += ValidarTextoAlfanumerico_KeyPress;
            if (materialTextBox1 != null) materialTextBox1.Leave += ValidarCampoEmail_Leave;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DatosCliente DatosDelCliente = ObtenerDatosCliente();
                
                string MensajeExito = $"Cliente guardado exitosamente:\n\n" +
                                     $"Nombre: {DatosDelCliente.NombreCompleto}\n" +
                                     $"Documento: {DatosDelCliente.NumeroDocumento}\n" +
                                     $"Teléfono: {DatosDelCliente.NumeroTelefono}\n" +
                                     $"Email: {DatosDelCliente.CorreoElectronico}";
                
                MessageBox.Show(MensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var ResultadoConfirmacion = MessageBox.Show("¿Está seguro que desea salir sin guardar?", 
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (ResultadoConfirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
                this.Visible = false;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del cliente es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoReferencia.Text))
            {
                MessageBox.Show("El número de documento es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoReferencia.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                string TelefonoNumerico = Regex.Replace(txtPrecioVenta.Text, @"[^\d]", "");
                if (TelefonoNumerico.Length < 7 || TelefonoNumerico.Length > 15)
                {
                    MessageBox.Show("El teléfono debe tener entre 7 y 15 dígitos", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecioVenta.Focus();
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(materialTextBox1.Text))
            {
                string PatronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(materialTextBox1.Text, PatronEmail))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    materialTextBox1.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtCodigoReferencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            materialTextBox1.Clear();
            
            if (this.Controls["chkActivo"] is CheckBox CasillaActivo)
            {
                CasillaActivo.Checked = true;
            }
            
            if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel PanelObservaciones && 
                PanelObservaciones.Controls["txtNotas"] is MaterialMultiLineTextBox CampoObservaciones)
            {
                CampoObservaciones.Clear();
            }
            
            txtNombreProducto.Focus();
        }

        private void ValidarTextoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
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
        
        private void ValidarCampoEmail_Leave(object sender, EventArgs e)
        {
            TextBox CuadroTexto = sender as TextBox;
            if (!string.IsNullOrWhiteSpace(CuadroTexto.Text))
            {
                string PatronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(CuadroTexto.Text, PatronEmail))
                {
                    CuadroTexto.BackColor = Color.MistyRose;
                    
                    ToolTip AyudaEmergente = new ToolTip();
                    AyudaEmergente.IsBalloon = true;
                    AyudaEmergente.Show("Formato de email inválido", CuadroTexto, 0, -40, 3000);
                }
                else
                {
                    CuadroTexto.BackColor = SystemColors.Window;
                }
            }
            else
            {
                CuadroTexto.BackColor = SystemColors.Window;
            }
        }

        public void CargarCliente(DatosCliente ClienteCarga)
        {
            if (ClienteCarga != null)
            {
                if (this.Controls["chkActivo"] is CheckBox CasillaActivo)
                {
                    CasillaActivo.Checked = ClienteCarga.EstaActivo;
                }
                
                txtNombreProducto.Text = ClienteCarga.NombreCompleto;
                txtCodigoReferencia.Text = ClienteCarga.NumeroDocumento;
                txtPrecioCompra.Text = ClienteCarga.DireccionResidencia;
                txtPrecioVenta.Text = ClienteCarga.NumeroTelefono;
                materialTextBox1.Text = ClienteCarga.CorreoElectronico;
                
                if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel PanelObservaciones && 
                    PanelObservaciones.Controls["txtNotas"] is MaterialMultiLineTextBox CampoObservaciones)
                {
                    CampoObservaciones.Text = ClienteCarga.ObservacionesAdicionales;
                }
            }
        }

        public DatosCliente ObtenerDatosCliente()
        {
            if (!ValidarCampos()) return null;

            bool EstaActivo = true;
            if (this.Controls["chkActivo"] is CheckBox CasillaActivo)
            {
                EstaActivo = CasillaActivo.Checked;
            }
            
            string ObservacionesTexto = string.Empty;
            if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel PanelObservaciones && 
                PanelObservaciones.Controls["txtNotas"] is MaterialMultiLineTextBox CampoObservaciones)
            {
                ObservacionesTexto = CampoObservaciones.Text.Trim();
            }

            return new DatosCliente
            {
                EstaActivo = EstaActivo,
                NombreCompleto = txtNombreProducto.Text.Trim(),
                NumeroDocumento = txtCodigoReferencia.Text.Trim(),
                DireccionResidencia = txtPrecioCompra.Text.Trim(),
                NumeroTelefono = txtPrecioVenta.Text.Trim(),
                CorreoElectronico = materialTextBox1.Text.Trim(),
                TipoCliente = "General",
                ObservacionesAdicionales = ObservacionesTexto,
                FechaRegistro = DateTime.Now
            };
        }

        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }
}

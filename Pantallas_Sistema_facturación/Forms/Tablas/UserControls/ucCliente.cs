using MaterialSkin.Controls;
using Modelo;
using Negocio;
using Pantallas_Sistema_facturación.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucCliente : UserControl
    {
        private int idClienteSeleccionado = 0;

        private List<ModeloCliente> listaClientes;
        private int idCliente;

        public ucCliente()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucCliente_Load(object sender, EventArgs e)
        {
            ConfigurarValidacion();
            ConsultarListaClientes();
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

        public ModeloClienteForm ObtenerDatosCliente()
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

            return new ModeloClienteForm
            {
                IdCliente = idClienteSeleccionado,
                EstaActivo = EstaActivo,
                StrNombre = txtNombreProducto.Text.Trim(),
                NumDocumento = int.TryParse(txtCodigoReferencia.Text.Trim(), out int numDoc) ? numDoc : 0,
                StrDireccion = txtPrecioCompra.Text.Trim(),
                StrTelefono = txtPrecioVenta.Text.Trim(),
                StrEmail = materialTextBox1.Text.Trim(),
                TipoCliente = "General",
                StrUsuarioModifica = Environment.UserName,
                DtmFechaModifica = DateTime.Now
            };
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ModeloClienteForm cliente = ObtenerDatosCliente();

            if (cliente != null)
            {
                ModeloCliente modeloCliente = new ModeloCliente
                {
                    IdCliente = idClienteSeleccionado,
                    StrNombre = cliente.StrNombre,
                    NumDocumento = cliente.NumDocumento,
                    StrDireccion = cliente.StrDireccion,
                    StrTelefono = cliente.StrTelefono,
                    StrEmail = cliente.StrEmail,
                    DtmFechaModifica = DateTime.Now,
                    StrUsuarioModifica = Environment.UserName
                };

                NegocioCrearOActualizarCliente negocio = new NegocioCrearOActualizarCliente(modeloCliente);
                bool exito = negocio.Ejecutar();

                if (exito)
                {
                    MessageBox.Show("Cliente guardado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConsultarListaClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            materialTextBox2.Clear();

            idClienteSeleccionado = 0;

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
            if (CuadroTexto == null)
                return;
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

        public void CargarCliente(ModeloClienteForm ClienteCarga)
        {
            if (ClienteCarga != null)
            {
                idClienteSeleccionado = ClienteCarga.IdCliente;

                if (this.Controls["chkActivo"] is CheckBox CasillaActivo)
                {
                    CasillaActivo.Checked = ClienteCarga.EstaActivo;
                }

                txtNombreProducto.Text = ClienteCarga.StrNombre;
                txtCodigoReferencia.Text = ClienteCarga.NumDocumento.ToString();
                txtPrecioCompra.Text = ClienteCarga.StrDireccion;
                txtPrecioVenta.Text = ClienteCarga.StrTelefono;
                materialTextBox1.Text = ClienteCarga.StrEmail;
            }
        }

        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private object ConsultarListaClientes()
        {
            try
            {
                NegocioConsultaClientes negocio = new NegocioConsultaClientes();
                this.listaClientes = negocio.Ejecutar();

                List<object> listaParaGrid = new List<object>();

                if (this.listaClientes != null)
                {
                    foreach (var cliente in this.listaClientes)
                    {
                        listaParaGrid.Add(new
                        {
                            Id = cliente.IdCliente,
                            Nombre = cliente.StrNombre,
                            Documento = cliente.NumDocumento,
                            Direccion = cliente.StrDireccion,
                            Telefono = cliente.StrTelefono,
                            Email = cliente.StrEmail,
                            FechaModifica = cliente.DtmFechaModifica.ToString("g"),
                            UsuarioModifica = cliente.StrUsuarioModifica
                        });
                    }
                }

                dataGridViewListaClientes.DataSource = listaParaGrid;
                ConfigurarDataGridViewClientes();

                return listaParaGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar clientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataGridView GetDataGridViewListaClientes()
        {
            return dataGridViewListaClientes;
        }

        private void ConfigurarDataGridViewClientes()
        {
            if (dataGridViewListaClientes.Columns.Count > 0)
            {
                dataGridViewListaClientes.Columns["Id"].HeaderText = "ID";
                dataGridViewListaClientes.Columns["Nombre"].HeaderText = "Nombre";
                dataGridViewListaClientes.Columns["Documento"].HeaderText = "Documento";
                dataGridViewListaClientes.Columns["Direccion"].HeaderText = "Dirección";
                dataGridViewListaClientes.Columns["Telefono"].HeaderText = "Teléfono";
                dataGridViewListaClientes.Columns["Email"].HeaderText = "Email";
                dataGridViewListaClientes.Columns["FechaModifica"].HeaderText = "Fecha Modificación";
                dataGridViewListaClientes.Columns["UsuarioModifica"].HeaderText = "Usuario Modifica";
                dataGridViewListaClientes.AutoResizeColumns();
                dataGridViewListaClientes.ReadOnly = true;
                dataGridViewListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                dataGridViewListaClientes.CellClick += DataGridViewListaClientes_CellClick;
            }
        }

        private void DataGridViewListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridViewListaClientes.Rows[e.RowIndex].DataBoundItem != null)
                {
                    var filaSeleccionada = dataGridViewListaClientes.Rows[e.RowIndex];
                    var idClienteSeleccionadoLocal = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    var clienteSeleccionado = this.listaClientes.Find(c => Convert.ToInt32(c.IdCliente) == idClienteSeleccionadoLocal);

                    if (clienteSeleccionado != null)
                    {
                        LlenarFormularioConCliente(clienteSeleccionado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar el cliente: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LlenarFormularioConCliente(ModeloCliente cliente)
        {
            try
            {
                idClienteSeleccionado = cliente.IdCliente;
                materialTextBox2.Text = cliente.IdCliente.ToString();
                txtNombreProducto.Text = cliente.StrNombre ?? "";
                txtCodigoReferencia.Text = cliente.NumDocumento.ToString();
                txtPrecioCompra.Text = cliente.StrDireccion ?? "";
                txtPrecioVenta.Text = cliente.StrTelefono.ToString();
                materialTextBox1.Text = cliente.StrEmail ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialTextBox2.Text))
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(materialTextBox2.Text, out int idCliente))
            {
                MessageBox.Show("El ID del cliente no es válido. Seleccione un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar este cliente?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                NegocioEliminarCliente negocio = new NegocioEliminarCliente(idCliente);
                bool exito = negocio.Ejecutar();
                if (!exito)
                {
                    MessageBox.Show("Error al eliminar el cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LimpiarCampos();
                ConsultarListaClientes();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridViewListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

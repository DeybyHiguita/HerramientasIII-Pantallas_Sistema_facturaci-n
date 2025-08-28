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
            ConfigureFormContent();
        }

        private void ucCliente_Load(object sender, EventArgs e)
        {
            ConfigureValidation();
            
            // Conectar handlers de eventos
            ConnectEventHandlers();
        }
        
        private void ConnectEventHandlers()
        {
            // Conectar el evento click del botón actualizar
            if (btnActualizar != null)
            {
                btnActualizar.Click -= btnActualizar_Click;
                btnActualizar.Click += btnActualizar_Click;
            }
            
            // Conectar el evento click del botón salir
            if (btnSalir != null)
            {
                btnSalir.Click -= btnSalir_Click;
                btnSalir.Click += btnSalir_Click;
            }
        }

        private void ConfigureFormContent()
        {
            // Configuración específica para el formulario de clientes
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            
            // Corregir nombres de controles para mejor claridad
            RenameControls();
        }
        
        private void RenameControls()
        {
            // Renombrar controles con nombres más apropiados para clientes
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
            
            // Agregar un checkbox para el estado activo
            AddActiveCheckbox();
            
            // Agregar campo para notas
            AddNotesField();
        }

        private void AddActiveCheckbox()
        {
            // Crear un checkbox para marcar cliente como activo/inactivo
            CheckBox chkActivo = new CheckBox
            {
                Text = "Activo",
                Name = "chkActivo",
                Location = new Point(25, 39),
                Size = new Size(56, 17),
                Checked = true
            };
            
            this.Controls.Add(chkActivo);
        }
        
        private void AddNotesField()
        {
            // Crear una tabla para las notas
            TableLayoutPanel tlpNotas = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Fill,
                Name = "tlpNotas"
            };
            
            tlpNotas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNotas.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tlpNotas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            
            // Etiqueta para notas
            MaterialLabel lblNotas = new MaterialLabel
            {
                Text = "Observaciones",
                Depth = 0,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
                MouseState = MaterialSkin.MouseState.HOVER,
                Name = "lblNotas",
                AutoSize = true
            };
            
            // TextBox para notas
            MaterialMultiLineTextBox txtNotas = new MaterialMultiLineTextBox
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
            
            tlpNotas.Controls.Add(lblNotas, 0, 0);
            tlpNotas.Controls.Add(txtNotas, 0, 1);
            
            // Añadir al layout principal, extendiendo por dos columnas
            tlpPrincipal.SetColumnSpan(tlpNotas, 2);
            tlpPrincipal.Controls.Add(tlpNotas, 0, 3);
        }

        private void ConfigureValidation()
        {
            // Configurar eventos de validación
            if (txtPrecioVenta != null) txtPrecioVenta.KeyPress += PhoneTextBox_KeyPress;
            if (txtCodigoReferencia != null) txtCodigoReferencia.KeyPress += AlphanumericTextBox_KeyPress;
            if (materialTextBox1 != null) materialTextBox1.Leave += EmailTextBox_Leave;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Obtener los datos del cliente
                ClientData clientData = GetClientData();
                
                // Mostrar los datos en un formato más legible para demostrar la funcionalidad
                string message = $"Cliente guardado exitosamente:\n\n" +
                                $"Nombre: {clientData.Name}\n" +
                                $"Documento: {clientData.DocumentNumber}\n" +
                                $"Teléfono: {clientData.Phone}\n" +
                                $"Email: {clientData.Email}";
                
                MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Opcional: limpiar campos después de guardar
                // ClearFields();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea salir sin guardar?", 
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                // Limpiar campos y cerrar/ocultar el control
                ClearFields();
                this.Visible = false;
            }
        }

        private bool ValidateFields()
        {
            // Validar nombre del cliente
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del cliente es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return false;
            }

            // Validar documento
            if (string.IsNullOrWhiteSpace(txtCodigoReferencia.Text))
            {
                MessageBox.Show("El número de documento es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoReferencia.Focus();
                return false;
            }

            // Validar dirección (opcional)
            
            // Validar teléfono (opcional, pero debe tener formato correcto si se proporciona)
            if (!string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                string numericPhone = Regex.Replace(txtPrecioVenta.Text, @"[^\d]", "");
                if (numericPhone.Length < 7 || numericPhone.Length > 15)
                {
                    MessageBox.Show("El teléfono debe tener entre 7 y 15 dígitos", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecioVenta.Focus();
                    return false;
                }
            }

            // Validar email (opcional, pero debe tener formato correcto si se proporciona)
            if (!string.IsNullOrWhiteSpace(materialTextBox1.Text))
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(materialTextBox1.Text, pattern))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    materialTextBox1.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearFields()
        {
            txtNombreProducto.Clear();
            txtCodigoReferencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            materialTextBox1.Clear();
            
            if (this.Controls["chkActivo"] is CheckBox chkActivo)
            {
                chkActivo.Checked = true;
            }
            
            if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel tlpNotas && 
                tlpNotas.Controls["txtNotas"] is MaterialMultiLineTextBox txtNotas)
            {
                txtNotas.Clear();
            }
            
            txtNombreProducto.Focus();
        }

        // Validación para campos telefónicos
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, teclas de control y caracteres permitidos para teléfono
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        // Validación para campos alfanuméricos (documento)
        private void AlphanumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, guiones y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && 
                e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        
        // Validación para correo electrónico al perder el foco
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(textBox.Text, pattern))
                {
                    // Cambiar color de fondo para indicar error
                    textBox.BackColor = Color.MistyRose;
                    
                    // Opcionalmente mostrar un tooltip o mensaje sutil
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    toolTip.Show("Formato de email inválido", textBox, 0, -40, 3000);
                }
                else
                {
                    // Restaurar color normal
                    textBox.BackColor = SystemColors.Window;
                }
            }
            else
            {
                // Restaurar color normal si está vacío
                textBox.BackColor = SystemColors.Window;
            }
        }

        // Métodos públicos para manejar datos desde el formulario principal
        public void LoadClient(ClientData client)
        {
            if (client != null)
            {
                if (this.Controls["chkActivo"] is CheckBox chkActivo)
                {
                    chkActivo.Checked = client.Active;
                }
                
                txtNombreProducto.Text = client.Name;
                txtCodigoReferencia.Text = client.DocumentNumber;
                txtPrecioCompra.Text = client.Address;
                txtPrecioVenta.Text = client.Phone;
                materialTextBox1.Text = client.Email;
                
                // Cargar las notas
                if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel tlpNotas && 
                    tlpNotas.Controls["txtNotas"] is MaterialMultiLineTextBox txtNotas)
                {
                    txtNotas.Text = client.Notes;
                }
            }
        }

        public ClientData GetClientData()
        {
            if (!ValidateFields()) return null;

            bool isActive = true;
            if (this.Controls["chkActivo"] is CheckBox chkActivo)
            {
                isActive = chkActivo.Checked;
            }
            
            string notes = string.Empty;
            if (tlpPrincipal.Controls["tlpNotas"] is TableLayoutPanel tlpNotas && 
                tlpNotas.Controls["txtNotas"] is MaterialMultiLineTextBox txtNotas)
            {
                notes = txtNotas.Text.Trim();
            }

            return new ClientData
            {
                Active = isActive,
                Name = txtNombreProducto.Text.Trim(),
                DocumentNumber = txtCodigoReferencia.Text.Trim(),
                Address = txtPrecioCompra.Text.Trim(),
                Phone = txtPrecioVenta.Text.Trim(),
                Email = materialTextBox1.Text.Trim(),
                ClientType = "General", // Valor por defecto ya que no se usa el tipo de cliente
                Notes = notes,
                RegistrationDate = DateTime.Now
            };
        }

        // Métodos de eventos originales - mantener vacíos si no se necesitan
        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }
}

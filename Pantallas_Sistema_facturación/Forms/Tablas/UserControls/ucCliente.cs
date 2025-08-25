using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Clientes.UserControls
{
    public partial class ucCliente : UserControl
    {
        public ucCliente()
        {
            InitializeComponent();
            ConfigureFormContent();
        }
        
        private void ConfigureFormContent()
        {
            // Configuración adicional después de InitializeComponent si es necesaria
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Lógica para guardar/actualizar cliente
                MessageBox.Show("Cliente guardado exitosamente", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Limpiar campos después de guardar
                ClearFields();
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
            bool isValid = true;
            
            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            
            // Validar documento
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("El documento es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }
            
            // Validar email si se proporciona
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("El formato del email no es válido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            
            return isValid;
        }
        
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
        private void ClearFields()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }
        
        // Evento para formatear automáticamente el documento
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        // Evento para formatear automáticamente el teléfono
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, espacios, guiones y paréntesis
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }
    }
}

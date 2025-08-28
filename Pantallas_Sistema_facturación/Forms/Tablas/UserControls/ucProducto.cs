using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucProducto : UserControl
    {
        private OpenFileDialog openFileDialog;

        public ucProducto()
        {
            InitializeComponent();
            ConfigureFormContent();
        }

        private void ucProducto_Load(object sender, EventArgs e)
        {
            InitializeCategories();
            ConfigureValidation();
        }

        private void ConfigureFormContent()
        {
            // Configuración específica para el formulario de productos
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            
            // Configurar el diálogo de archivos
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar imagen del producto";
        }

        private void InitializeCategories()
        {
            // Llenar el ComboBox con categorías de ejemplo
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Electrónicos");
            cmbCategoria.Items.Add("Ropa y Accesorios");
            cmbCategoria.Items.Add("Hogar y Jardín");
            cmbCategoria.Items.Add("Deportes");
            cmbCategoria.Items.Add("Libros");
            cmbCategoria.Items.Add("Juguetes");
            cmbCategoria.Items.Add("Alimentación");
            cmbCategoria.Items.Add("Belleza y Cuidado Personal");
            
            // Seleccionar el primer elemento por defecto
            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }
        }

        private void ConfigureValidation()
        {
            // Configurar eventos de validación
            txtPrecioCompra.KeyPress += NumericTextBox_KeyPress;
            txtPrecioVenta.KeyPress += NumericTextBox_KeyPress;
            txtCantidadStock.KeyPress += IntegerTextBox_KeyPress;
            txtCodigoReferencia.KeyPress += AlphanumericTextBox_KeyPress;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Lógica para guardar/actualizar producto
                MessageBox.Show("Producto guardado exitosamente", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Limpiar campos después de guardar si se desea
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

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen.Text = openFileDialog.FileName;
            }
        }

        private bool ValidateFields()
        {
            // Validar nombre del producto
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return false;
            }

            // Validar código de referencia
            if (string.IsNullOrWhiteSpace(txtCodigoReferencia.Text))
            {
                MessageBox.Show("El código de referencia es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoReferencia.Focus();
                return false;
            }

            // Validar precio de compra
            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MessageBox.Show("El precio de compra es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) || precioCompra < 0)
            {
                MessageBox.Show("El precio de compra debe ser un número válido mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return false;
            }

            // Validar precio de venta
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("El precio de venta es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) || precioVenta < 0)
            {
                MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            // Validar que el precio de venta sea mayor que el de compra
            if (precioVenta < precioCompra)
            {
                MessageBox.Show("El precio de venta debe ser mayor o igual al precio de compra", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            // Validar cantidad en stock
            if (string.IsNullOrWhiteSpace(txtCantidadStock.Text))
            {
                MessageBox.Show("La cantidad en stock es requerida", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadStock.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidadStock.Text, out int cantidadStock) || cantidadStock < 0)
            {
                MessageBox.Show("La cantidad en stock debe ser un número entero mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadStock.Focus();
                return false;
            }

            // Validar categoría
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtNombreProducto.Clear();
            txtCodigoReferencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCantidadStock.Clear();
            txtRutaImagen.Clear();
            txtDetallesProducto.Clear();
            chkActivo.Checked = false;
            
            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }
            
            txtNombreProducto.Focus();
        }

        // Validación para campos numéricos decimales (precios)
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto decimal, backspace y delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Convertir coma en punto
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
        }

        // Validación para campos numéricos enteros (cantidad)
        private void IntegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validación para campos alfanuméricos (código de referencia)
        private void AlphanumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, guiones y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        // Métodos públicos para manejar datos desde el formulario principal
        public void LoadProduct(ProductData product)
        {
            if (product != null)
            {
                chkActivo.Checked = product.Active;
                txtNombreProducto.Text = product.Name;
                txtCodigoReferencia.Text = product.Code;
                txtPrecioCompra.Text = product.PurchasePrice.ToString("F2");
                txtPrecioVenta.Text = product.SalePrice.ToString("F2");
                txtCantidadStock.Text = product.Stock.ToString();
                txtRutaImagen.Text = product.ImagePath;
                txtDetallesProducto.Text = product.Details;
                
                // Seleccionar la categoría si existe
                int categoryIndex = cmbCategoria.Items.IndexOf(product.Category);
                if (categoryIndex >= 0)
                {
                    cmbCategoria.SelectedIndex = categoryIndex;
                }
            }
        }

        public ProductData GetProductData()
        {
            if (!ValidateFields()) return null;

            return new ProductData
            {
                Active = chkActivo.Checked,
                Name = txtNombreProducto.Text.Trim(),
                Code = txtCodigoReferencia.Text.Trim(),
                PurchasePrice = decimal.Parse(txtPrecioCompra.Text),
                SalePrice = decimal.Parse(txtPrecioVenta.Text),
                Stock = int.Parse(txtCantidadStock.Text),
                Category = cmbCategoria.SelectedItem?.ToString() ?? "",
                ImagePath = txtRutaImagen.Text.Trim(),
                Details = txtDetallesProducto.Text.Trim()
            };
        }
    }

    // Clase para manejar datos del producto
    public class ProductData
    {
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
        public string Details { get; set; }
    }
}

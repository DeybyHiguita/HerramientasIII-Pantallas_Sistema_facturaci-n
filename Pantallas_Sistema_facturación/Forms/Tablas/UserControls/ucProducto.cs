using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturación.Models;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucProducto : UserControl
    {
        private OpenFileDialog DialogoSeleccionArchivo;

        public ucProducto()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucProducto_Load(object sender, EventArgs e)
        {
            InicializarCategorias();
            ConfigurarValidacion();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            
            DialogoSeleccionArchivo = new OpenFileDialog();
            DialogoSeleccionArchivo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
            DialogoSeleccionArchivo.Title = "Seleccionar imagen del producto";
        }

        private void InicializarCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Electrónicos");
            cmbCategoria.Items.Add("Ropa y Accesorios");
            cmbCategoria.Items.Add("Hogar y Jardín");
            cmbCategoria.Items.Add("Deportes");
            cmbCategoria.Items.Add("Libros");
            cmbCategoria.Items.Add("Juguetes");
            cmbCategoria.Items.Add("Alimentación");
            cmbCategoria.Items.Add("Belleza y Cuidado Personal");
            
            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }
        }

        private void ConfigurarValidacion()
        {
            txtPrecioCompra.KeyPress += ValidarTextoNumerico_KeyPress;
            txtPrecioVenta.KeyPress += ValidarTextoNumerico_KeyPress;
            txtCantidadStock.KeyPress += ValidarTextoEntero_KeyPress;
            txtCodigoReferencia.KeyPress += ValidarTextoAlfanumerico_KeyPress;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Producto guardado exitosamente", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Está seguro que desea salir sin guardar?", 
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (Resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                this.Visible = false;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            if (DialogoSeleccionArchivo.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen.Text = DialogoSeleccionArchivo.FileName;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoReferencia.Text))
            {
                MessageBox.Show("El código de referencia es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoReferencia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MessageBox.Show("El precio de compra es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal PrecioCompra) || PrecioCompra < 0)
            {
                MessageBox.Show("El precio de compra debe ser un número válido mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("El precio de venta es requerido", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out decimal PrecioVenta) || PrecioVenta < 0)
            {
                MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (PrecioVenta < PrecioCompra)
            {
                MessageBox.Show("El precio de venta debe ser mayor o igual al precio de compra", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadStock.Text))
            {
                MessageBox.Show("La cantidad en stock es requerida", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadStock.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidadStock.Text, out int CantidadStock) || CantidadStock < 0)
            {
                MessageBox.Show("La cantidad en stock debe ser un número entero mayor o igual a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadStock.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
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

        private void ValidarTextoNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            TextBox CuadroTexto = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && CuadroTexto.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
        }

        private void ValidarTextoEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarTextoAlfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        public void CargarProducto(DatosProducto ProductoCarga)
        {
            if (ProductoCarga != null)
            {
                chkActivo.Checked = ProductoCarga.EstaActivo;
                txtNombreProducto.Text = ProductoCarga.NombreProducto;
                txtCodigoReferencia.Text = ProductoCarga.CodigoReferencia;
                txtPrecioCompra.Text = ProductoCarga.PrecioCompra.ToString("F2");
                txtPrecioVenta.Text = ProductoCarga.PrecioVenta.ToString("F2");
                txtCantidadStock.Text = ProductoCarga.CantidadStock.ToString();
                txtRutaImagen.Text = ProductoCarga.RutaImagenProducto;
                txtDetallesProducto.Text = ProductoCarga.DetallesAdicionales;
                
                int IndiceCategoria = cmbCategoria.Items.IndexOf(ProductoCarga.CategoriaProducto);
                if (IndiceCategoria >= 0)
                {
                    cmbCategoria.SelectedIndex = IndiceCategoria;
                }
            }
        }

        public DatosProducto ObtenerDatosProducto()
        {
            if (!ValidarCampos()) return null;

            return new DatosProducto
            {
                EstaActivo = chkActivo.Checked,
                NombreProducto = txtNombreProducto.Text.Trim(),
                CodigoReferencia = txtCodigoReferencia.Text.Trim(),
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                CantidadStock = int.Parse(txtCantidadStock.Text),
                CategoriaProducto = cmbCategoria.SelectedItem?.ToString() ?? "",
                RutaImagenProducto = txtRutaImagen.Text.Trim(),
                DetallesAdicionales = txtDetallesProducto.Text.Trim()
            };
        }
    }
}

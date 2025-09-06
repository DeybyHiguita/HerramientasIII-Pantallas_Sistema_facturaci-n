using MaterialSkin.Controls;
using Modelo;
using Negocio;
using Pantallas_Sistema_facturación.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucProducto : UserControl
    {
        private OpenFileDialog DialogoSeleccionArchivo;
        public List<ModeloProducto> listaProductos;

        public ucProducto()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucProducto_Load(object sender, EventArgs e)
        {
            InicializarCategorias();
            ConfigurarValidacion();
            ConsultarListaProductos();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?", 
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
            if (Resultado == DialogResult.Yes)
            {
                NegocioEliminarProducto negocio = new NegocioEliminarProducto(int.Parse(txtIdProducto.Text));
                bool exito = negocio.Ejecutar();
                if (!exito)
                {
                    MessageBox.Show("Error al eliminar el producto", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LimpiarCampos();
                ConsultarListaProductos();
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
            txtIdProducto.Clear();
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

        public ModeloProductoForm ObtenerDatosProducto()
        {
            if (!ValidarCampos()) return null;

            return new ModeloProductoForm
            {
                IdProducto = txtIdProducto.Text.Trim() == "" ? 0 : int.Parse(txtIdProducto.Text.Trim()),
                StrNombre = txtNombreProducto.Text.Trim(),
                StrCodigo = txtCodigoReferencia.Text.Trim(),
                NumPrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim()),
                NumPrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim()),
                IdCategoria = cmbCategoria.SelectedIndex + 1,
                StrDetalle = txtDetallesProducto.Text.Trim(),
                strFoto = txtRutaImagen.Text.Trim(),
                NumStock = int.Parse(txtCantidadStock.Text.Trim()),
                DtmFechaModifica = DateTime.Now,
                StrUsuarioModifica = Environment.UserName
            };
        }

        private void ConsultarListaProductos()
        {
            try
            {
                NegocioConsultaProductos negocio = new NegocioConsultaProductos();
                this.listaProductos = negocio.Ejecutar();

                List<object> listaParaGrid = new List<object>();

                if (this.listaProductos != null)
                {
                    foreach (var producto in this.listaProductos)
                    {
                        listaParaGrid.Add(new
                        {
                            Id = producto.IdProducto,
                            Nombre = producto.StrNombre,
                            Codigo = producto.StrCodigo,
                            PrecioCompra = producto.NumPrecioCompra,
                            PrecioVenta = producto.NumPrecioVenta,
                            Categoria = producto.IdCategoria.ToString(),
                            Detalle = producto.StrDetalle,
                            Stock = producto.NumStock,
                            FechaModifica = producto.DtmFechaModifica.ToString("g")
                        });
                    }
                }

                dataGridViewListaProductos.DataSource = listaParaGrid;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            if (dataGridViewListaProductos.Columns.Count > 0)
            {
                dataGridViewListaProductos.Columns["Id"].HeaderText = "ID";
                dataGridViewListaProductos.Columns["Nombre"].HeaderText = "Nombre";
                dataGridViewListaProductos.Columns["Codigo"].HeaderText = "Código";
                dataGridViewListaProductos.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                dataGridViewListaProductos.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                dataGridViewListaProductos.Columns["Stock"].HeaderText = "Stock";
                dataGridViewListaProductos.Columns["Categoria"].HeaderText = "Categoría";
                dataGridViewListaProductos.Columns["FechaModifica"].HeaderText = "Fecha Modificación";
                dataGridViewListaProductos.AutoResizeColumns();
                dataGridViewListaProductos.ReadOnly = true;
                dataGridViewListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                // Agregar evento de clic para seleccionar producto
                dataGridViewListaProductos.CellClick += DataGridViewListaProductos_CellClick;
            }
        }

        private void DataGridViewListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridViewListaProductos.Rows[e.RowIndex].DataBoundItem != null)
                {
                    var filaSeleccionada = dataGridViewListaProductos.Rows[e.RowIndex];
                    var idProducto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    var productoSeleccionado = this.listaProductos.Find(p => p.IdProducto == idProducto);
                    
                    if (productoSeleccionado != null)
                    {
                        LlenarFormularioConProducto(productoSeleccionado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar el producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarFormularioConProducto(ModeloProducto producto)
        {
            try
            {
                txtIdProducto.Text = producto.IdProducto.ToString();
                txtNombreProducto.Text = producto.StrNombre ?? "";
                txtCodigoReferencia.Text = producto.StrCodigo ?? "";
                txtPrecioCompra.Text = producto.NumPrecioCompra.ToString("F2");
                txtPrecioVenta.Text = producto.NumPrecioVenta.ToString("F2");
                txtCantidadStock.Text = producto.NumStock.ToString();
               
                if (producto.IdCategoria > 0 && producto.IdCategoria <= cmbCategoria.Items.Count)
                {
                    cmbCategoria.SelectedIndex = producto.IdCategoria - 1;
                }
                else
                {
                    cmbCategoria.SelectedIndex = 0;
                }
                txtDetallesProducto.Text = producto.StrDetalle ?? "";
                txtRutaImagen.Text = producto.strFoto ?? "";
                chkActivo.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            ModeloProductoForm producto = ObtenerDatosProducto();

            if (producto != null)
            {
                ModeloProducto modeloProducto = new ModeloProducto
                {
                    IdProducto = producto.IdProducto,
                    StrNombre = producto.StrNombre,
                    StrCodigo = producto.StrCodigo,
                    NumPrecioCompra = producto.NumPrecioCompra,
                    NumPrecioVenta = producto.NumPrecioVenta,
                    IdCategoria = producto.IdCategoria,
                    StrDetalle = producto.StrDetalle,
                    strFoto = producto.strFoto,
                    NumStock = producto.NumStock,
                    DtmFechaModifica = producto.DtmFechaModifica,
                    StrUsuarioModifica = producto.StrUsuarioModifica
                };

                NegocioCrearActualizarProducto negocio = new NegocioCrearActualizarProducto(modeloProducto);
                bool exito = negocio.Ejecutar();

                if (exito)
                {
                    MessageBox.Show("Producto guardado exitosamente", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ConsultarListaProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

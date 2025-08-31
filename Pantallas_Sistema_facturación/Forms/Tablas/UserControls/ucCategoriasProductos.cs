using Pantallas_Sistema_facturación.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucCategoriasProductos : UserControl
    {
        public ucCategoriasProductos()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string MensajeExito = $"Categoría guardada exitosamente";
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
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("El ID de la categoría es requerido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            if (!int.TryParse(txtId.Text.Trim(), out int IdentificadorCategoria) || IdentificadorCategoria <= 0)
            {
                MessageBox.Show("El ID debe ser un número entero válido mayor a 0", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombrecategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría es requerido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrecategoria.Focus();
                return false;
            }

            if (txtNombrecategoria.Text.Trim().Length < 3)
            {
                MessageBox.Show("El nombre de la categoría debe tener al menos 3 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrecategoria.Focus();
                return false;
            }

            string NombreCategoriaValidacion = txtNombrecategoria.Text.Trim();
            if (NombreCategoriaValidacion.Any(c => char.IsDigit(c) || "!@#$%^&*()_+=[]{}|\\:;\"'<>?/".Contains(c)))
            {
                MessageBox.Show("El nombre de la categoría no debe contener números ni caracteres especiales", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrecategoria.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombrecategoria.Clear();
            txtId.Focus();
        }

        public DatosCategoria ObtenerDatosCategoria()
        {
            if (!ValidarCampos()) return null;

            return new DatosCategoria
            {
                IdentificadorCategoria = int.Parse(txtId.Text.Trim()),
                NombreCategoria = txtNombrecategoria.Text.Trim()
            };
        }

        public void CargarCategoria(DatosCategoria CategoriaCarga)
        {
            if (CategoriaCarga != null)
            {
                txtId.Text = CategoriaCarga.IdentificadorCategoria.ToString();
                txtNombrecategoria.Text = CategoriaCarga.NombreCategoria;
            }
        }

        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }

    public class DatosCategoria
    {
        public int IdentificadorCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public DatosCategoria()
        {
            IdentificadorCategoria = 0;
            NombreCategoria = string.Empty;
        }

        public bool ValidarDatos()
        {
            return IdentificadorCategoria > 0 && 
                   !string.IsNullOrWhiteSpace(NombreCategoria) && 
                   NombreCategoria.Length >= 3;
        }

        public override string ToString()
        {
            return $"Categoría: {NombreCategoria} (ID: {IdentificadorCategoria})";
        }
    }
}

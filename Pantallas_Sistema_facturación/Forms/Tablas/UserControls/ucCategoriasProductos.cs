using Pantallas_Sistema_facturación.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Tablas.UserControls
{
    public partial class ucCategoriasProductos : UserControl
    {
        public ucCategoriasProductos()
        {
            InitializeComponent();
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
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Obtiene los datos de la categoría ingresados en el formulario
        /// </summary>
        /// <returns>Datos de la categoría o null si hay errores de validación</returns>
        public DatosCategoria ObtenerDatosCategoria()
        {
            if (!ValidarCampos()) return null;

            return new DatosCategoria
            {
                IdentificadorCategoria = int.Parse(txtId.Text.Trim()),
                NombreCategoria = txtNombrecategoria.Text.Trim()
            };
        }

        /// <summary>
        /// Carga los datos de una categoría en el formulario
        /// </summary>
        /// <param name="categoriaCarga">Datos de la categoría a cargar</param>
        public void CargarCategoria(DatosCategoria categoriaCarga)
        {
            if (categoriaCarga != null)
            {
                txtId.Text = categoriaCarga.IdentificadorCategoria.ToString();
                txtNombrecategoria.Text = categoriaCarga.NombreCategoria;
            }
        }
    }

    /// <summary>
    /// Representa los datos de una categoría de producto
    /// </summary>
    public class DatosCategoria
    {
        /// <summary>
        /// Identificador único de la categoría
        /// </summary>
        public int IdentificadorCategoria { get; set; }

        /// <summary>
        /// Nombre descriptivo de la categoría
        /// </summary>
        public string NombreCategoria { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public DatosCategoria()
        {
            IdentificadorCategoria = 0;
            NombreCategoria = string.Empty;
        }

        /// <summary>
        /// Valida que los datos de la categoría sean correctos
        /// </summary>
        /// <returns>Verdadero si los datos son válidos</returns>
        public bool ValidarDatos()
        {
            return IdentificadorCategoria > 0 && 
                   !string.IsNullOrWhiteSpace(NombreCategoria) && 
                   NombreCategoria.Length >= 3;
        }

        /// <summary>
        /// Obtiene una representación en cadena de la categoría
        /// </summary>
        /// <returns>Representación en cadena de la categoría</returns>
        public override string ToString()
        {
            return $"Categoría: {NombreCategoria} (ID: {IdentificadorCategoria})";
        }
    }
}

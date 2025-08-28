using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_facturación.Models
{
    /// <summary>
    /// Representa los datos de un producto en el sistema de facturación.
    /// </summary>
    public class DatosProducto
    {
        /// <summary>
        /// Indica si el producto está activo o no
        /// </summary>
        public bool EstaActivo { get; set; }
        
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string NombreProducto { get; set; }
        
        /// <summary>
        /// Código único de referencia del producto
        /// </summary>
        public string CodigoReferencia { get; set; }
        
        /// <summary>
        /// Precio de compra del producto
        /// </summary>
        public decimal PrecioCompra { get; set; }
        
        /// <summary>
        /// Precio de venta del producto
        /// </summary>
        public decimal PrecioVenta { get; set; }
        
        /// <summary>
        /// Cantidad disponible en inventario
        /// </summary>
        public int CantidadStock { get; set; }
        
        /// <summary>
        /// Categoría a la que pertenece el producto
        /// </summary>
        public string CategoriaProducto { get; set; }
        
        /// <summary>
        /// Ruta del archivo de imagen del producto
        /// </summary>
        public string RutaImagenProducto { get; set; }
        
        /// <summary>
        /// Detalles adicionales del producto
        /// </summary>
        public string DetallesAdicionales { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public DatosProducto()
        {
            EstaActivo = true;
            NombreProducto = string.Empty;
            CodigoReferencia = string.Empty;
            PrecioCompra = 0m;
            PrecioVenta = 0m;
            CantidadStock = 0;
            CategoriaProducto = string.Empty;
            RutaImagenProducto = string.Empty;
            DetallesAdicionales = string.Empty;
        }

        /// <summary>
        /// Calcula el margen de ganancia del producto
        /// </summary>
        /// <returns>Margen de ganancia en porcentaje</returns>
        public decimal CalcularMargenGanancia()
        {
            if (PrecioCompra == 0) return 0;
            return ((PrecioVenta - PrecioCompra) / PrecioCompra) * 100;
        }

        /// <summary>
        /// Valida que todos los campos requeridos estén completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos están completos</returns>
        public bool ValidarCamposRequeridos()
        {
            return !string.IsNullOrWhiteSpace(NombreProducto) && 
                   !string.IsNullOrWhiteSpace(CodigoReferencia) &&
                   PrecioCompra > 0 && 
                   PrecioVenta > 0;
        }

        /// <summary>
        /// Obtiene una representación en cadena de los datos del producto
        /// </summary>
        /// <returns>Representación en cadena del producto</returns>
        public override string ToString()
        {
            return $"Producto: {NombreProducto} - Código: {CodigoReferencia}";
        }
    }
}

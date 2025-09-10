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
    public class ModeloProductoForm
    {
        /// <summary>
        /// Identificador único del producto
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string StrNombre { get; set; }

        /// <summary>
        /// Código único de referencia del producto
        /// </summary>
        public string StrCodigo { get; set; }

        /// <summary>
        /// Precio de compra del producto
        /// </summary>
        public decimal NumPrecioCompra { get; set; }

        /// <summary>
        /// Precio de venta del producto
        /// </summary>
        public decimal NumPrecioVenta { get; set; }

        /// <summary>
        /// Identificador de la categoría del producto
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Detalles adicionales del producto
        /// </summary>
        public string StrDetalle { get; set; }

        /// <summary>
        /// Ruta del archivo de imagen del producto
        /// </summary>
        public string strFoto { get; set; }

        /// <summary>
        /// Cantidad disponible en inventario
        /// </summary>
        public int NumStock { get; set; }

        /// <summary>
        /// Fecha de última modificación
        /// </summary>
        public DateTime DtmFechaModifica { get; set; }

        /// <summary>
        /// Usuario que realizó la última modificación
        /// </summary>
        public string StrUsuarioModifica { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ModeloProductoForm()
        {
            IdProducto = 0;
            StrNombre = string.Empty;
            StrCodigo = string.Empty;
            NumPrecioCompra = decimal.MinValue;
            NumPrecioVenta = decimal.MinValue;
            IdCategoria = 0;
            StrDetalle = string.Empty;
            strFoto = string.Empty;
            NumStock = 0;
            DtmFechaModifica = DateTime.MinValue;
            StrUsuarioModifica = string.Empty;
        }

        /// <summary>
        /// Obtiene una representación en cadena de los datos del producto
        /// </summary>
        /// <returns>Representación en cadena del producto</returns>
        public override string ToString()
        {
            return $"Producto: {StrNombre} - Código: {StrCodigo}";
        }
    }
}
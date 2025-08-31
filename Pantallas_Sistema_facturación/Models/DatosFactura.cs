using System;

namespace Pantallas_Sistema_facturación.Models
{
    /// <summary>
    /// Representa los datos de una factura en el sistema de facturación.
    /// </summary>
    public class DatosFactura
    {
        /// <summary>
        /// Número único de la factura
        /// </summary>
        public string NumeroFactura { get; set; }

        /// <summary>
        /// Fecha de emisión de la factura
        /// </summary>
        public DateTime FechaFactura { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Cliente { get; set; }

        /// <summary>
        /// Nombre del empleado que genera la factura
        /// </summary>
        public string Empleado { get; set; }

        /// <summary>
        /// Estado de la factura (Pendiente, Procesando, Pagada, Entregada, Cancelada, Anulada)
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Monto de descuento aplicado
        /// </summary>
        public decimal Descuento { get; set; }

        /// <summary>
        /// Monto del impuesto (IVA)
        /// </summary>
        public decimal TotalIVA { get; set; }

        /// <summary>
        /// Monto total de la factura
        /// </summary>
        public decimal TotalFactura { get; set; }

        /// <summary>
        /// Subtotal antes de impuestos y descuentos
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Observaciones adicionales de la factura
        /// </summary>
        public string Observaciones { get; set; }

        /// <summary>
        /// Indica si la factura está pagada
        /// </summary>
        public bool EsPagada { get; set; }

        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public DatosFactura()
        {
            NumeroFactura = string.Empty;
            FechaFactura = DateTime.Now;
            Cliente = string.Empty;
            Empleado = string.Empty;
            Estado = "Pendiente";
            Descuento = 0m;
            TotalIVA = 0m;
            TotalFactura = 0m;
            SubTotal = 0m;
            Observaciones = string.Empty;
            EsPagada = false;
            FechaCreacion = DateTime.Now;
        }

        /// <summary>
        /// Calcula el subtotal basado en el total y el IVA
        /// </summary>
        public void CalcularSubTotal()
        {
            SubTotal = TotalFactura - TotalIVA + Descuento;
        }

        /// <summary>
        /// Valida que los campos requeridos estén completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos están completos</returns>
        public bool ValidarCamposRequeridos()
        {
            return !string.IsNullOrWhiteSpace(NumeroFactura) &&
                   !string.IsNullOrWhiteSpace(Cliente) &&
                   !string.IsNullOrWhiteSpace(Empleado) &&
                   TotalFactura > 0;
        }

        /// <summary>
        /// Retorna una representación textual de la factura
        /// </summary>
        /// <returns>Representación en texto de la factura</returns>
        public override string ToString()
        {
            return $"{NumeroFactura} - {Cliente} (${TotalFactura:N2})";
        }
    }
}
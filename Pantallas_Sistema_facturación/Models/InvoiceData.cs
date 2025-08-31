using System;
using System.Collections.Generic;

namespace Pantallas_Sistema_facturaci�n.Models
{
    /// <summary>
    /// Representa los datos de una factura en el sistema de facturaci�n.
    /// </summary>
    public class InvoiceData
    {
        /// <summary>
        /// N�mero �nico de la factura
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Fecha de emisi�n de la factura
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Nombre del empleado que genera la factura
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Estado de la factura (Pendiente, Pagada, Anulada, etc.)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Porcentaje de descuento aplicado
        /// </summary>
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Monto del impuesto (IVA)
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Monto total de la factura
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Subtotal antes de impuestos y descuentos
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public InvoiceData()
        {
            InvoiceNumber = string.Empty;
            InvoiceDate = DateTime.Now;
            ClientName = string.Empty;
            EmployeeName = string.Empty;
            Status = "Pendiente";
            DiscountPercentage = 0;
            TaxAmount = 0;
            TotalAmount = 0;
            SubTotal = 0;
        }

        /// <summary>
        /// Retorna una representaci�n textual de la factura
        /// </summary>
        /// <returns>Representaci�n en texto de la factura</returns>
        public override string ToString()
        {
            return $"{InvoiceNumber} - {ClientName} (${TotalAmount:F2})";
        }
    }
}
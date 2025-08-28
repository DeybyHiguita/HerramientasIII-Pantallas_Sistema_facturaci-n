using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturación.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturación.
    /// </summary>
    public class DatosCliente
    {
        /// <summary>
        /// Indica si el cliente está activo o no
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Número de documento de identidad del cliente
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Dirección del cliente
        /// </summary>
        public string DireccionResidencia { get; set; }

        /// <summary>
        /// Número telefónico del cliente
        /// </summary>
        public string NumeroTelefono { get; set; }

        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicación)
        /// </summary>
        [Obsolete("Esta propiedad no se utiliza en la aplicación actual, pero se mantiene por compatibilidad")]
        public string TipoCliente { get; set; } = "General";

        /// <summary>
        /// Observaciones o notas adicionales sobre el cliente
        /// </summary>
        public string ObservacionesAdicionales { get; set; }

        /// <summary>
        /// Fecha de registro del cliente
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public DatosCliente()
        {
            EstaActivo = true;
            NombreCompleto = string.Empty;
            NumeroDocumento = string.Empty;
            DireccionResidencia = string.Empty;
            NumeroTelefono = string.Empty;
            CorreoElectronico = string.Empty;
            ObservacionesAdicionales = string.Empty;
            FechaRegistro = DateTime.Now;
        }

        /// <summary>
        /// Valida el formato del email
        /// </summary>
        /// <returns>Verdadero si el email tiene un formato válido</returns>
        public bool ValidarFormatoEmail()
        {
            if (string.IsNullOrWhiteSpace(CorreoElectronico))
                return true; // Un email vacío es válido ya que podría ser opcional

            // Patrón básico de validación de correo electrónico
            string PatronValidacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(CorreoElectronico, PatronValidacion);
        }

        /// <summary>
        /// Obtiene una representación en cadena de los datos del cliente
        /// </summary>
        /// <returns>Representación en cadena del cliente</returns>
        public override string ToString()
        {
            return $"Cliente: {NombreCompleto} - Documento: {NumeroDocumento}";
        }

        /// <summary>
        /// Valida que todos los campos requeridos estén completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos están completos</returns>
        public bool ValidarCamposRequeridos()
        {
            return !string.IsNullOrWhiteSpace(NombreCompleto) && 
                   !string.IsNullOrWhiteSpace(NumeroDocumento);
        }
    }
}
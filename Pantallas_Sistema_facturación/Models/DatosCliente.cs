using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturaci�n.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturaci�n.
    /// </summary>
    public class DatosCliente
    {
        /// <summary>
        /// Indica si el cliente est� activo o no
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// N�mero de documento de identidad del cliente
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Direcci�n del cliente
        /// </summary>
        public string DireccionResidencia { get; set; }

        /// <summary>
        /// N�mero telef�nico del cliente
        /// </summary>
        public string NumeroTelefono { get; set; }

        /// <summary>
        /// Correo electr�nico del cliente
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicaci�n)
        /// </summary>
        [Obsolete("Esta propiedad no se utiliza en la aplicaci�n actual, pero se mantiene por compatibilidad")]
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
        /// <returns>Verdadero si el email tiene un formato v�lido</returns>
        public bool ValidarFormatoEmail()
        {
            if (string.IsNullOrWhiteSpace(CorreoElectronico))
                return true; // Un email vac�o es v�lido ya que podr�a ser opcional

            // Patr�n b�sico de validaci�n de correo electr�nico
            string PatronValidacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(CorreoElectronico, PatronValidacion);
        }

        /// <summary>
        /// Obtiene una representaci�n en cadena de los datos del cliente
        /// </summary>
        /// <returns>Representaci�n en cadena del cliente</returns>
        public override string ToString()
        {
            return $"Cliente: {NombreCompleto} - Documento: {NumeroDocumento}";
        }

        /// <summary>
        /// Valida que todos los campos requeridos est�n completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos est�n completos</returns>
        public bool ValidarCamposRequeridos()
        {
            return !string.IsNullOrWhiteSpace(NombreCompleto) && 
                   !string.IsNullOrWhiteSpace(NumeroDocumento);
        }
    }
}
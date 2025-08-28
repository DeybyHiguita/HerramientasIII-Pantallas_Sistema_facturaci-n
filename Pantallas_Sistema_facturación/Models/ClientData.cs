using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturación.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturación.
    /// </summary>
    public class ClientData
    {
        /// <summary>
        /// Indica si el cliente está activo o no
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Número de documento de identidad del cliente
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Dirección del cliente
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Número telefónico del cliente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicación)
        /// </summary>
        [Obsolete("Esta propiedad no se utiliza en la aplicación actual, pero se mantiene por compatibilidad")]
        public string ClientType { get; set; } = "General";

        /// <summary>
        /// Observaciones o notas adicionales sobre el cliente
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Fecha de registro del cliente
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ClientData()
        {
            Active = true;
            Name = string.Empty;
            DocumentNumber = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Notes = string.Empty;
            RegistrationDate = DateTime.Now;
        }

        /// <summary>
        /// Valida el formato del email
        /// </summary>
        /// <returns>Verdadero si el email tiene un formato válido</returns>
        public bool IsValidEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return true; // Un email vacío es válido ya que podría ser opcional

            // Patrón básico de validación de correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(Email, pattern);
        }

        /// <summary>
        /// Valida el formato del número telefónico
        /// </summary>
        /// <returns>Verdadero si el teléfono tiene un formato válido</returns>
        public bool IsValidPhone()
        {
            if (string.IsNullOrWhiteSpace(Phone))
                return true; // Un teléfono vacío es válido ya que podría ser opcional

            // Eliminar caracteres no numéricos para la validación
            string numericPhone = Regex.Replace(Phone, @"[^\d]", "");
            return numericPhone.Length >= 7 && numericPhone.Length <= 15;
        }

        /// <summary>
        /// Valida el documento de identidad
        /// </summary>
        /// <returns>Verdadero si el documento tiene un formato válido</returns>
        public bool IsValidDocument()
        {
            if (string.IsNullOrWhiteSpace(DocumentNumber))
                return false; // El documento no puede estar vacío

            // Eliminar caracteres no alfanuméricos
            string cleanDocument = Regex.Replace(DocumentNumber, @"[^\w]", "");
            return cleanDocument.Length >= 5 && cleanDocument.Length <= 20;
        }

        /// <summary>
        /// Retorna una representación textual del cliente
        /// </summary>
        /// <returns>Representación en texto del cliente</returns>
        public override string ToString()
        {
            return $"{DocumentNumber} - {Name}";
        }
    }
}
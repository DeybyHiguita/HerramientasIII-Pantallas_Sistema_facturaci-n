using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturaci�n.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturaci�n.
    /// </summary>
    public class ClientData
    {
        /// <summary>
        /// Indica si el cliente est� activo o no
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// N�mero de documento de identidad del cliente
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Direcci�n del cliente
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// N�mero telef�nico del cliente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Correo electr�nico del cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicaci�n)
        /// </summary>
        [Obsolete("Esta propiedad no se utiliza en la aplicaci�n actual, pero se mantiene por compatibilidad")]
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
        /// <returns>Verdadero si el email tiene un formato v�lido</returns>
        public bool IsValidEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return true; // Un email vac�o es v�lido ya que podr�a ser opcional

            // Patr�n b�sico de validaci�n de correo electr�nico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(Email, pattern);
        }

        /// <summary>
        /// Valida el formato del n�mero telef�nico
        /// </summary>
        /// <returns>Verdadero si el tel�fono tiene un formato v�lido</returns>
        public bool IsValidPhone()
        {
            if (string.IsNullOrWhiteSpace(Phone))
                return true; // Un tel�fono vac�o es v�lido ya que podr�a ser opcional

            // Eliminar caracteres no num�ricos para la validaci�n
            string numericPhone = Regex.Replace(Phone, @"[^\d]", "");
            return numericPhone.Length >= 7 && numericPhone.Length <= 15;
        }

        /// <summary>
        /// Valida el documento de identidad
        /// </summary>
        /// <returns>Verdadero si el documento tiene un formato v�lido</returns>
        public bool IsValidDocument()
        {
            if (string.IsNullOrWhiteSpace(DocumentNumber))
                return false; // El documento no puede estar vac�o

            // Eliminar caracteres no alfanum�ricos
            string cleanDocument = Regex.Replace(DocumentNumber, @"[^\w]", "");
            return cleanDocument.Length >= 5 && cleanDocument.Length <= 20;
        }

        /// <summary>
        /// Retorna una representaci�n textual del cliente
        /// </summary>
        /// <returns>Representaci�n en texto del cliente</returns>
        public override string ToString()
        {
            return $"{DocumentNumber} - {Name}";
        }
    }
}
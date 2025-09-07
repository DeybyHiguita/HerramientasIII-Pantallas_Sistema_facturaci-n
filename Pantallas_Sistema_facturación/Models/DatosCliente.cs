using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturación.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturación.
    /// </summary>
    public class ModeloClienteForm
    {
        /// <summary>
        /// Indica si el cliente está activo o no
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string StrNombre { get; set; }

        /// <summary>
        /// Número de documento de identidad del cliente
        /// </summary>
        public int NumDocumento { get; set; }

        /// <summary>
        /// Dirección del cliente
        /// </summary>
        public string StrDireccion { get; set; }

        /// <summary>
        /// Número telefónico del cliente
        /// </summary>
        public string StrTelefono { get; set; }

        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string StrEmail { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicación)
        /// </summary>

        public int  IdCliente { get; set; }

        /// <summary>
        /// Indica si el cliente está activo o no
        /// </summary>
        
        [Obsolete("Esta propiedad no se utiliza en la aplicación actual, pero se mantiene por compatibilidad")]
        public string TipoCliente { get; set; } = "General";

        /// <summary>
        /// Observaciones o notas adicionales sobre el cliente
        /// </summary>
        public string StrUsuarioModifica { get; set; }

        /// <summary>
        /// Fecha de registro del cliente
        /// </summary>
        public DateTime DtmFechaModifica { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ModeloClienteForm()
        {
            IdCliente = int.MinValue;
            EstaActivo = true;
            StrNombre = string.Empty;
            NumDocumento = int.MinValue;
            StrDireccion =string.Empty;
            StrTelefono = string.Empty;
            StrEmail = string.Empty;
            StrUsuarioModifica = string.Empty;
            DtmFechaModifica = DateTime.Now;
        }

        /// <summary>
        /// Valida el formato del email
        /// </summary>
        /// <returns>Verdadero si el email tiene un formato válido</returns>
        public bool ValidarFormatoEmail()
        {
            if (string.IsNullOrWhiteSpace(StrEmail))
                return true; 

            string PatronValidacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(StrEmail, PatronValidacion);
        }

        /// <summary>
        /// Obtiene una representación en cadena de los datos del cliente
        /// </summary>
        /// <returns>Representación en cadena del cliente</returns>
        public override string ToString()
        {
            return $"Cliente: {StrNombre} , Documento: {NumDocumento}, Teléfono: {StrTelefono}, Email: {StrEmail}";
        }

        /// <summary>
        /// Valida que todos los campos requeridos estén completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos están completos</returns>
    }
}
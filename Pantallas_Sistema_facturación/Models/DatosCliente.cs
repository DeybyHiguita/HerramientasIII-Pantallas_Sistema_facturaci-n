using System;
using System.Text.RegularExpressions;

namespace Pantallas_Sistema_facturaci�n.Models
{
    /// <summary>
    /// Representa los datos de un cliente en el sistema de facturaci�n.
    /// </summary>
    public class ModeloClienteForm
    {
        /// <summary>
        /// Indica si el cliente est� activo o no
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string StrNombre { get; set; }

        /// <summary>
        /// N�mero de documento de identidad del cliente
        /// </summary>
        public int NumDocumento { get; set; }

        /// <summary>
        /// Direcci�n del cliente
        /// </summary>
        public string StrDireccion { get; set; }

        /// <summary>
        /// N�mero telef�nico del cliente
        /// </summary>
        public string StrTelefono { get; set; }

        /// <summary>
        /// Correo electr�nico del cliente
        /// </summary>
        public string StrEmail { get; set; }

        /// <summary>
        /// Tipo de cliente (no utilizado en esta aplicaci�n)
        /// </summary>

        public int  IdCliente { get; set; }

        /// <summary>
        /// Indica si el cliente est� activo o no
        /// </summary>
        
        [Obsolete("Esta propiedad no se utiliza en la aplicaci�n actual, pero se mantiene por compatibilidad")]
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
        /// <returns>Verdadero si el email tiene un formato v�lido</returns>
        public bool ValidarFormatoEmail()
        {
            if (string.IsNullOrWhiteSpace(StrEmail))
                return true; 

            string PatronValidacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(StrEmail, PatronValidacion);
        }

        /// <summary>
        /// Obtiene una representaci�n en cadena de los datos del cliente
        /// </summary>
        /// <returns>Representaci�n en cadena del cliente</returns>
        public override string ToString()
        {
            return $"Cliente: {StrNombre} , Documento: {NumDocumento}, Tel�fono: {StrTelefono}, Email: {StrEmail}";
        }

        /// <summary>
        /// Valida que todos los campos requeridos est�n completos
        /// </summary>
        /// <returns>Verdadero si todos los campos requeridos est�n completos</returns>
    }
}
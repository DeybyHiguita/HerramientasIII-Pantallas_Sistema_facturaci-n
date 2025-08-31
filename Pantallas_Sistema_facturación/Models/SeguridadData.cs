using System;

namespace Pantallas_Sistema_facturaci�n.Models
{
    /// <summary>
    /// Representa los datos de un empleado en el sistema
    /// </summary>
    public class EmpleadoData
    {
        /// <summary>
        /// ID �nico del empleado
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre completo del empleado
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// N�mero de documento de identidad
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Cargo o posici�n del empleado
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Salario del empleado
        /// </summary>
        public decimal Salario { get; set; }

        /// <summary>
        /// Fecha de contrataci�n
        /// </summary>
        public DateTime FechaContratacion { get; set; }

        /// <summary>
        /// Estado activo/inactivo
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Correo electr�nico del empleado
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Tel�fono del empleado
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EmpleadoData()
        {
            Id = 0;
            NombreCompleto = string.Empty;
            NumeroDocumento = string.Empty;
            Cargo = string.Empty;
            Salario = 0;
            FechaContratacion = DateTime.Now;
            EstaActivo = true;
            Email = string.Empty;
            Telefono = string.Empty;
        }

        /// <summary>
        /// Retorna una representaci�n textual del empleado
        /// </summary>
        public override string ToString()
        {
            return $"{NombreCompleto} - {Cargo}";
        }
    }

    /// <summary>
    /// Representa los datos de un rol de usuario
    /// </summary>
    public class RolData
    {
        /// <summary>
        /// ID �nico del rol
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del rol
        /// </summary>
        public string NombreRol { get; set; }

        /// <summary>
        /// Descripci�n del rol
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Permisos asociados al rol
        /// </summary>
        public string Permisos { get; set; }

        /// <summary>
        /// Estado activo/inactivo
        /// </summary>
        public bool EstaActivo { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public RolData()
        {
            Id = 0;
            NombreRol = string.Empty;
            Descripcion = string.Empty;
            Permisos = string.Empty;
            EstaActivo = true;
        }

        /// <summary>
        /// Retorna una representaci�n textual del rol
        /// </summary>
        public override string ToString()
        {
            return NombreRol;
        }
    }
}
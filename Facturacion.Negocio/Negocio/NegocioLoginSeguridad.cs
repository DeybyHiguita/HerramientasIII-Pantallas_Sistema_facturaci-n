using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioLoginSeguridad
    {
        private readonly string usuario;
        private readonly string contrasena;

        public NegocioLoginSeguridad(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        public List<ModeloAdministracionSeguridad> Ejecutar()
        {
            var data = new ValidarLoginSeguridad(usuario, contrasena);
            return data.Run() as List<ModeloAdministracionSeguridad>;
        }
    }
}

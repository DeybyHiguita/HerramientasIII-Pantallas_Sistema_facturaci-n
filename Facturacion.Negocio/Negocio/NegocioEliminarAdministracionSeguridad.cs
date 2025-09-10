using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioEliminarAdministracionSeguridad
    {
        private readonly int IdSeguridad;

        public NegocioEliminarAdministracionSeguridad(int idSeguridad)
        {
            this.IdSeguridad = idSeguridad;
        }

        public bool Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdSeguridad", IdSeguridad }
            };

            EliminarAdministracionSeguridad dataEliminarSeguridad = new EliminarAdministracionSeguridad(parametros);
            return (bool)dataEliminarSeguridad.Run();
        }
    }
}
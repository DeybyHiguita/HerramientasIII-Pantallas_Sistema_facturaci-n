using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioEliminarCliente
    {
        private readonly int IdCliente;

        public NegocioEliminarCliente(int IdCliente)
        {
            this.IdCliente = IdCliente;
        }
        public bool Ejecutar()
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "IdCliente", IdCliente }
            };

            EliminarCliente dataEliminarProducto = new EliminarCliente(parametros);
            return (bool)dataEliminarProducto.Run();
        }
    }
}

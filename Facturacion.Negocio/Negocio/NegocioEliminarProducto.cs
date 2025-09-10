using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioEliminarProducto
    {
        private readonly int IdProducto;

        public NegocioEliminarProducto(int IdProducto)
        {
            this.IdProducto = IdProducto;
        }
        public bool Ejecutar()
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "IdProducto", IdProducto }
            };

            EliminarProducto dataEliminarProducto = new EliminarProducto(parametros);
            return (bool)dataEliminarProducto.Run();
        }
    }
}

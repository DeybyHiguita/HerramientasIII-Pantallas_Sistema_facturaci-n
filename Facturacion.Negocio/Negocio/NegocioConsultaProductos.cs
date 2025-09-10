using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioConsultaProductos
    {
        public List<ModeloProducto> Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            List<ModeloProducto> modeloProducto = new List<ModeloProducto>();
            object resultado = new ConsultaProductos(parametros).Run();
            if (resultado is List<ModeloProducto> lista)
            {
                modeloProducto = lista;
            }
            return modeloProducto;

        }
    }
}

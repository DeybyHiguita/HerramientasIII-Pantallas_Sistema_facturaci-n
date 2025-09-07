using Data;
using Modelo;
using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioConsultaClientes
    {
        public List<ModeloCliente> Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            List<ModeloCliente> modeloCliente = new List<ModeloCliente>();
            object resultado = new ConsultaClientes(parametros).Run();
            if (resultado is List<ModeloCliente> lista)
            {
                modeloCliente = lista;
            }
            return modeloCliente;
        }
    }
}

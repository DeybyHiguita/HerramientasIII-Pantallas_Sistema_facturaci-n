using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Modelo;

namespace Negocio
{
    public class NegocioConsultaEmpleado
    {
        public List<ModeloEmpleado> Ejecutar()
        {
            var data = new ConsultaEmpleado();
            return (List<ModeloEmpleado>)data.Run();
        }
    }
}

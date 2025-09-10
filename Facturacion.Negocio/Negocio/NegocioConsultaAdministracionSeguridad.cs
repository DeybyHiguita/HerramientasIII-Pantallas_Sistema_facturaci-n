using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioConsultaAdministracionSeguridad
    {
        public List<ModeloAdministracionSeguridad> Ejecutar()
        {
            List<ModeloAdministracionSeguridad> modeloSeguridad = new List<ModeloAdministracionSeguridad>();

            object resultado = new ConsultaAdministracionSeguridad().Run();

            if (resultado is List<ModeloAdministracionSeguridad> lista)
            {
                modeloSeguridad = lista;
            }

            return modeloSeguridad;
        }
    }
}


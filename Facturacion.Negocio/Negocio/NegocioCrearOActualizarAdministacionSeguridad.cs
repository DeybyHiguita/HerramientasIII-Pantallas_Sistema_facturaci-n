using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCrearOActualizarAdministracionSeguridad
    {
        private readonly ModeloAdministracionSeguridad modeloSeguridad;

        public NegocioCrearOActualizarAdministracionSeguridad(ModeloAdministracionSeguridad modelo)
        {
            this.modeloSeguridad = modelo;
        }

        public bool Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@IdSeguridad", modeloSeguridad.IdSeguridad);
            parametros.Add("@IdEmpleado", modeloSeguridad.IdEmpleado);
            parametros.Add("@StrUsuario", modeloSeguridad.StrUsuario);
            parametros.Add("@StrClave", modeloSeguridad.StrClave);
            parametros.Add("@StrUsuarioModifico", modeloSeguridad.StrUsuarioModifico);
            parametros.Add("@DtmFechaModifica", modeloSeguridad.DtmFechaModifica);

            object resultado = new CrearAdministracionSeguridad(parametros).Run();
            bool ok = resultado is bool && (bool)resultado;
            return ok;
        }
    }
}
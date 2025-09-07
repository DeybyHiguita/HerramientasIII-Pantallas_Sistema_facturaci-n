using Data;
using Modelo;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioCrearOActualizarCliente
    {
        private readonly ModeloCliente modeloCliente;

        public NegocioCrearOActualizarCliente(ModeloCliente modelo)
        {
            this.modeloCliente = modelo;
        }

        public bool Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@IdCliente", modeloCliente.IdCliente);
            parametros.Add("@StrNombre", modeloCliente.StrNombre);
            parametros.Add("@NumDocumento", modeloCliente.NumDocumento);
            parametros.Add("@StrDireccion", modeloCliente.StrDireccion);
            parametros.Add("@StrTelefono", modeloCliente.StrTelefono);
            parametros.Add("@StrEmail", modeloCliente.StrEmail);
            parametros.Add("@StrUsuarioModifica", modeloCliente.StrUsuarioModifica);
            parametros.Add("@DtmFechaModifica", modeloCliente.DtmFechaModifica);

            object resultado = new CrearCliente(parametros).Run();
            bool ok = resultado is bool && (bool)resultado;
            return ok;
        }
    }
}
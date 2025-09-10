using Data;
using Modelo;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioCrearActualizarProducto
    {
        private readonly ModeloProducto modeloProducto;

        public NegocioCrearActualizarProducto(ModeloProducto modelo)
        {
            this.modeloProducto = modelo;
        }

        public bool Ejecutar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IdProducto", modeloProducto.IdProducto);
            parametros.Add("StrNombre", modeloProducto.StrNombre);
            parametros.Add("StrCodigo", modeloProducto.StrCodigo);
            parametros.Add("NumPrecioCompra", modeloProducto.NumPrecioCompra);
            parametros.Add("NumPrecioVenta", modeloProducto.NumPrecioVenta);
            parametros.Add("IdCategoria", modeloProducto.IdCategoria);
            parametros.Add("StrDetalle", (object)modeloProducto.StrDetalle ?? DBNull.Value);
            parametros.Add("strFoto", (object)modeloProducto.strFoto ?? DBNull.Value);
            parametros.Add("NumStock", modeloProducto.NumStock);
            parametros.Add("DtmFechaModifica", modeloProducto.DtmFechaModifica);
            parametros.Add("StrUsuarioModifica", modeloProducto.StrUsuarioModifica);

            object resultado = new CrearProducto(parametros).Run();
            bool ok = resultado is bool && (bool)resultado;
            return ok;
        }
    }
}

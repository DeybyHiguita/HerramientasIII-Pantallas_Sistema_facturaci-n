using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Data
{
    public class ValidarLoginSeguridad : DataGeneral
    {
        private readonly string procedimientoAlmacenado = "dbo.LoginSeguridad";
        private readonly Dictionary<string, object> parametros;

        public ValidarLoginSeguridad(string usuario, string contrasena)
        {
            parametros = new Dictionary<string, object>
            {
                { "@StrUsuario", usuario },
                { "@StrClave", contrasena }
            };
        }

        protected override void Process()
        {
            var dataTable = SqlProvider.Instance.ExecuteReader(
                procedimientoAlmacenado,
                parametros,
                CommandType.StoredProcedure
            );

            var resultado = DataMapper.MapToList < ModeloAdministracionSeguridad>(dataTable);
            SetResult(resultado);
        }
    }
}


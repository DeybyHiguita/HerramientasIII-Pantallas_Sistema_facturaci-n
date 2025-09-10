using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConsultaAdministracionSeguridad : DataGeneral
    {
        private readonly string procedimientoAlmacenado;
        private readonly Dictionary<string, object> parametros;
        private const string Sp = "dbo.ConsultaAdministracionSeguridad";

        public ConsultaAdministracionSeguridad()
        {
            this.procedimientoAlmacenado = Sp;
        }

        protected override void Process()
        {
            var dataTable = SqlProvider.Instance.ExecuteReader(
                procedimientoAlmacenado,
                parametros,
                System.Data.CommandType.StoredProcedure);

            var resultado = DataMapper.MapToList<Modelo.ModeloAdministracionSeguridad>(dataTable)?? new List<Modelo.ModeloAdministracionSeguridad>();

            SetResult(resultado);
        }
    }
}


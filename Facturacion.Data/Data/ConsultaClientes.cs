using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConsultaClientes : DataGeneral
    {
        private readonly string procedimientoAlmacenado;
        private readonly Dictionary<string, object> parametros;
        private const string Sp = "dbo.ConsultaClientes";
        public ConsultaClientes(Dictionary<string, object> parametros)
        {
            this.procedimientoAlmacenado = Sp;
            this.parametros = parametros;
        }
        protected override void Process()
        {
            var dataTable = SqlProvider.Instance.ExecuteReader(procedimientoAlmacenado, parametros, System.Data.CommandType.StoredProcedure);
            var resultado = DataMapper.MapToList<Modelo.ModeloCliente>(dataTable) ?? new List<Modelo.ModeloCliente>();
            SetResult(resultado);
        }
    }
}

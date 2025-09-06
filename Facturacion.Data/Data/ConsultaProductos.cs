using Core;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConsultaProductos : DataGeneral
    {
        private readonly string procedimientoAlmacenado;
        private readonly Dictionary<string, object> parametros;

        private const string Sp = "dbo.ConsultaProductos";
        public ConsultaProductos(Dictionary<string, object> parametros)
        {
            this.procedimientoAlmacenado = Sp;
            this.parametros = parametros;
        }
        protected override void Process()
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteReader(procedimientoAlmacenado, parametros, CommandType.StoredProcedure);
            List<ModeloProducto> resultado = DataMapper.MapToList<ModeloProducto>(dataTable) ?? new List<ModeloProducto>();
            SetResult(resultado);
        }
    }
}

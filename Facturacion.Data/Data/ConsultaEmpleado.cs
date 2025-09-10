using Core;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConsultaEmpleado : DataGeneral
    {
        private const string Sp = "dbo.ConsultaEmpleado";

        protected override void Process()
        {
            var dataTable = SqlProvider.Instance.ExecuteReader(
                Sp,
                null,
                CommandType.StoredProcedure
            );

            var resultado = DataMapper.MapToList<ModeloEmpleado>(dataTable)
                            ?? new List<ModeloEmpleado>();

            SetResult(resultado);
        }
    }
}

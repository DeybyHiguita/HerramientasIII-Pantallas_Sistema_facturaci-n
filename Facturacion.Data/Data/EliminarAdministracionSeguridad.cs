using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EliminarAdministracionSeguridad : DataGeneral
    {
        private readonly string procedimientoAlmacenado;
        private readonly Dictionary<string, object> parametros;

        private const string Sp = "dbo.eliminar_Seguridad";

        public EliminarAdministracionSeguridad(Dictionary<string, object> parametros)
        {
            this.procedimientoAlmacenado = Sp;
            this.parametros = parametros;
        }

        protected override void Process()
        {
            int filasAfectadas = SqlProvider.Instance.ExecuteNonQuery(
                this.procedimientoAlmacenado,
                this.parametros,
                CommandType.StoredProcedure
            );

            SetResult(filasAfectadas > 0);
        }
    }
}

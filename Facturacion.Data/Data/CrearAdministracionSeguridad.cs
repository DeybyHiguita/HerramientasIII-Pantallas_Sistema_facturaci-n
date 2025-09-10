using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CrearAdministracionSeguridad : DataGeneral
    {
        private readonly string procedimientoAlmacenado;
        private readonly Dictionary<string, object> parametros;

        private const string Sp = "dbo.actualizar_Seguridad";

        public CrearAdministracionSeguridad(Dictionary<string, object> parametros)
        {
            this.procedimientoAlmacenado = Sp;
            this.parametros = parametros;
        }

        protected override void Process()
        {
            int filasEditadas = SqlProvider.Instance.ExecuteNonQuery(
                this.procedimientoAlmacenado,
                this.parametros,
                CommandType.StoredProcedure
            );

            SetResult(filasEditadas > 0);
        }
    }
}
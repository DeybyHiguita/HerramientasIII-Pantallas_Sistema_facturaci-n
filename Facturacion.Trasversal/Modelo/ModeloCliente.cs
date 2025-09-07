using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public string ObservacionesAdicionales { get; set; }

        public string StrNombre { get; set; }
        public long NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }
        public int IdCliente { get; set; }
    }
}

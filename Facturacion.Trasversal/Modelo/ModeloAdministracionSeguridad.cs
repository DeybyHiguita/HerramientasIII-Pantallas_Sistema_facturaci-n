using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAdministracionSeguridad
    {
        public int IdSeguridad { get; set; }
        public int IdEmpleado { get; set; }
        public string StrUsuario { get; set; }
        public string StrClave { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifico { get; set; }
    }
}


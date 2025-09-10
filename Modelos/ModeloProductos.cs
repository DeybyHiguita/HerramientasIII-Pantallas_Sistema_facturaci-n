using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloProductos
    {
        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public string NumPrecioCompra { get; set; }
        public string NumPrecioVenta { get; set; }
        public string IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string strFoto { get; set; }
        public string NumStock { get; set; }
        public string DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }

    }
}

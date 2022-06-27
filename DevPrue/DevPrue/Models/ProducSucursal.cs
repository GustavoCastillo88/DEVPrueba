using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevPrue.Models
{
    public class ProducSucursal
    {
        public int id { get; set; }
        public string nombreProducto { get; set; }
        public int codigoDeBarra { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public string nombre { get; set; }

    }
}
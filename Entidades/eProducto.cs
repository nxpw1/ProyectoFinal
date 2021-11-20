using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eProducto
    {
        public int idproducto { get; set; }
        public string NombreProducto { get; set; }

        public int CantidadProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public string MarcaProducto { get; set; }
        public override string ToString()
        {
            return NombreProducto;
        }
    }
}

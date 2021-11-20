using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eVenta
    {
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public string FechaVenta { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eEmpleado
    {
        public int idempleado { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }
        public string sexo { get; set; }
        public string edad { get; set; }

        public string cargo { get; set; }
        public string tiempo { get; set; }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }

    }
}

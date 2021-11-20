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
        public string NombreEmpleado { get; set; }

        public string ApellidoEmpleado { get; set; }
        public string SexoEmpleado { get; set; }
        public string FechaNacEmpleado { get; set; }

        public string CargoEmpleado { get; set; }
        public string FechaIngreso { get; set; }
        public override string ToString()
        {
            return NombreEmpleado + " " + ApellidoEmpleado;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocios
{
    public class nEmpleado
    {
        dEmpleado empleadod;
        public nEmpleado()
        {
            empleadod = new dEmpleado();
        }
        public string RegistrarEmpleado(string nombreempleado, string apellidoempleado, string sexoempleado, string cargoempleado, string tiempoempleado )
        {
            eEmpleado empleado = new eEmpleado()
            {
                nombre = nombreempleado,
                apellido = apellidoempleado,
                sexo=sexoempleado,
                cargo=cargoempleado,
                tiempo=tiempoempleado
            };
            return empleadod.Insertar(empleado);
        }
        public string Modificarempleado(int idempleado, string nombreempleado, string apellidoempleado, string sexoempleado, string cargoempleado, string tiempoempleado)
        {
            eEmpleado empleado = new eEmpleado()
            {
                idempleado=idempleado,
                nombre = nombreempleado,
                apellido = apellidoempleado,
                sexo = sexoempleado,
                cargo = cargoempleado,
                tiempo = tiempoempleado
            };
            return empleadod.Modificar(empleado);
        }

        public string Eliminarpais(int id)
        {
            return empleadod.Eliminar(id);
        }

        public List<eEmpleado> ListarEmpleado()
        {
            return empleadod.ListarTodo();
        }
    }
}

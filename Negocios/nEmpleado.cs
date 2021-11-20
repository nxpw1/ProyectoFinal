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
        public string RegistrarEmpleado(string nombempleado, string apelliempleado, string sexempleado, DateTime fechana, string carempleado, DateTime fechain)
        {
            string s = fechana.ToShortDateString();
            string r = fechain.ToShortDateString();
            string dia, mes, anio;
            string dia1,mes1,anio1;
            int pos1, pos2,pos3,pos4;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            pos3 = r.IndexOf("/");
            pos4 = r.IndexOf("/", pos3 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);
            dia1 = r.Substring(0, pos3);
            mes1 = r.Substring(pos3 + 1, pos4 - pos3 - 1);
            anio1 = r.Substring(pos4 + 1, r.Length - pos4 - 1);
            eEmpleado objempleado = new eEmpleado()
            {
                NombreEmpleado = nombempleado,
                ApellidoEmpleado = apelliempleado,
                SexoEmpleado = sexempleado,
                FechaNacEmpleado = anio + "/" + mes + "/" + dia,
                CargoEmpleado = carempleado,
                FechaIngreso=anio1+"/"+mes1+"/"+dia1

            };
            return empleadod.Insertar(objempleado);
        }
        public string ModificarEmpleado(int codempleado, string nombempleado, string apelliempleado, string sexempleado, DateTime fechana, string carempleado,DateTime fechain)
        {
            string s = fechana.ToShortDateString();
            string r = fechain.ToShortDateString();
            string dia, mes, anio;
            string dia1, mes1, anio1;
            int pos1, pos2, pos3, pos4;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            pos3 = r.IndexOf("/");
            pos4 = r.IndexOf("/", pos3 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);
            dia1 = r.Substring(0, pos3);
            mes1 = r.Substring(pos3 + 1, pos4 - pos3 - 1);
            anio1 = r.Substring(pos4 + 1, r.Length - pos4 - 1);
            eEmpleado objempleado = new eEmpleado()
            {
                idempleado = codempleado,
                NombreEmpleado = nombempleado,
                ApellidoEmpleado = apelliempleado,
                SexoEmpleado = sexempleado,
                FechaNacEmpleado = anio + "/" + mes + "/" + dia,
                CargoEmpleado = carempleado,
                FechaIngreso = anio1 + "/" + mes1 + "/" + dia1
            };
            return empleadod.Modificar(objempleado);
        }

        public string EliminarEmpleado(int id)
        {
            return empleadod.Eliminar(id);
        }

        public List<eEmpleado> ListarEmpleado()
        {
            return empleadod.ListarTodo();
        }
    }
}

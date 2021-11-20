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
    public class nVenta
    {
        dVenta ventad;
        public nVenta()
        {
            ventad = new dVenta();
        }
        public string RegistrarVenta(int idemp, string nomemp,int idcli,string nomcli,decimal tot,DateTime fech)
        {

            string s = fech.ToShortDateString();
            string dia, mes, anio;
            int pos1, pos2;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);
            eVenta ventas = new eVenta()
            {
                IdEmpleado = idemp,
                Empleado=nomemp,
                IdCliente=idcli,
                Cliente = nomcli,
                Total=tot,
                FechaVenta=anio+ "/" + mes + "/" + dia
            };
            return ventad.Insertar(ventas);
        }
        public string ModificarVenta(int codv,int idemp, string nomemp, int idcli, string nomcli, decimal tot, DateTime fech)
        {
            string s = fech.ToShortDateString();
            string dia, mes, anio;
            int pos1, pos2;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);

            eVenta ventas = new eVenta()
            {
                IdVenta=codv,
                IdEmpleado = idemp,
                Empleado = nomemp,
                IdCliente = idcli,
                Cliente = nomcli,
                Total = tot,
                FechaVenta = anio + "/" + mes + "/" + dia

            };
            return ventad.Modificar(ventas);
        }

        public string EliminarVenta(int id)
        {
            return ventad.Eliminar(id);
        }

        public List<eVenta> ListarVentas()
        {
            return ventad.ListarTodo();
        }
    }
}

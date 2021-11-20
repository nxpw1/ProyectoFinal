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
    public class nCliente
    {
        dCliente clientedd;
        public nCliente()
        {
            clientedd = new dCliente();
        }
        public string RegistrarCliente(int dnicli,string nombrecli,string apellicli,string sexocli,int telcli,DateTime edadcli)
        {
            string s = edadcli.ToShortDateString();
            string dia, mes, anio;
            int pos1, pos2;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);
            eCliente objcliente = new eCliente()
            {
                DNICliente = dnicli,
                NombreCliente = nombrecli,
                ApellidoCliente = apellicli,
                SexoCliente = sexocli,
                TelefonoCliente = telcli,
                EdadCliente = anio + "/" + mes + "/" + dia
            };
            return clientedd.Insertar(objcliente);
        }
        public string ModificarCliente(int codcli, int dnicli, string nombrecli, string apellicli, string sexocli, int telcli, DateTime edadcli)
        {
            string s = edadcli.ToShortDateString();
            string dia, mes, anio;
            int pos1, pos2;
            pos1 = s.IndexOf("/");
            pos2 = s.IndexOf("/", pos1 + 1);
            dia = s.Substring(0, pos1);
            mes = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            anio = s.Substring(pos2 + 1, s.Length - pos2 - 1);
            eCliente objcliente = new eCliente()
            {
                IdCliente = codcli,
                DNICliente = dnicli,
                NombreCliente = nombrecli,
                ApellidoCliente = apellicli,
                SexoCliente = sexocli,
                TelefonoCliente = telcli,
                EdadCliente = anio + "/" + mes + "/" + dia
            };
            return clientedd.Modificar(objcliente);
        }
        public string EliminarCliente(int id)
        {
            return clientedd.Eliminar(id);
        }
        public List<eCliente> ListarCliente()
        {
            return clientedd.ListarTodo();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dVenta
    {
        Database db = new Database();
        public string Insertar(eVenta obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into venta (idempleado,nombreempleado,idcliente,nombrecliente,totalventa,fechaventa) values ({0},'{1}',{2},'{3}',{4}),'{5}'", obj.IdEmpleado,obj.Empleado,obj.IdCliente,obj.Cliente,obj.Total,obj.FechaVenta);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string Modificar(eVenta obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update venta set idcliente={0}, idempleado={0},nombreempleado='{1}' idcliente={2}, nombrecliente='{3}',totalventa={4}, fechaventa='{5}' where id_venta={6}", obj.IdEmpleado, obj.Empleado, obj.IdCliente, obj.Cliente, obj.Total,obj.FechaVenta,obj.IdVenta);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string delete = string.Format("delete from venta where id_venta={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Elimino";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public List<eVenta> ListarTodo()
        {
            try
            {
                List<eVenta> lsventa = new List<eVenta>();
                eVenta venta = null;
                DateTime d;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select id_venta,idempleado,nombreempleado,idcliente,nombrecliente,totalventa,fechaventa from venta", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    venta = new eVenta();
                    venta.IdVenta = (int)reader["id_venta"];
                    venta.IdEmpleado = (int)reader["idempleado"];
                    venta.Empleado = (string)reader["nombreempleado"];
                    venta.IdCliente = (int)reader["idcliente"];
                    venta.Cliente = (string)reader["nombrecliente"];
                    venta.Total = (decimal)reader["totalventa"];
                    d = (DateTime)reader["fechaventa"];
                    venta.FechaVenta = d.ToShortDateString();
;                }
                reader.Close();
                return lsventa;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
    }
}

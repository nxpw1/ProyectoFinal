using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dProducto
    {
        Database db = new Database();
        public string Insertar(eProducto obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into producto (nombre, cantidad, precio, marca) values ('{0}',{1},{2},'{3}')", obj.NombreProducto, obj.CantidadProducto, obj.PrecioProducto, obj.MarcaProducto);
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
        public string Modificar(eProducto obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update producto set nombre='{1}', cantidad={2}, precio={3}, marca='{4}' where id_producto={0}", obj.NombreProducto, obj.CantidadProducto, obj.PrecioProducto, obj.MarcaProducto, obj.idproducto);
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
                string delete = string.Format("delete from producto where id_producto={0}", id);
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
        public List<eProducto> ListarTodo()
        {
            try
            {
                List<eProducto> lsproducto = new List<eProducto>();
                eProducto producto = null;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select id_producto,nombre, cantidad, precio, marca from producto", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto = new eProducto();
                    producto.idproducto = (int)reader["id_producto"];
                    producto.NombreProducto = (string)reader["nombre"];
                    producto.CantidadProducto = (int)reader["cantidad"];
                    producto.PrecioProducto = (decimal)reader["precio"];
                    producto.MarcaProducto = (string)reader["marca"];
                    lsproducto.Add(producto);
                }
                reader.Close();
                return lsproducto;
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

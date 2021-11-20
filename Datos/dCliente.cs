using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dCliente
    {
        Database db = new Database();
        public string Insertar (eCliente obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into cliente (dni,nombre,apellido,sexo,telefono,fechanacimiento) values ({0},'{1}','{2}','{3}',{4},'{5}')", obj.DNICliente, obj.NombreCliente, obj.ApellidoCliente, obj.SexoCliente, obj.TelefonoCliente, obj.FechaCliente);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "inserto";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string Modificar(eCliente obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update cliente set dni={0},nombre='{1}',apellido='{2}',sexo='{3}',telefono={4},fechanacimiento='{5}'where id_cliente={6}", obj.DNICliente,obj.NombreCliente, obj.ApellidoCliente, obj.SexoCliente, obj.TelefonoCliente, obj.FechaCliente, obj.IdCliente);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "modifico";
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
                string delete = string.Format("delete from cliente where id_cliente={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "elimino";
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
        public eCliente BuscarPorDni(int dni)
        {
            try
            {
                eCliente cliente = null;
                DateTime d;
                SqlConnection con = db.ConectaDB();
                string select = string.Format("select id_cliente,dni,nombre,apellido,sexo,telefono,fechanacimiento from cliente where dni={0}", dni);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new eCliente();
                    cliente.IdCliente = (int)reader["id_cliente"];
                    cliente.DNICliente = (int)reader["dni"];
                    cliente.NombreCliente = (string)reader["nombre"];
                    cliente.ApellidoCliente = (string)reader["apellido"];
                    cliente.SexoCliente = (string)reader["sexo"];
                    cliente.TelefonoCliente = (int)reader["telefono"];
                    d = (DateTime)reader["fechanacimiento"];
                    cliente.FechaCliente = d.ToShortDateString();
                }
                reader.Close();
                return cliente;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public List<eCliente> ListarTodo()
        {
            try
            {
                List<eCliente> lscliente = new List<eCliente>();
                DateTime d;
                eCliente cliente = null;
                SqlConnection cone = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select id_cliente,dni,nombre,apellido,sexo,telefono,fechanacimiento from cliente", cone);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cliente = new eCliente();
                    cliente.IdCliente = (int)reader["id_cliente"];
                    cliente.DNICliente = (int)reader["dni"];
                    cliente.NombreCliente = (string)reader["nombre"];
                    cliente.ApellidoCliente = (string)reader["apellido"];
                    cliente.SexoCliente = (string)reader["sexo"];
                    cliente.TelefonoCliente = (int)reader["telefono"];
                    d = (DateTime)reader["fechanacimiento"];
                    cliente.FechaCliente = d.ToShortDateString();
                    lscliente.Add(cliente);
                }
                reader.Close();
                return lscliente;

            }
            catch(Exception ex)
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

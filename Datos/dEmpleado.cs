using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dEmpleado
    {
        Database db = new Database();
        public string Insertar(eEmpleado obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("INSERT INTO empleado (nombre, apellido, sexo, edad, cargo,tiempo_trabajo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", obj.nombre, obj.apellido, obj.sexo, obj.edad, obj.cargo, obj.tiempo);
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
        public string Modificar(eEmpleado obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("UPDATE empleado SET nombre='{1}', apellido='{2}', sexo='{3}', edad='{4}',cargo='{5}', tiempo_trabajo='{6}' Where id_empleado={0}", obj.idempleado, obj.nombre, obj.apellido, obj.sexo, obj.edad, obj.cargo, obj.tiempo);
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
                string delete = string.Format("DELETE from empleado WHERE id_empleado={0}", id);
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
        public List<eEmpleado> ListarTodo()
        {
            try
            {
                List<eEmpleado> lsEmpleado = new List<eEmpleado>();
                eEmpleado empleado = null;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select id_empleado,nombre, apellido, sexo, edad, cargo, tiempo_trabajao from empleado", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleado = new eEmpleado();
                    empleado.idempleado = (int)reader["idempleado"];
                    empleado.nombre = (string)reader["nombre"];
                    empleado.apellido = (string)reader["apellido"];
                    empleado.sexo = (string)reader["sexo"];
                    empleado.edad = (string)reader["edad"];
                    empleado.cargo = (string)reader["cargo"];
                    empleado.tiempo = (string)reader["tiempo"];
                    lsEmpleado.Add(empleado);
                }
                reader.Close();
                return lsEmpleado;
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

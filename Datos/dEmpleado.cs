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
                string insert = string.Format("insert into empleado (nombre, apellido, sexo, fechanacimiento, cargo,fecha_trabajo) values ('{0}','{1}','{2}','{3}','{4}','{5}')", obj.NombreEmpleado, obj.ApellidoEmpleado, obj.SexoEmpleado, obj.FechaNacEmpleado, obj.CargoEmpleado,obj.FechaIngreso);
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
                string update = string.Format("update empleado set nombre='{0}', apellido='{1}', sexo='{2}', fechanacimiento='{3}',cargo='{4}', fecha_trabajo='{5}' where id_empleado={6}", obj.NombreEmpleado, obj.ApellidoEmpleado, obj.SexoEmpleado, obj.FechaNacEmpleado, obj.CargoEmpleado, obj.FechaIngreso,obj.idempleado);
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
                string delete = string.Format("delete from empleado where id_empleado={0}", id);
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
                DateTime d,e;
                eEmpleado empleado = null;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select id_empleado,nombre, apellido, sexo, fechanacimiento, cargo, fecha_trabajo from empleado", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleado = new eEmpleado();
                    empleado.idempleado = (int)reader["id_empleado"];
                    empleado.NombreEmpleado = (string)reader["nombre"];
                    empleado.ApellidoEmpleado = (string)reader["apellido"];
                    empleado.SexoEmpleado = (string)reader["sexo"];
                    d = (DateTime)reader["fechanacimiento"];
                    empleado.FechaNacEmpleado = d.ToShortDateString();
                    empleado.CargoEmpleado = (string)reader["cargo"];
                    e = (DateTime)reader["fecha_trabajo"];
                    empleado.FechaIngreso = e.ToShortDateString();
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

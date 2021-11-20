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
    public class nProducto
    {
        dProducto productod;
        public nProducto()
        {
            productod = new dProducto();
        }
        public string RegistrarProducto(string nombproducto, int cantproducto, decimal preproducto, string marproducto)
        {
            eProducto producto = new eProducto()
            {
                NombreProducto = nombproducto,
                CantidadProducto = cantproducto,
                PrecioProducto = preproducto,
                MarcaProducto = marproducto
            };
            return productod.Insertar(producto);
        }
        public string Modificarproducto(int codpro, string nombproducto, int cantproducto, decimal preproducto, string marproducto)
        {
            eProducto producto = new eProducto()
            {
                idproducto=codpro,
                NombreProducto = nombproducto,
                CantidadProducto = cantproducto,
                PrecioProducto = preproducto,
                MarcaProducto = marproducto
            };
            return productod.Modificar(producto);
        }
        public string Eliminarproducto(int id)
        {
            return productod.Eliminar(id);
        }

        public List<eProducto> ListarProducto()
        {
            return productod.ListarTodo();
        }
    }
}

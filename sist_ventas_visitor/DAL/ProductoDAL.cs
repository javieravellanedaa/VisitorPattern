// DAL/ProductoDAL.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class ProductoDAL
    {
        private readonly Acceso _acceso;

        public ProductoDAL(Acceso acceso)
        {
            _acceso = acceso;
        }

        public IEnumerable<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();
            _acceso.Open();
            var dt = _acceso.Read("sp_producto_obtener_todos");
            foreach (DataRow r in dt.Rows)
            {
                lista.Add(new Producto
                {
                    Id = Convert.ToInt32(r["Id"]),
                    Nombre = r["Nombre"].ToString(),
                    Precio = Convert.ToDecimal(r["Precio"])
                });
            }
            _acceso.Close();
            return lista;
        }

        public Producto ObtenerPorId(int id)
        {
            _acceso.Open();
            var pars = new List<SqlParameter> { _acceso.CreateParameter("@Id", id) };
            var dt = _acceso.Read("sp_producto_obtener_por_id", pars);
            _acceso.Close();

            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new Producto
            {
                Id = id,
                Nombre = r["Nombre"].ToString(),
                Precio = Convert.ToDecimal(r["Precio"])
            };
        }

        public int Insertar(Producto producto)
        {
            _acceso.Open();
            var pars = new List<SqlParameter>
            {
                _acceso.CreateParameter("@Nombre", producto.Nombre),
                _acceso.CreateParameter("@Precio", producto.Precio)
            };
            var result = _acceso.WriteScalar("sp_producto_insertar", pars);
            _acceso.Close();
            return Convert.ToInt32(result);
        }

        public void Actualizar(Producto producto)
        {
            _acceso.Open();
            var pars = new List<SqlParameter>
            {
                _acceso.CreateParameter("@Id", producto.Id),    
                _acceso.CreateParameter("@Nombre", producto.Nombre),
                _acceso.CreateParameter("@Precio", producto.Precio)
            };
            _acceso.Write("sp_producto_actualizar", pars);
            _acceso.Close();
        }

        public void Eliminar(int id)
        {
            _acceso.Open();
            var pars = new List<SqlParameter> { _acceso.CreateParameter("@Id", id) };
            _acceso.Write("sp_producto_borrar", pars);
            _acceso.Close();
        }
    }
}

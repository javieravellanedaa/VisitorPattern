using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaquetePromocionalDAL
    {
        private readonly Acceso _acceso;

        public PaquetePromocionalDAL(Acceso acceso)
        {
            _acceso = acceso;
        }

        public IEnumerable<PaquetePromocional> ObtenerTodos()
        {
            var lista = new List<PaquetePromocional>();
            _acceso.Open();

            // 1) Traer todos los paquetes
            var tabla = _acceso.Read("sp_paquete_obtener_todos");
            foreach (DataRow row in tabla.Rows)
            {
                var id = Convert.ToInt32(row["Id"]);
                var nombre = row["Nombre"].ToString();
                var descuento = Convert.ToDecimal(row["Descuento"]);
                // 2) Cargar recursivamente cada paquete
                lista.Add(CargarPaquete(id, nombre, descuento));
            }

            _acceso.Close();
            return lista;
        }

        public PaquetePromocional ObtenerPorId(int id)
        {
            _acceso.Open();

            // 1) Traer cabecera
            var tabla = _acceso.Read(
                "sp_paquete_obtener_por_id",
                new List<SqlParameter> { _acceso.CreateParameter("@Id", id) }
            );

            if (tabla.Rows.Count == 0)
            {
                _acceso.Close();
                return null;
            }

            var row = tabla.Rows[0];
            var nombre = row["Nombre"].ToString();
            var descuento = Convert.ToDecimal(row["Descuento"]);
            // 2) Cargar recursivamente
            var paquete = CargarPaquete(id, nombre, descuento);

            _acceso.Close();
            return paquete;
        }

        /// <summary>
        /// Método interno que asume la conexión ya abierta y carga tanto
        /// los elementos directos como los sub-paquetes de forma recursiva.
        /// </summary>
        private PaquetePromocional CargarPaquete(int id, string nombre, decimal descuento)
        {
            var paquete = new PaquetePromocional
            {
                Id = id,
                Nombre = nombre,
                Descuento = descuento,
                Elementos = new List<IVisitado>() // Asegúrate de inicializarla así
            };

            // 1) Leer los vínculos a productos y sub-paquetes
            var tablaElem = _acceso.Read(
                "sp_paqueteelementos_obtener_por_paquete",
                new List<SqlParameter> { _acceso.CreateParameter("@PaqueteId", id) }
            );

            foreach (DataRow rowElem in tablaElem.Rows)
            {
                var tipo = rowElem["ElementoTipo"].ToString();
                var elemId = Convert.ToInt32(rowElem["ElementoId"]);

                if (tipo == "P")
                {
                    // 2a) Obtener producto
                    var tablaProd = _acceso.Read(
                        "sp_producto_obtener_por_id",
                        new List<SqlParameter> { _acceso.CreateParameter("@Id", elemId) }
                    );
                    if (tablaProd.Rows.Count > 0)
                    {
                        var r = tablaProd.Rows[0];
                        paquete.Elementos.Add(new Producto
                        {
                            Id = elemId,
                            Nombre = r["Nombre"].ToString(),
                            Precio = Convert.ToDecimal(r["Precio"])
                        });
                    }
                }
                else // 'C' = sub-paquete
                {
                    // 2b) Obtener datos del sub-paquete y recursión
                    var tablaSub = _acceso.Read(
                        "sp_paquete_obtener_por_id",
                        new List<SqlParameter> { _acceso.CreateParameter("@Id", elemId) }
                    );
                    if (tablaSub.Rows.Count > 0)
                    {
                        var r = tablaSub.Rows[0];
                        paquete.Elementos.Add(
                            CargarPaquete(
                                elemId,
                                r["Nombre"].ToString(),
                                Convert.ToDecimal(r["Descuento"])
                            )
                        );
                    }
                }
            }

            return paquete;
        }
    }
}



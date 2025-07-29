// DAL/PaquetePromocionalDAL.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

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
            _acceso.Open();
            var lista = new List<PaquetePromocional>();
            var dt = _acceso.Read("sp_paquete_obtener_todos");
            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt32(row["Id"]);
                var nombre = row["Nombre"].ToString();
                var descuento = Convert.ToDecimal(row["Descuento"]);
                lista.Add(CargarPaquete(id, nombre, descuento));
            }
            _acceso.Close();
            return lista;
        }

        public PaquetePromocional ObtenerPorId(int id)
        {
            _acceso.Open();
            var pars = new List<SqlParameter> { _acceso.CreateParameter("@Id", id) };
            var dt = _acceso.Read("sp_paquete_obtener_por_id", pars);
            if (dt.Rows.Count == 0)
            {
                _acceso.Close();
                return null;
            }

            var row = dt.Rows[0];
            var nombre = row["Nombre"].ToString();
            var descuento = Convert.ToDecimal(row["Descuento"]);
            var paquete = CargarPaquete(id, nombre, descuento);
            _acceso.Close();
            return paquete;
        }

        private PaquetePromocional CargarPaquete(int id, string nombre, decimal descuento)
        {
            var paquete = new PaquetePromocional
            {
                Id = id,
                Nombre = nombre,
                Descuento = descuento,
                Elementos = new List<IVisitado>()
            };

            // Obtener los elementos del paquete
            var parsElem = new List<SqlParameter> { _acceso.CreateParameter("@PaqueteId", id) };
            var dtElem = _acceso.Read("sp_paqueteelementos_obtener_por_paquete", parsElem);

            foreach (DataRow rowElem in dtElem.Rows)
            {
                var tipo = rowElem["ElementoTipo"].ToString();
                var elemId = Convert.ToInt32(rowElem["ElementoId"]);

                if (tipo == "P")
                {
                    // Usar un Acceso separado para no clausurar la conexión principal
                    var prodDal = new ProductoDAL(new Acceso());
                    var producto = prodDal.ObtenerPorId(elemId);
                    if (producto != null)
                        paquete.Elementos.Add(producto);
                }
                else // Sub-paquete
                {
                    var subDal = new PaquetePromocionalDAL(new Acceso());
                    var subPaquete = subDal.ObtenerPorId(elemId);
                    if (subPaquete != null)
                        paquete.Elementos.Add(subPaquete);
                }
            }

            return paquete;
        }

        public int Insertar(PaquetePromocional paquete)
        {
            _acceso.Open();
            // Insertar cabecera
            var parsCab = new List<SqlParameter>
            {
                _acceso.CreateParameter("@Nombre", paquete.Nombre),
                _acceso.CreateParameter("@Descuento", paquete.Descuento)
            };
            int newId = Convert.ToInt32(_acceso.WriteScalar("sp_paquete_insertar", parsCab));

            // Insertar elementos
            foreach (var elem in paquete.Elementos)
            {
                var tipo = elem is Producto ? 'P' : 'C';
                var id = elem is Producto p ? p.Id : ((PaquetePromocional)elem).Id;
                var parsE = new List<SqlParameter>
                {
                    _acceso.CreateParameter("@PaqueteId", newId),
                    _acceso.CreateParameter("@ElementoId", id),
                    _acceso.CreateParameter("@ElementoTipo", tipo)
                };
                _acceso.Write("sp_paqueteelementos_insertar", parsE);
            }

            _acceso.Close();
            return newId;
        }

        public void Actualizar(PaquetePromocional paquete)
        {
            _acceso.Open();
            // Actualizar cabecera
            var parsUpd = new List<SqlParameter>
            {
                _acceso.CreateParameter("@Id", paquete.Id),
                _acceso.CreateParameter("@Nombre", paquete.Nombre),
                _acceso.CreateParameter("@Descuento", paquete.Descuento)
            };
            _acceso.Write("sp_paquete_actualizar", parsUpd);

            // Borrar elementos previos
            _acceso.Write(
                "sp_paqueteelementos_borrar_por_paquete",
                new List<SqlParameter> { _acceso.CreateParameter("@PaqueteId", paquete.Id) }
            );

            // Reinsertar
            foreach (var elem in paquete.Elementos)
            {
                var tipo = elem is Producto ? 'P' : 'C';
                var id = elem is Producto p ? p.Id : ((PaquetePromocional)elem).Id;
                var parsE = new List<SqlParameter>
                {
                    _acceso.CreateParameter("@PaqueteId", paquete.Id),
                    _acceso.CreateParameter("@ElementoId", id),
                    _acceso.CreateParameter("@ElementoTipo", tipo)
                };
                _acceso.Write("sp_paqueteelementos_insertar", parsE);
            }

            _acceso.Close();
        }

        public void Eliminar(int id)
        {
            _acceso.Open();
            // Borrar elementos
            _acceso.Write(
                "sp_paqueteelementos_borrar_por_paquete",
                new List<SqlParameter> { _acceso.CreateParameter("@PaqueteId", id) }
            );
            // Borrar paquete
            _acceso.Write(
                "sp_paquete_borrar",
                new List<SqlParameter> { _acceso.CreateParameter("@Id", id) }
            );
            _acceso.Close();
        }
    }
}

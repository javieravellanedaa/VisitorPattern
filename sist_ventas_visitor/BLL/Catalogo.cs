using BE;
using BLL;
using DAL;
using System.Collections.Generic;


namespace BLL
{
    public class Catalogo
    {
        private readonly Acceso _acceso;

        public Catalogo()
        {
            _acceso = new Acceso();
        }

        /// <summary>
        /// Carga los productos y paquetes desde BD en una lista de IVisitado.
        /// </summary>
        private List<IVisitado> CargarEstructura()
        {
            // instancio DAL concretos
            var productoDal = new ProductoDAL(_acceso);
            var paqueteDal = new PaquetePromocionalDAL(_acceso);

            // Cargo productos y paquetes
            var estructura = new List<IVisitado>();
            _acceso.Open();
            estructura.AddRange(productoDal.ObtenerTodos());
            estructura.AddRange(paqueteDal.ObtenerTodos());
            _acceso.Close();

            return estructura;
        }

        /// <summary>
        /// Calcula el total de ventas de todo el catálogo (productos + paquetes).
        /// </summary>
        public decimal CalcularTotalVentas()
        {
            var estructura = CargarEstructura();
            var visitor = new CalculadorDeVentasVisitor();
            foreach (var item in estructura)
                item.Aceptar(visitor);
            return visitor.Total;
        }

        /// <summary>
        /// Obtiene el listado de líneas con el detalle de impuestos aplicados a cada elemento.
        /// </summary>
        public IEnumerable<string> CalcularImpuestos(decimal tasaImpuesto)
        {
            var estructura = CargarEstructura();
            var visitor = new AplicadorDeImpuestosVisitor(tasaImpuesto);
            foreach (var item in estructura)
                item.Aceptar(visitor);
            return visitor.LineasImpuestos;
        }

        /// <summary>
        /// Genera etiquetas formateadas para cada producto y paquete del catálogo.
        /// </summary>
        public IEnumerable<string> GenerarEtiquetas()
        {
            var estructura = CargarEstructura();
            var visitor = new GeneradorDeEtiquetasVisitor();
            foreach (var item in estructura)
                item.Aceptar(visitor);
            return visitor.Etiquetas;
        }
    }
}


// BLL/Catalogo.cs
using System;
using System.Collections.Generic;
using System.Linq;
using BE;
using DAL;

namespace BLL
{
    public class Catalogo
    {
        private readonly ProductoDAL _productoDal;
        private readonly PaquetePromocionalDAL _paqueteDal;

        public Catalogo()
        {
            var acceso = new Acceso();
            _productoDal = new ProductoDAL(acceso);
            _paqueteDal = new PaquetePromocionalDAL(acceso);
        }

        public List<IVisitado> ObtenerEstructura()
        {
            var lista = new List<IVisitado>();
            lista.AddRange(_productoDal.ObtenerTodos());
            lista.AddRange(_paqueteDal.ObtenerTodos());
            return lista;
        }

        public decimal CalcularValorCatalogo()
        {
            var visitor = new CalculadorDeVentasVisitor();
            foreach (var item in ObtenerEstructura())
                item.Aceptar(visitor);
            return visitor.Total;
        }

        public decimal CalcularTotalVentas() => CalcularValorCatalogo();

        public IEnumerable<string> CalcularImpuestos(decimal tasaImpuesto)
        {
            var visitor = new AplicadorDeImpuestosVisitor(tasaImpuesto);
            foreach (var item in ObtenerEstructura())
                item.Aceptar(visitor);
            return visitor.LineasImpuestos;
        }

        public IEnumerable<string> GenerarEtiquetas()
        {
            var visitor = new GeneradorDeEtiquetasVisitor();
            foreach (var item in ObtenerEstructura())
                item.Aceptar(visitor);
            return visitor.Etiquetas;
        }

  

        public IEnumerable<Producto> ObtenerProductos()
            => _productoDal.ObtenerTodos();

        public int AgregarProducto(string nombre, decimal precio)
        {
            var p = new Producto { Nombre = nombre, Precio = precio };
            return _productoDal.Insertar(p);
        }

        public void ModificarProducto(Producto producto)
            => _productoDal.Actualizar(producto);

        public void EliminarProducto(int id)
            => _productoDal.Eliminar(id);



        public IEnumerable<PaquetePromocional> ObtenerPaquetes()
            => _paqueteDal.ObtenerTodos();

        public PaquetePromocional ObtenerPaquetePorId(int id)
            => _paqueteDal.ObtenerPorId(id);


        public void AgregarPaquete(string nombre, decimal descuento, List<(char Tipo, int Id)> elementos)
        {
            var paquete = new PaquetePromocional
            {
                Nombre = nombre,
                Descuento = descuento,
                Elementos = elementos.Select(e =>
                    e.Tipo == 'P'
                        ? (IVisitado)_productoDal.ObtenerPorId(e.Id)
                        : (IVisitado)_paqueteDal.ObtenerPorId(e.Id)
                ).ToList()
            };
            _paqueteDal.Insertar(paquete);
        }

        public void ModificarPaquete(PaquetePromocional paquete, List<(char Tipo, int Id)> elementos)
        {
            paquete.Elementos = elementos.Select(e =>
                e.Tipo == 'P'
                    ? (IVisitado)_productoDal.ObtenerPorId(e.Id)
                    : (IVisitado)_paqueteDal.ObtenerPorId(e.Id)
            ).ToList();
            _paqueteDal.Actualizar(paquete);
        }

        public void EliminarPaquete(int id)
            => _paqueteDal.Eliminar(id);
    }
}

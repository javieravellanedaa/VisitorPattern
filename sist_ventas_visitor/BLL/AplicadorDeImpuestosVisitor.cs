using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AplicadorDeImpuestosVisitor : IVisitante
    {
        readonly decimal tasa;
        public List<string> LineasImpuestos { get; } = new List<string>();

        public AplicadorDeImpuestosVisitor(decimal tasaImpuesto)
        {
            tasa = tasaImpuesto;
        }

        public void Visitar(Producto producto)
        {
            var basePrecio = producto.Precio;
            var monto = basePrecio * tasa;
            var total = basePrecio + monto;
            LineasImpuestos.Add(
                $"Producto {producto.Nombre}: base=${basePrecio:0.00}, impuesto=${monto:0.00}, total=${total:0.00}"
            );
        }

        public void Visitar(PaquetePromocional paquete)
        {
          
            foreach (var elemento in paquete.Elementos)
                elemento.Aceptar(this);
        }
    }
}

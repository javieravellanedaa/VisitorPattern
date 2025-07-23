using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CalculadorDeVentasVisitor : IVisitante
    {
        decimal total;
        public decimal Total
        {
            get { return total; }
        }


        public void Visitar(Producto producto)
        {
            total += producto.Precio;
        }

        public void Visitar(PaquetePromocional paquete)
        {
            
            var antes = total;
            foreach (var elemento in paquete.Elementos)
                elemento.Aceptar(this);
            var subtotal = total - antes;
            total -= subtotal * paquete.Descuento;
        }
    }
}

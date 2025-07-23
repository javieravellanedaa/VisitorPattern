using BE;
using System.Collections.Generic;

namespace BLL
{
    public class GeneradorDeEtiquetasVisitor : IVisitante
    {
        public List<string> Etiquetas { get; } = new List<string>();

        public void Visitar(Producto producto)
        {
            Etiquetas.Add($"{producto.Nombre} — ${producto.Precio:0.00}");
        }

        public void Visitar(PaquetePromocional paquete)
        {
         
            var nombres = new List<string>();
            foreach (var elemento in paquete.Elementos)
            {
                if (elemento is Producto prod)
                    nombres.Add(prod.Nombre);
                else if (elemento is PaquetePromocional subPaquete)
                    nombres.Add(subPaquete.Nombre);
            }

            Etiquetas.Add(
                $"Paquete \"{paquete.Nombre}\" — Incluye: {string.Join(", ", nombres)} ({paquete.Descuento:P} OFF)"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto:IVisitado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public override string ToString() => Nombre;
        public void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PaquetePromocional : IVisitado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  
        public decimal Descuento { get; set; }
        public List<IVisitado> Elementos { get; set; } = new List<IVisitado>();
        public void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}

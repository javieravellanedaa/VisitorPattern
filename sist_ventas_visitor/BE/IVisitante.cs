﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IVisitante
    {
        void Visitar(Producto producto);
        void Visitar(PaquetePromocional paquete);

    }
}

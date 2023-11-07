﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public interface IObservadorProducto
    {
        void Actualizar(ArgumentosObservadorProducto args);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class ObservadorStockProducto : IObservadorProducto
    {
        public void Actualizar(ArgumentosObservadorProducto args)
        {
            if (args.PrecioAnterior.GetValueOrDefault() > 0 || args.NuevoStock == 0) return;

            //TODO Inyectar un servicio y obtener usuarios suscritos al producto.
            Console.WriteLine($"El producto está en stock. Stock: {args.NuevoStock}");
        }
    }
}



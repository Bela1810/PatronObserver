using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class ObservadorPrecioProducto : IObservadorProducto
{
        public void Actualizar(ArgumentosObservadorProducto args)
        {
            if (args.NuevoPrecio.GetValueOrDefault() >= args.PrecioAnterior.GetValueOrDefault()) return;

            //TODO Inyectar un servicio y obtener usuarios suscritos al producto.
            Console.WriteLine($"El precio del producto ha bajado. {args.PrecioAnterior} -> {args.NuevoPrecio}");
        }
    }
}

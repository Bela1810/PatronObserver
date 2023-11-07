using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class Producto : ProductoObservable
    {
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void ActualizarStock(int stock)
        {
            var stockAnterior = Stock;
            Stock = stock;

            NotificarObservadores(new ArgumentosObservadorProducto
            {
                Id = Id,
                StockAnterior = stockAnterior,
                NuevoStock = stock
            });
        }

        public void ActualizarPrecio(decimal precio)
        {
            var precioAnterior = Precio;
            Precio = precio;

            NotificarObservadores(new ArgumentosObservadorProducto
            {
                Id = Id,
                PrecioAnterior = precioAnterior,
                NuevoPrecio = precio
            });
        }
    }
}

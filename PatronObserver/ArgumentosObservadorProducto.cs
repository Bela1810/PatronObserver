using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{

    public record ArgumentosObservadorProducto
    {
        public int Id { get; set; }
        public int? StockAnterior { get; init; }
        public int? NuevoStock { get; init; }
        public decimal? PrecioAnterior { get; init; }
        public decimal? NuevoPrecio { get; init; }
    }
}

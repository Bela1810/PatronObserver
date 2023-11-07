using PatronObserver;
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        var producto = new Producto
        {
            Id = 1453,
            Precio = 1000M,
            Stock = 0
        };

        producto.AgregarObservador(new ObservadorPrecioProducto());
        producto.AgregarObservador(new ObservadorStockProducto());

        producto.ActualizarPrecio(999M);
        producto.ActualizarStock(10);
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public interface IObservableProducto
    {
        void AgregarObservador(IObservadorProducto observador);
        void QuitarObservador(IObservadorProducto observador);
        void NotificarObservadores(ArgumentosObservadorProducto args);
    }

}



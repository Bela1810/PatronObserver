using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public abstract class ProductoObservable : IObservableProducto
    {
        private readonly List<IObservadorProducto> _observadores = new List<IObservadorProducto>();

        public void AgregarObservador(IObservadorProducto observador)
        {
            _observadores.Add(observador);
        }

        public void QuitarObservador(IObservadorProducto observador)
        {
            _observadores.Remove(observador);
        }

        public void NotificarObservadores(ArgumentosObservadorProducto args)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(args);
            }
        }
    }



}

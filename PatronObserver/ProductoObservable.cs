using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class ProductoObservable
    {
        private List<IObservadorProducto> Observadores { get; set; } = new();

        public void AgregarObservador(IObservadorProducto observador)
        {
            Observadores.Add(observador);
        }

        public void QuitarObservador(IObservadorProducto observador)
        {
            Observadores.Remove(observador);
        }

        protected void Notificar(ArgumentosObservadorProducto args)
        {
            foreach (var observador in Observadores)
            {
                observador.Actualizar(args);
            }
        }
    }
}

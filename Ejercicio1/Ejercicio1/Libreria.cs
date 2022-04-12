namespace Ejercicio1
{
    public class Libreria
    {
        public Venta ventaActual;
        private float _total = 0;

        public Libreria()
        {
            ventaActual = new Venta();
        }

        public float Total { get => _total; }

        public void FinalizarVenta()
        {
            _total += ventaActual.Total;
            ventaActual.Limpiar();
        }

    }
}
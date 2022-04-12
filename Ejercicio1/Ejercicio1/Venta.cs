
namespace Ejercicio1
{
    public class Venta
    {
        private float _total = 0;

        public float Total { get => _total; }

        public void AgregarProducto(int cantidad, Producto producto)
        {
            _total += cantidad * producto.Precio;
        }


        public void Limpiar()
        {
            _total = 0;
        }

    }
}
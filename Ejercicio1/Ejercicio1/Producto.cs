namespace Ejercicio1
{
    public class Producto
    {
        private string _codigoBarra;
        private string _nombre;
        private string _descripcion;
        private float _precio;

        public string CodigoBarra { get => _codigoBarra; set => _codigoBarra = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public float Precio { get => _precio; set => _precio = value; }

        public string DisplayText { get => _codigoBarra + " - " + _nombre + " $" + _precio; }
    }
}
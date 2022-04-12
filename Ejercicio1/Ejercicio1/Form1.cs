using System;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        readonly Libreria libreria = new Libreria();

        public Form1()
        {
            InitializeComponent();

            lbProductos.DisplayMember = "DisplayText";

            Producto lapiz = new Producto { CodigoBarra = "123", Nombre = "Lapiz", Descripcion = "-", Precio = 12 };
            Producto lapicera = new Producto { CodigoBarra = "456", Nombre = "Lapicera", Descripcion = "-", Precio = 20 };
            Producto regla = new Producto { CodigoBarra = "897", Nombre = "Regla", Descripcion = "-", Precio = 35 };

            lbProductos.Items.Add(lapiz);
            lbProductos.Items.Add(lapicera);
            lbProductos.Items.Add(regla);

            lbProductos.SelectedIndex = 0;
        }


        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Ingrese un código de barras!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Ingrese una descripción!");
                return;
            }



            Producto producto = new Producto
            {
                CodigoBarra = txtCodigoBarra.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Precio = (float)numPrecio.Value
            };

            lbProductos.Items.Add(producto);
        }

        private void btnAgregarAVenta_Click(object sender, EventArgs e)
        {

            int cantidad = (int)numCantidad.Value;
            Producto producto = (Producto)lbProductos.SelectedItem;

            libreria.ventaActual.AgregarProducto(cantidad, producto);

            lblTotal.Text = "$ " + libreria.ventaActual.Total.ToString();
        }

        void LimpiarVentaActual()
        {
            libreria.ventaActual.Limpiar();
            lblTotal.Text = "$ 0";
        }


        private void lbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            lblProductoSeleccionado.Text = ((Producto)lbProductos.SelectedItem).DisplayText;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVentaActual();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            libreria.FinalizarVenta();
            LimpiarVentaActual();

            lblRecaudacion.Text = "$ " + libreria.Total;
        }
    }
}

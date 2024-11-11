using Datos;
using Persistencia;
using System;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Ventas
{
    public partial class VentasForm : Form
    {
        public String IDUSUARIO = "1d2de37f-6cb8-48ad-9b59-395a46b74c57";
        private ClientesWS clientesWS;
        private ProductosWS productosWS;
        private VentasWS ventasWS; // Servicio para ventas

        public VentasForm()
        {
            InitializeComponent();
            clientesWS = new ClientesWS();
            productosWS = new ProductosWS();
            ventasWS = new VentasWS(); // Instancia del servicio de ventas

            CargarClientes();
            CargarProductos();

            cmb_clientes.SelectedIndexChanged += cmb_clientes_SelectedIndexChanged;
            cmb_productos.SelectedIndexChanged += cmb_productos_SelectedIndexChanged;
        }

        private void CargarClientes()
        {
            var clientesActivos = clientesWS.buscarDatosCliente();

            if (clientesActivos != null)
            {
                cmb_clientes.DataSource = null;
                cmb_clientes.Items.Clear();

                cmb_clientes.DataSource = clientesActivos;
                cmb_clientes.DisplayMember = "nombre"; // Muestra el nombre del cliente
                cmb_clientes.ValueMember = "Id";       // Configura el ID como valor interno

                cmb_clientes.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            var productosActivos = productosWS.buscarDatosProducto(); // Llama al método para obtener productos

            if (productosActivos != null)
            {
                cmb_productos.DataSource = null;
                cmb_productos.Items.Clear();

                cmb_productos.DataSource = productosActivos;
                cmb_productos.DisplayMember = "Nombre"; // Muestra el nombre del producto
                cmb_productos.ValueMember = "Id";       // Configura el ID como valor interno

                cmb_productos.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los productos activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_clientes.SelectedIndex != -1)
            {
                var clienteSeleccionado = cmb_clientes.SelectedItem as ClienteWS;

                if (clienteSeleccionado != null)
                {
                    dni_txt.Text = clienteSeleccionado.dni.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_productos.SelectedIndex != -1)
            {
                var productoSeleccionado = cmb_productos.SelectedItem as ProductoWS;

                if (productoSeleccionado != null)
                {
                    stock_int.Text = productoSeleccionado.stock.ToString(); // Muestra el stock del producto en el TextBox
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void agregarcarrito_btn_Click(object sender, EventArgs e)
        {
            // Obtiene los valores seleccionados
            if (cmb_clientes.SelectedValue == null || cmb_productos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente y un producto antes de agregar al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idCliente = cmb_clientes.SelectedValue.ToString();
            string idProducto = cmb_productos.SelectedValue.ToString();
            int cantidad;

            // Verifica que la cantidad sea un número válido
            if (!int.TryParse(cantidad_int.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método AgregarVenta en VentasWS
            bool ventaAgregada = ventasWS.AgregarVenta(idCliente, IDUSUARIO, idProducto, cantidad);

            if (ventaAgregada)
            {
                MessageBox.Show("Venta agregada exitosamente al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar la venta. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

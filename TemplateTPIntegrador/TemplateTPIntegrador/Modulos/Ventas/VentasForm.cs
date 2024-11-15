using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Ventas
{
    public partial class VentasForm : Form
    {
        public String IDUSUARIO = "1d2de37f-6cb8-48ad-9b59-395a46b74c57";
        private ClientesWS clientesWS;
        private ProductosWS productosWS;
        private VentasWS ventasWS; // Servicio para ventas
        private double totalAcumulado = 0; // Total acumulado para el carrito
        private BindingList<CarritoItem> carrito = new BindingList<CarritoItem>();

        public class CarritoItem
        {
            public string IdProducto { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double PrecioUnitario { get; set; } // Precio unitario del producto
            public double Total { get; set; } // Total = Cantidad * PrecioUnitario
        }

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
            btnEliminar.Click += btnEliminar_Click;
            finalizar_btn.Click += btnFinalizarCompra_Click; // Botón para confirmar la venta
        }

        private void CargarClientes()
        {
            var clientesActivos = clientesWS.buscarDatosCliente();

            if (clientesActivos != null)
            {
                cmb_clientes.DataSource = null;
                cmb_clientes.Items.Clear();

                cmb_clientes.DataSource = clientesActivos;
                cmb_clientes.DisplayMember = "dni";
                cmb_clientes.ValueMember = "Id";

                cmb_clientes.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            var productosActivos = productosWS.buscarDatosProducto();

            if (productosActivos != null)
            {
                cmb_productos.DataSource = null;
                cmb_productos.Items.Clear();

                cmb_productos.DataSource = productosActivos;
                cmb_productos.DisplayMember = "Nombre";
                cmb_productos.ValueMember = "Id";

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
                    txt_nombreCliente.Text = clienteSeleccionado.nombre;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecioUnitario.Text = string.Empty;
            stock_int.Text = string.Empty;
            if (cmb_productos.SelectedIndex != -1)
            {
                var productoSeleccionado = cmb_productos.SelectedItem as ProductoWS;

                if (productoSeleccionado != null)
                {
                    stock_int.Text = productoSeleccionado.stock.ToString();
                    txtPrecioUnitario.Text = productoSeleccionado.precio.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmb_productos.SelectedValue == null || cmb_clientes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente y un producto antes de agregar al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idProducto = cmb_productos.SelectedValue.ToString();
            int cantidad;
            if (!int.TryParse(cantidad_int.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productoSeleccionado = productosWS.buscarDatosProducto().FirstOrDefault(p => p.id.ToString() == idProducto);
            if (productoSeleccionado == null)
            {
                MessageBox.Show("No se pudo encontrar el precio del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double precioUnitario = productoSeleccionado.precio;
            string nombreProducto = productoSeleccionado.nombre;

            var itemExistente = carrito.FirstOrDefault(item => item.IdProducto == idProducto);
            int cantidadEnCarrito = itemExistente != null ? itemExistente.Cantidad : 0;

            if (cantidadEnCarrito + cantidad > productoSeleccionado.stock)
            {
                MessageBox.Show("No hay suficiente stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (itemExistente != null)
            {
                itemExistente.Cantidad += cantidad;
                itemExistente.Total = itemExistente.Cantidad * itemExistente.PrecioUnitario;
            }
            else
            {
                var nuevaVenta = new CarritoItem
                {
                    IdProducto = idProducto,
                    Nombre = nombreProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                    Total = precioUnitario * cantidad
                };
                carrito.Add(nuevaVenta);
            }

            dataGridViewCarrito.DataSource = null;
            dataGridViewCarrito.DataSource = carrito;
            totalAcumulado += precioUnitario * cantidad;
            lbl_Total.Text = $"Total acumulado: ${totalAcumulado:F2}";
            MessageBox.Show("Producto agregado exitosamente al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

            FacturaForm formComprobante = new FacturaForm();
            formComprobante.Show();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas antes de proceder
            if (dataGridViewCarrito.SelectedRows.Count > 0)
            {
                // Recorre las filas seleccionadas en el DataGridView
                foreach (DataGridViewRow row in dataGridViewCarrito.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        CarritoItem item = row.DataBoundItem as CarritoItem;
                        if (item != null)
                        {
                            carrito.Remove(item); // Elimina el elemento directamente de BindingList
                            totalAcumulado -= item.Total; // Resta el total del item eliminado
                        }
                    }
                }

                // Actualiza el total acumulado
                lbl_Total.Text = $"Total acumulado: ${totalAcumulado:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos una fila para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}


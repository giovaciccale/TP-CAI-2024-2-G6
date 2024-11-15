using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Ventas
{
    public partial class CarritoVentas : Form
    {
        public CarritoVentas(List<VentasForm.CarritoItem> carrito, double totalAcumulado)
        {
            InitializeComponent();

            // Asigna la lista de carrito al DataGridView
            dataGridViewCarrito.DataSource = carrito;

            // Muestra el total acumulado en un Label
            lbl_Total.Text = $"Total acumulado: ${totalAcumulado:F2}";
        }
    }
}
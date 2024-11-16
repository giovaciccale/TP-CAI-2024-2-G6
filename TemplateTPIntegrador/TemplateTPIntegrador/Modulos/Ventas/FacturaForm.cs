using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Ventas
{
    public partial class FacturaForm : Form
    {

        private List<CarritoItem> carrito;
        private List<Promocion> promociones;

        public FacturaForm(List<CarritoItem> carrito, string nombrCompletoCliente, string dniCliente, double total, List<Promocion> promociones)
        {
            InitializeComponent();
            this.carrito = carrito;
            this.promociones = promociones;

            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = carrito;

            dgvPromociones.DataSource = null;
            dgvPromociones.DataSource = promociones;

            txtCliente.Text = nombrCompletoCliente;
            textBox1.Text = dniCliente;
            txtTotal.Text = total.ToString("F2");

            dgvDetalle.DataSource = carrito;
        }

        private void ConfigurarDgvPromociones()
        {
            dgvPromociones.AutoGenerateColumns = false;

            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Promoción Aplicada"
            });

            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Monto",
                HeaderText = "Monto Descuento",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2"}
            });

            dgvPromociones.DataSource = promociones;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturaForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada con Éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

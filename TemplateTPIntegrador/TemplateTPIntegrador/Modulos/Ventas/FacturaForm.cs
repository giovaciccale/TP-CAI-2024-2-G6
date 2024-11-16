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
        public FacturaForm(BindingList<VentasForm.CarritoItem> carrito, string nombrCompletoCliente, string dniCliente, double totalAcumulado)
        {
            InitializeComponent();
            txtCliente.Text = nombrCompletoCliente;
            textBox1.Text = dniCliente;
            txtTotal.Text = totalAcumulado.ToString("F2");

            dgvDetalle.DataSource = carrito;
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
    }
}

using Persistencia;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Clientes
{
    public partial class BuscarClientesForm : Form
    {
        public String IDUSUARIO = "3220f419-a126-47a1-950f-202d19be8d4c";
        private ClientesWS clientesWS;
        public BuscarClientesForm()
        {
            InitializeComponent();
            clientesWS = new ClientesWS();
            CargarClientes();
        }

        private void CargarClientes()
        {
            var clientesActivos = clientesWS.buscarDatosCliente();

            if (clientesActivos != null)
            {
                // Limpia el ComboBox antes de agregar nuevos items
                cmb_clientes.DataSource = null;
                cmb_clientes.Items.Clear();

                // Bind ComboBox to List of ClienteWS
                cmb_clientes.DataSource = clientesActivos;
                cmb_clientes.DisplayMember = "dni"; // campo que mostrara
                cmb_clientes.ValueMember = "Id";       // Ensure ClienteWS has this property

                // Previene autoseleccion
                cmb_clientes.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {

            if (cmb_clientes.SelectedItem is ClienteWS clienteSeleccionado)
            {
                txt_nombre.Text = clienteSeleccionado.nombre;
                txt_apellido.Text = clienteSeleccionado.apellido;
                txt_email.Text = clienteSeleccionado.email;
                txt_fechaNacimiento.Text = clienteSeleccionado.fechaNacimiento.ToString("yyyy-MM-dd");
                txt_dni.Text = clienteSeleccionado.dni.ToString();
                txt_direccion.Text = clienteSeleccionado.direccion;
                txt_telefono.Text = clienteSeleccionado.telefono;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
    }
}

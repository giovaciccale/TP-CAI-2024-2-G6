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
                // Limpia el ComboBox antes de llenarlo
                cmb_clientes.Items.Clear();

                // Llenar el ComboBox con los nombres de usuario y sus IDs
                foreach (var cliente in clientesActivos)
                {
                    // Agrega un nuevo objeto con el nombre y el ID del usuario
                    cmb_clientes.Items.Add(new { Nombre = cliente.nombre, Id = cliente.Id }); // Asegúrate de incluir Id aquí
                }

                // Establecer el formato para mostrar el nombre en el ComboBox
                cmb_clientes.DisplayMember = "Nombre"; // Campo que se mostrará
                cmb_clientes.ValueMember = "Id"; // Campo que se utilizará como valor
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            var clientesActivos = clientesWS.buscarDatosCliente();
            string nombreSeleccionado = cmb_clientes.Text;

            ClientesWS clienteSeleccionado = clientes.FirstOrDefault(cliente => clientesActivos.nombre == nombreSeleccionado);

            if (clienteSeleccionado != null)
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
                MessageBox.Show($"El cliente '{nombreSeleccionado}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } */
    }
}

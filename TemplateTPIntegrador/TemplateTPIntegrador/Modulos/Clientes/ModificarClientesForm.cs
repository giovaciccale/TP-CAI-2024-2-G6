using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace TemplateTPIntegrador.Modulos.Clientes
{
    public partial class ModificarClientesForm : Form
    {

        public String IDUSUARIO = "3220f419-a126-47a1-950f-202d19be8d4c";
        private ClientesWS clientesWS;

        public ModificarClientesForm()
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

        private void cmb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            var clienteSeleccionado = (ClienteWS)cmb_clientes.SelectedItem;

            if (clienteSeleccionado != null)
            {
                txt_direccion.Text = clienteSeleccionado.direccion;
                txt_email.Text = clienteSeleccionado.email;
                txt_telefono.Text = clienteSeleccionado.telefono;
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            var clienteSeleccionado = (ClienteWS)cmb_clientes.SelectedItem;

            if (clienteSeleccionado != null)
            {
                string nuevaDireccion = txt_direccion.Text;
                string nuevoTelefono = txt_telefono.Text;
                string nuevoEmail = txt_email.Text;

                string idClientesString = clienteSeleccionado.Id.ToString();


                ClientesWS clientesWS = new ClientesWS();
                bool resultado = clientesWS.ActualizarDatosCliente(idClientesString, nuevaDireccion, nuevoTelefono, nuevoEmail);

                if (resultado)
                {
                    MessageBox.Show("Datos actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            panelSeleccionarCliente.BackColor = SystemColors.Control;
            cmb_clientes.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDireccion.BackColor = Color.White;
            txt_direccion.BackColor = Color.White;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }
        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            panelSeleccionarCliente.BackColor = SystemColors.Control;
            cmb_clientes.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            panelSeleccionarCliente.BackColor = SystemColors.Control;
            cmb_clientes.BackColor = SystemColors.Control;
            panelEmail.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }
    }
}

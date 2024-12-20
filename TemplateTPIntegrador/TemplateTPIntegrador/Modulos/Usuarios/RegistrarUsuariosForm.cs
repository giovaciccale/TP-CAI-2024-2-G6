using Datos;
using Negocio.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia; // Para acceder a UsuariosWS y LoginWS
using TemplateTPIntegrador.utils;

namespace TemplateTPIntegrador
{
    public partial class RegistrarUsuariosForm : Form
    {
        public String adminId = "990a1069-0e96-4b2b-8f8e-bc3d49d0cc30";
        public String contraseñaTemporal = "CAI20232";


        private string host = "1"; // Valor predeterminado para "Vendedor"
        public RegistrarUsuariosForm()
        {
            InitializeComponent();
            comboBoxTipoUsuario.Items.Add("Administrador");
            comboBoxTipoUsuario.Items.Add("Supervisor");
            comboBoxTipoUsuario.Items.Add("Vendedor");

            // Vincular el evento SelectedIndexChanged
            comboBoxTipoUsuario.SelectedIndexChanged += comboBoxTipoUsuario_SelectedIndexChanged;

        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegúrate de que SelectedItem no sea null
            if (comboBoxTipoUsuario.SelectedItem != null)
            {
                switch (comboBoxTipoUsuario.SelectedItem.ToString())
                {
                    case "Administrador":
                        host = "3";
                        break;
                    case "Supervisor":
                        host = "2";
                        break;
                    case "Vendedor":
                        host = "1";
                        break;
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();
            
            try
            {
                // Validar el nombre de usuario antes de crear el usuario
                if (!validacionesNegocioUtils.ValidarNombreUsuario(txt_usuario.Text, txt_nombre.Text, txt_apellido.Text))
                {
                    MessageBox.Show("El nombre de usuario debe tener entre 8 y 15 caracteres y no contener el nombre ni el apellido.",
                                    "Validación de Nombre de Usuario",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Salir del método si la validación falla
                }


                // Crear una instancia de UsuarioWS con los datos del formulario
                UsuarioWS usuario = new UsuarioWS
                {
                    idUsuario = adminId,
                    nombre = txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    dni = int.Parse(txt_dni.Text),
                    direccion = txt_direccion.Text,
                    telefono = txt_telefono.Text,
                    email = txt_email.Text,
                    fechaNacimiento = txt_fecha.Value, // Supongamos que tienes un DateTimePicker
                    host = int.Parse(host),  // Usa el valor de host basado en la selección del tipo de usuario
                    nombreUsuario = txt_usuario.Text,
                    contraseña = contraseñaTemporal

                };

                // Muestra un mensaje de depuración
                System.Diagnostics.Debug.WriteLine("Contraseña antes de enviar: " + usuario.contraseña);

                // Instancia de UsuariosWS para gestionar la creación
                UsuariosWS usuariosWS = new UsuariosWS();

                // Intentar agregar el usuario
                bool resultado = usuariosWS.AgregarUsuario(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Llama al método para limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_usuario.Clear();
            comboBoxTipoUsuario.SelectedIndex = -1; // Limpia la selección del ComboBox
            host = "1"; // Restablecer el valor de host al predeterminado
            txt_fecha.Value = DateTime.Now; // Restablecer la fecha al día actual
        }

        private void comboBoxTipoUsuario_Click(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = Color.White;
            panelTipoUsuario.BackColor = Color.White;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = Color.White;
            panelNombre.BackColor = Color.White;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_apellido_Click(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = Color.White;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = Color.White;
            txt_dni.BackColor = Color.White;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = Color.White;
            txt_direccion.BackColor = Color.White;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = Color.White;
            txt_usuario.BackColor = Color.White;
        }

        private void txt_contraseñaAlta_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Contraseña" cuando lo clickea

            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }
    }
}

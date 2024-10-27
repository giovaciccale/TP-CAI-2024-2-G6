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
using Persistencia;


namespace TemplateTPIntegrador
{
    public partial class RegistrarUsuariosForm : Form
    {
        public RegistrarUsuariosForm()
        {
            InitializeComponent();
            txt_host.Items.Add("Administrador");
            txt_host.Items.Add("Supervisor");
            txt_host.Items.Add("Vendedor");

        }

        private int ObtenerHostDesdeComboBox(string tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case "Administrador":
                    return 1;
                case "Supervisor":
                    return 2;
                case "Vendedor":
                    return 3;
                default:
                    return 0; // En caso de error, devuelve 0 o algún valor predeterminado
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
            try
            {
                // Instancia de la clase que maneja las validaciones
                ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

                // Crear una instancia de UsuarioWS con los datos del formulario
                UsuarioWS nuevoUsuario = new UsuarioWS
                {
                    // Recopila los datos del formulario
                    Nombre = txt_nombre.Text,
                    Apellido = txt_apellido.Text,
                    Dni = int.Parse(txt_dni.Text),
                    Direccion = txt_direccion.Text,
                    Telefono = txt_telefono.Text,
                    Email = txt_email.Text,
                    FechaNacimiento = txt_fechaNacimiento.Value,
                    Host = ObtenerHostDesdeComboBox(txt_host.SelectedItem.ToString()) // Método para convertir texto a valor Host
                };

                // Validación del nombre de usuario
                //bool esNombreUsuarioValido = validacionesNegocioUtils.ValidarNombreUsuario(nuevoUsuario.NombreUsuario, nuevoUsuario.Nombre, nuevoUsuario.Apellido);
                //if (!esNombreUsuarioValido)
                //{
                //    MessageBox.Show("El Nombre De Usuario debe tener entre 8 y 15 caracteres y no debe contener el nombre o apellido.",
                //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                // Validación de largo de contraseña y que contenga como mínimo una letra mayúscula y un número
                //bool esContraseñaValido = validacionesNegocioUtils.ValidarContraseña(nuevoUsuario.Contraseña);
                //if (!esContraseñaValido)
                //{
                //    MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres y debe contener como mínimo una letra mayúscula y un número.",
                //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                // Crear una instancia de la clase UsuariosWS
                UsuariosWS usuariosWS = new UsuariosWS();

                // Llamar al método CrearUsuario para enviar los datos a la API
                bool resultado = usuariosWS.CrearUsuario(nuevoUsuario);

                // Mostrar mensaje basado en el resultado
                if (resultado)
                {
                    MessageBox.Show("Usuario creado con éxito!");
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear el usuario. Verifique los datos e intente nuevamente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void comboBoxTipoUsuario_Click(object sender, EventArgs e)
        {
            txt_host.BackColor = Color.White;
            panelTipoUsuario.BackColor = Color.White;
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

        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Nombre" cuando lo clickea

            txt_host.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = Color.White;
            panelNombre.BackColor = Color.White;
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

        }

        private void txt_apellido_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Apellido" cuando lo clickea

            txt_host.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
  
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
        }

        private void txt_numeroRegistro_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
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
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDni.BackColor = Color.White;
            txt_dni.BackColor = Color.White;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
        }
        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = Color.White;
            txt_direccion.BackColor = Color.White;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
        }
        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
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
            panelTelefono.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
            panelNombreUsuario.BackColor = SystemColors.Control;
        }
        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            txt_host.BackColor = SystemColors.Control;
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
            panelNombreUsuario.BackColor = Color.White;

        }
        private void txt_contraseñaAlta_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Contraseña" cuando lo clickea

            txt_host.BackColor = SystemColors.Control;
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

        }


        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


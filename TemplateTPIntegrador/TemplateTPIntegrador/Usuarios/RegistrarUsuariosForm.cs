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

namespace TemplateTPIntegrador
{
    public partial class RegistrarUsuariosForm : Form
    {
        public RegistrarUsuariosForm()
        {
            InitializeComponent();
            comboBoxTipoUsuario.Items.Add("Administrador");
            comboBoxTipoUsuario.Items.Add("Supervisor");
            comboBoxTipoUsuario.Items.Add("Vendedor");

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


            // Crear una instancia de Usuario con los datos del formulario
            UsuarioWS usuarioPrueba = new UsuarioWS
            {
                NombreUsuario = txt_nombreUsuario.Text,
                Contraseña = txt_contraseñaAlta.Text,
                Nombre = txt_nombre.Text,  // Esto es solo un ejemplo;  usar valores reales
                Apellido = txt_apellido.Text // Esto es solo un ejemplo;  usar valores reales
            };


            // Validación del nombre de usuario
            bool esNombreUsuarioValido = validacionesNegocioUtils.ValidarNombreUsuario(usuarioPrueba.NombreUsuario, usuarioPrueba.Nombre, usuarioPrueba.Apellido);
            if (!esNombreUsuarioValido)
            {
                // Muestra mensaje de error si la validación falla
                MessageBox.Show("El Nombre De Usuario debe tener entre 8 y 15 caracteres y no debe contener el nombre o apellido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de largo de contraseña y que obtenga como mínimo una letra mayúscula y un número
            bool esContraseñaValido = validacionesNegocioUtils.ValidarContraseña(usuarioPrueba.Contraseña);
            if( !esContraseñaValido)
            {
                // Muestra mensaje de error si la validación falla
                MessageBox.Show("La constraseña debe tener entre 8 y 15 caracteres y debe de contener como mínimo una letra mayúscula y un número",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }











            // Si todas las validaciones pasan, inicio de sesión exitoso
            MessageBox.Show("Usuario Creado con éxito!");
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Nombre" cuando lo clickea

            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = Color.White;
            panelNombre.BackColor = Color.White;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_apellido_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Apellido" cuando lo clickea

            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_numeroRegistro_TextChanged(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.BackColor = SystemColors.Control;
            panelTipoUsuario.BackColor = SystemColors.Control;
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelNumeroRegistro.BackColor = Color.White;
            txt_numeroRegistro.BackColor = Color.White;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = Color.White;
            txt_dni.BackColor = Color.White;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = Color.White;
            txt_direccion.BackColor = Color.White;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = Color.White;
            txt_nombreUsuario.BackColor = Color.White;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
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
            panelNumeroRegistro.BackColor = SystemColors.Control;
            txt_numeroRegistro.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_nombreUsuario.BackColor = SystemColors.Control;
            panelContraseña.BackColor = Color.White;
            txt_contraseñaAlta.BackColor = Color.White;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite al usuario ver la contraseña cuando clickea y mantiene sobre el ícono del campo "Contraseña"
            txt_contraseñaAlta.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            // Esconde al usuario la contraseña cuando suelta el click del campo "Contraseña"
            txt_contraseñaAlta.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txt_contraseñaAlta.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txt_contraseñaAlta.UseSystemPasswordChar = true;
        }


       
    }
}


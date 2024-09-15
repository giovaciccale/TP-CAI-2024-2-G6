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
    public partial class AltaUsuariosForm : Form
    {
        public AltaUsuariosForm()
        {
            InitializeComponent();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se instancia el formulario de Login
            LoginForm login = new LoginForm();

            // Se esconde el formulario padre (LogIn)
            this.Hide();

            // Se mantiene escondido el fomrulario padre mientras el formulario hijo (login) este abierto.
            // De cerrarse, se muestra de vuelta el formulario padre.
            login.FormClosed += (s, args) => this.Show();

            // Se muestra el formulario hijo (alta de usuarios)
            login.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();
            // Crear una instancia de Usuario con los datos del formulario
            Usuario usuarioPrueba = new Usuario
            {
                UsuarioNombre = txt_usuarioAlta.Text,
                Contraseña = txt_contraseñaAlta.Text,
                Nombre = txt_nombre.Text,  // Esto es solo un ejemplo;  usar valores reales
                Apellido = txt_apellido.Text // Esto es solo un ejemplo;  usar valores reales
            };
            // Validación del nombre de usuario
            bool esNombreUsuarioValido = validacionesNegocioUtils.ValidarNombreUsuario(usuarioPrueba.UsuarioNombre, usuarioPrueba.Nombre, usuarioPrueba.Apellido);

            if (!esNombreUsuarioValido)
            {
                // Muestra mensaje de error si la validación falla
                MessageBox.Show("El Nombre De Usuario debe tener entre 8 y 15 caracteres y no debe contener el nombre o apellido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, inicio de sesión exitoso
            MessageBox.Show("Usuario Creado con éxito!");
        }
    
        private void txt_nombre_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Nombre" cuando lo clickea

            txt_nombre.BackColor = Color.White;
            panelNombre.BackColor = Color.White;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuarioAlta.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
            panelConfirmarContraseña.BackColor = SystemColors.Control;
            txt_confirmarContraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_apellido_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Apellido" cuando lo clickea

            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuarioAlta.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
            panelConfirmarContraseña.BackColor = SystemColors.Control;
            txt_confirmarContraseñaAlta.BackColor = SystemColors.Control;

        }

        private void txt_usuarioAlta_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Nombre de Usuario" cuando lo clickea

            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = Color.White;
            txt_usuarioAlta.BackColor = Color.White;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
            panelConfirmarContraseña.BackColor = SystemColors.Control;
            txt_confirmarContraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_contraseñaAlta_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Contraseña" cuando lo clickea

            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuarioAlta.BackColor = SystemColors.Control;
            panelContraseña.BackColor = Color.White;
            txt_contraseñaAlta.BackColor = Color.White;
            panelConfirmarContraseña.BackColor = SystemColors.Control;
            txt_confirmarContraseñaAlta.BackColor = SystemColors.Control;
        }

        private void txt_confirmarContraseñaAlta_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Confirmar Contraseña" cuando lo clickea

            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelNombreUsuario.BackColor = SystemColors.Control;
            txt_usuarioAlta.BackColor = SystemColors.Control;
            panelContraseña.BackColor = SystemColors.Control;
            txt_contraseñaAlta.BackColor = SystemColors.Control;
            panelConfirmarContraseña.BackColor = Color.White;
            txt_confirmarContraseñaAlta.BackColor = Color.White;
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

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite al usuario ver la contraseña cuando clickea y mantiene sobre el ícono del campo "Confirmar Contraseña"
            txt_confirmarContraseñaAlta.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            // Esconde al usuario la contraseña cuando suelta el click del campo "Confirmar Contraseña"
            txt_confirmarContraseñaAlta.UseSystemPasswordChar = true;
        }
    }
}


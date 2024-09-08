using Negocio;
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
using TemplateTPIntegrador.utils;

namespace TemplateTPIntegrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            ValidacionesTemplateUtils validacionesTemplateUtils = new ValidacionesTemplateUtils();

            // Llama al método ValidarVacios para chequear los inputs
            string mensaje_validacion_vacios = validacionesTemplateUtils.ValidarVacios(txt_usuario.Text, txt_contraseña.Text);

            if (mensaje_validacion_vacios != null)
            {
                // Muestra mensaje de error para el primer campo vacío
                MessageBox.Show(mensaje_validacion_vacios, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Pone el cursor en el primer campo vacío
                if (mensaje_validacion_vacios.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (mensaje_validacion_vacios.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
            }

            //// Toda esta validacion de cantidad de caracteres en realidad iría en las altas de usuarios ////

            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

            // Llama al metodo ValidarCaracteres para chequear que los campos contengan la cantidad de caracteres requeridos
            string mensaje_validacion_caracteres = validacionesNegocioUtils.ValidarCaracteres(txt_usuario.Text, txt_contraseña.Text);

            if (mensaje_validacion_caracteres != null)
            {
                // Muestra mensaje de error para el primer campo incorrecto
                MessageBox.Show(mensaje_validacion_caracteres, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Pone el cursor en el primer campo incorrecto
                if (mensaje_validacion_caracteres.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (mensaje_validacion_caracteres.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
            }
            else
            {
                // Inicio de sesión si pasa las validaciones
                MessageBox.Show("Inicio de Sesión exitoso!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se instancia el formulario de alta de usuarios
            AltaUsuariosForm alta_usuarios = new AltaUsuariosForm();

            // Se esconde el formulario padre (LogIn)
            this.Hide();

            // Se mantiene escondido el fomrulario padre mientras el formulario hijo (alat de usuarios) este abierto.
            // De cerrarse, se muestra de vuelta el formulario padre.
            alta_usuarios.FormClosed += (s, args) => this.Show();

            // Se muestra el formulario hijo (alta de usuarios)
            alta_usuarios.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            Application.Exit();
        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "usuario" cuando lo clickea
            txt_usuario.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_contraseña.BackColor = SystemColors.Control;
        }

        private void txt_contraseña_Click(object sender, EventArgs e)
        {
            // Indica al usuario que esta parado en el campo "Contraseña" cuando lo clickea
            txt_contraseña.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite al usuario ver la contraseña cuando clickea y mantiene sobre el ícono del campo "Contraseña"
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            // Esconde al usuario la contraseña cuando suelta el click
            txt_contraseña.UseSystemPasswordChar = true;
        }
    }
}
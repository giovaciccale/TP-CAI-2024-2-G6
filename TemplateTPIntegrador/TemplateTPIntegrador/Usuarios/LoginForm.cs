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

       
            // Validación de campos vacíos
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
                return;
            }
            // Supongamos que las validaciones de usuario y contraseña fueron correctas
            // Aquí puedes agregar lógica adicional para verificar la autenticidad del usuario, etc.

            // Abre el formulario de menú
            MenuForm menuForm = new MenuForm();
            menuForm.Show();

            // Oculta el formulario actual (Inicio de Sesión)
            this.Hide(); // O puedes usar this.Close() para cerrarlo en lugar de ocultarlo.
        }
    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se instancia el formulario de alta de usuarios
            //RegistrarUsuariosForm alta_usuarios = new RegistrarUsuariosForm();
            MenuForm menu = new MenuForm();

            // Se esconde el formulario padre (LogIn)
            this.Hide();

            // Se mantiene escondido el formulario padre mientras el formulario hijo (alta de usuarios) esté abierto.
            menu.FormClosed += (s, args) => this.Show();

            // Se muestra el formulario hijo (alta de usuarios)
            menu.Show();
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
            // Indica al usuario que está parado en el campo "Contraseña" cuando lo clickea
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
            // Esconde la contraseña cuando el usuario suelta el click
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

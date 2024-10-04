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
using Negocio;

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
            LoginNegocio login_negocio = new LoginNegocio();

            // Validación de campos vacíos
            string mensaje_validacion_vacios = validacionesTemplateUtils.ValidarVacios(txt_usuario.Text, txt_contraseña.Text);

            if (mensaje_validacion_vacios != null)
            {
                MessageBox.Show(mensaje_validacion_vacios, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

           login_negocio.Login(txt_usuario.Text, txt_contraseña.Text);

                // consideramos que el login fue exitoso
                MenuForm menu = new MenuForm();

                // Oculta el formulario padre (LogIn)
                this.Hide();

                // Muestra el formulario de menú
                menu.FormClosed += (s, args) => this.Show();
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

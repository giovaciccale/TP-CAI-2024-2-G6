using Negocio.utils;
using System;
using System.Windows.Forms;
using Negocio;
using System.Drawing;
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

            try
            {
                // Intentar iniciar sesión
                bool loginExitoso = login_negocio.Login(txt_usuario.Text, txt_contraseña.Text);

                if (loginExitoso)
                {
                    // Si el login fue exitoso, muestra el menú
                    MenuForm menu = new MenuForm();
                    this.Hide();
                    menu.FormClosed += (s, args) => this.Show();
                    menu.Show();
                }
                else
                {
                    // Si el login falló, muestra un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contraseña.Clear();
                    txt_usuario.Focus();
                }
            }
            catch (UsuarioBloqueadoException ex)
            {
                // Capturar la excepción de usuario bloqueado y mostrar el mensaje
                MessageBox.Show(ex.Message, "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones genéricas
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_contraseña.BackColor = SystemColors.Control;
        }

        private void txt_contraseña_Click(object sender, EventArgs e)
        {
            txt_contraseña.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;

        }
    }
}

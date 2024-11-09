using Negocio.utils;
using System;
using System.Windows.Forms;
using Negocio;
using System.Drawing;
using TemplateTPIntegrador.utils;
using TemplateTPIntegrador.Modulos.Usuarios;
using Persistencia;

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
                bool loginExitoso = login_negocio.Login(txt_usuario.Text, txt_contraseña.Text, out bool requiereCambioContraseña, 
                    out string idUsuario, out string nombreUsuario, out string contraseñaActual, out DateTime fechaAlta , out int host);

                if (requiereCambioContraseña)
                {
                    // Si se requiere cambiar la contraseña, abrir el formulario CambiarContraseña
                    CambiarContraseña cambiarContraseñaForm = new CambiarContraseña(idUsuario, nombreUsuario, contraseñaActual, fechaAlta);
                    this.Hide();
                    cambiarContraseñaForm.FormClosed += (s, args) => this.Show();
                    cambiarContraseñaForm.ShowDialog(); // Mostrar el formulario de manera modal
                }
                else if (loginExitoso)
                {
                    if (host == 3)
                    {
                        // Si el login fue exitoso y el host es 3, muestra el menú principal
                        MenuForm menu = new MenuForm();
                        this.Hide();
                        menu.FormClosed += (s, args) => this.Show();
                        menu.Show();
                    }
                    else if (host == 2)
                    {
                        // Si el login fue exitoso y el host es 2, muestra el menú para supervisores
                        MenuSupervisor menuSupervisor = new MenuSupervisor();
                        this.Hide();
                        menuSupervisor.FormClosed += (s, args) => this.Show();
                        menuSupervisor.Show();
                    }
                    else if (host == 1)
                    {
                        // Si el login fue exitoso y el host es 1, muestra el menú para vendedores
                        MenuVendedor menuVendedor = new MenuVendedor();
                        this.Hide();
                        menuVendedor.FormClosed += (s, args) => this.Show();
                        menuVendedor.Show();
                    }
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

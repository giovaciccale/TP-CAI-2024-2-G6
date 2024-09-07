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

            // Llama al método ValidarInicioSesion para chequear los inputs
            string MensajeValidación = validacionesTemplateUtils.ValidarInicioSesion(txt_usuario.Text, txt_contraseña.Text);

            if (MensajeValidación != null)
            {
                // Muestra mensaje de error para el primer campo vacío
                MessageBox.Show(MensajeValidación, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Pone el cursor en el primer campo vacío
                if (MensajeValidación.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (MensajeValidación.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
            }
            else
            {
                // Inicio de sesión si pasa las validaciones
                MessageBox.Show("Inicio de Sesión exitoso!");
            }

            //ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

            //LoginNegocio ln = new LoginNegocio();
            //ln.Login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
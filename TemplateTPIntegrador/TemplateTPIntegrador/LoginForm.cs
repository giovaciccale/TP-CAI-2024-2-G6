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

            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;

            validacionesTemplateUtils.ValidarStringVacio(usuario);
            validacionesTemplateUtils.ValidarStringVacio(contraseña);

            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

            //LoginNegocio ln = new LoginNegocio();
            //ln.Login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
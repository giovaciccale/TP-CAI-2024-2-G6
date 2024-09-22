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
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btn_registrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {

        }
        private void registrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarUsuariosForm registrar_usuarios_form = new RegistrarUsuariosForm();

            registrar_usuarios_form.Show();

            this.Hide();
        }
    }
}

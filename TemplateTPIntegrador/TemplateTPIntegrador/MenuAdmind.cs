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
    public partial class MenuAdmind : Form
    {
        public MenuAdmind()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

 

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Usuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Evento de clic disparado"); // Para verificar si el clic funciona

            // Crea una instancia del formulario RegistrarUsuariosForm
            MenuUsuario usuariosMenuForm = new MenuUsuario();

            // Muestra el formulario de registro
            usuariosMenuForm.Show();

            // Oculta el formulario actual (MenuUsuario)
            this.Hide();
        }
    }
}

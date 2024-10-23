using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TemplateTPIntegrador
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrirFormInPanel(object formhijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btn_frm_usuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new RegistrarUsuariosForm());
        }
    }
}

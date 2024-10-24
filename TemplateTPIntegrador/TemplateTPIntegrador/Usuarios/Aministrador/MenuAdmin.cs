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
using TemplateTPIntegrador.Usuarios.Aministrador;

namespace TemplateTPIntegrador
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MenuForm_Shown);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MenuForm_Load(object sender, EventArgs e)
        {
            btnSeccionUsuarios.Checked = true;
            tabRegistrarUsuarios.Checked = true;
        }

        private void MenuForm_Shown(object sender, EventArgs e)
        {
            abrirFormInPanel(new RegistrarUsuariosForm());
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


        // Este Metodo hace que se abra el forms dentro del panel contenedor
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


        private void btnSeccionUsuarios_Click(object sender, EventArgs e)
        {
            tabRegistrarUsuarios.Visible = true;
            tabModificarUsuarios.Visible = true;
            tabEliminarUsuarios.Visible = true;
            tabRegistrarUsuarios.Checked = true;
            abrirFormInPanel(new RegistrarUsuariosForm());
        }


        private void tabRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new RegistrarUsuariosForm());
        }


        private void tabEliminarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new BajaUsuarios());
        }

        private void tabModificarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new ModificarUsuariosForm());
        }
    }
}

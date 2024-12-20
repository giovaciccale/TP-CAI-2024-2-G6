﻿using System;
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
using TemplateTPIntegrador.Modulos.Proveedores;
using TemplateTPIntegrador.Modulos.Reportes;

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

        // Variables para mantener el estado de la sección actual
        private bool enSeccionUsuarios = true;
        private bool enSeccionProductos = false;
        private bool enSeccionProveedores = false;

        private void MenuForm_Load(object sender, EventArgs e)
        {
            MostrarSeccionUsuarios();
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
        private void abrirFormInPanel(object formHijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnSeccionUsuarios_Click(object sender, EventArgs e)
        {
            if (!enSeccionUsuarios)
            {
                MostrarSeccionUsuarios();
                enSeccionUsuarios = true;
                enSeccionProductos = false;
                enSeccionProveedores = false;
            }
        }

        private void btnSeccionProveedores_Click(object sender, EventArgs e)
        {
            if (!enSeccionProveedores)
            {
                MostrarSeccionProveedores();
                enSeccionUsuarios = false;
                enSeccionProductos = false;
                enSeccionProveedores = true;
            }
        }
        private void btnSeccionProductos_Click(object sender, EventArgs e)
        {
            if (!enSeccionProductos)
            {
                MostrarSeccionProductos();
                enSeccionProductos = true;
                enSeccionUsuarios = false;
                enSeccionProveedores = false;
            }
        }

        private void MostrarSeccionUsuarios()
        {
            // Ocultar tabs 
            tabAltaProductos.Visible = false;
            tabRegistrarProveedores.Visible = false;
            tabEliminarProveedores.Visible = false;




            // Mostrar tabs de Usuarios
            tabRegistrarUsuarios.Visible = true;
            tabEliminarUsuario.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabRegistrarUsuarios.Checked = true;
            abrirFormInPanel(new RegistrarUsuariosForm());
        }

        private void MostrarSeccionProductos()
        {
            // Ocultar tabs de Usuarios
            tabRegistrarUsuarios.Visible = false;
            tabEliminarUsuario.Visible = false;
            tabRegistrarProveedores.Visible = false;
            tabEliminarProveedores.Visible = false;

            // Mostrar tabs de Productos
            tabAltaProductos.Visible = true;



            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabAltaProductos.Checked = true;
            abrirFormInPanel(new AltaProductosForm());
        }
        private void MostrarSeccionProveedores()
        {
            // Ocultar tabs de Usuarios
            tabRegistrarUsuarios.Visible = false;
            tabEliminarUsuario.Visible = false;
            tabAltaProductos.Visible = false;
            // Mostrar tabs de Proveedores tabEliminarProveedores

            tabRegistrarProveedores.Visible = true;
            tabEliminarProveedores.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabRegistrarProveedores.Checked = true;
            abrirFormInPanel(new RegistrarProveedoresForm());
        }

        private void tabRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new RegistrarUsuariosForm());
        }


        private void tabEliminarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new BajaUsuarios());
        }
        private void tabEliminarProveedores_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new BajaProveedores());
        }

        private void tabAltaProductos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new AltaProductosForm());
        }



        private void tabRegistrarProveedores_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new RegistrarProveedoresForm());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            {
                // Mostrar mensaje de confirmación
                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que quiere cerrar sesión?",
                    "Confirmar cierre de sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario selecciona "No", no se hace nada
                if (resultado == DialogResult.No)
                {
                    return;
                }

                // Cerrar todos los formularios abiertos excepto el principal
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form.Name != "LoginForm") // Reemplaza "LoginForm" con el nombre de tu formulario de Login
                    {
                        form.Close();
                    }
                }

                // Abrir el formulario de Login
                LoginForm loginForm = new LoginForm(); // Asegúrate de que este sea el nombre correcto de tu formulario de Login
                loginForm.Show();

                // Cerrar el formulario actual (MenuVendedor)
                this.Close();
            }
        }

        private void btnSeccionReportes_Click(object sender, EventArgs e)
        {
            // Ocultar tabs de Usuarios
            tabRegistrarUsuarios.Visible = false;
            tabEliminarUsuario.Visible = false;
            tabRegistrarProveedores.Visible = false;
            tabEliminarProveedores.Visible = false;
            abrirFormInPanel(new ReportesPorVendedorForm());

        }
    }
}

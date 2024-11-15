using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Usuarios.Aministrador;

namespace TemplateTPIntegrador
{
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MenuForm_Shown);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Variables para mantener el estado de la sección actual
        private bool enSeccionProductos = true;
        private bool enSeccionDevoluciones = false;
        private bool enSeccionReportes = false;

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            MostrarSeccionProductos();
        }


        private void MenuForm_Shown(object sender, EventArgs e)
        {
            abrirFormInPanel(new AltaProductosForm());
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


        private void btnSeccionProductos_Click(object sender, EventArgs e)
        {
            if (!enSeccionProductos)
            {
                MostrarSeccionProductos();
                enSeccionProductos = true;
                enSeccionDevoluciones = false;
                enSeccionReportes = false;
            }
        }


        private void btnSeccionDevoluciones_Click(object sender, EventArgs e)
        {
            if (!enSeccionDevoluciones)
            {
                MostrarSeccionDevoluciones();
                enSeccionDevoluciones = true;
                enSeccionProductos = false;
                enSeccionReportes = false;
            }
        }


        private void btnSeccionReportes_Click(object sender, EventArgs e)
        {
            if (!enSeccionReportes)
            {
                MostrarSeccionReportes();
                enSeccionReportes=true;
                enSeccionProductos=false;
                enSeccionDevoluciones=false;
            }
        }


        private void MostrarSeccionProductos()
        {
            // Esconder tabs de Reportes
            tabStockCritico.Visible = false;
            tabReporteVentasxVendedor.Visible = false;
            tabProductosMasVendidos.Visible = false;

            // Esconder tabs de Devoluciones
            tabDevoluciones.Visible = false;

            // Mostrar tabs de Productos
            tabAltaProductos.Visible = true;
            tabModificarProductos.Visible = true;
            tabBajaProductos.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabAltaProductos.Checked = true;
            abrirFormInPanel(new AltaProductosForm());
        }


        private void MostrarSeccionDevoluciones()
        {
            // Esconder tabs de Productos
            tabAltaProductos.Visible = false;
            tabModificarProductos.Visible = false;
            tabBajaProductos.Visible = false;

            // Esconder tabs de Reportes
            tabStockCritico.Visible = false;
            tabReporteVentasxVendedor.Visible = false;
            tabProductosMasVendidos.Visible = false;

            // Mostrar tabs de Devoluciones
            tabDevoluciones.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabDevoluciones.Checked = true;
            abrirFormInPanel(new AltaProductosForm());
        }


        private void MostrarSeccionReportes()
        {
            // Esconder tabs de Productos
            tabAltaProductos.Visible = false;
            tabModificarProductos.Visible = false;
            tabBajaProductos.Visible = false;

            // Esconder tabs de Devoluciones
            tabDevoluciones.Visible = false;

            // Mostrar tabs de Reportes
            tabStockCritico.Visible = true;
            tabReporteVentasxVendedor.Visible = true;
            tabProductosMasVendidos.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabStockCritico.Checked = true;
            abrirFormInPanel(new AltaProductosForm());
        }


        private void abrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void tabAltaProductos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new AltaProductosForm());
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}

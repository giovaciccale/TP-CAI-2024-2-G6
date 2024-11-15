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
using TemplateTPIntegrador.Modulos.Clientes;
using TemplateTPIntegrador.Modulos.Ventas;
using TemplateTPIntegrador.Modulos.Reportes;


namespace TemplateTPIntegrador
{
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MenuForm_Shown);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Variables para mantener el estado de la sección actual
        private bool enSeccionClientes = true;
        private bool enSeccionVentas = false;
        private bool enSeccionReportes = false;

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            MostrarSeccionClientes();
        }


        private void MenuForm_Shown(object sender, EventArgs e)
        {
            abrirFormInPanel(new BuscarClientesForm());
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


        private void btnSeccionClientes_Click(object sender, EventArgs e)
        {
            if (!enSeccionClientes)
            {
                MostrarSeccionClientes();
                enSeccionClientes = true;
                enSeccionVentas = false;
                enSeccionReportes = false;
            }
        }


        private void btnSeccionVentas_Click(object sender, EventArgs e)
        {
            if (!enSeccionVentas)
            {
                MostrarSeccionVentas();
                enSeccionVentas = true;
                enSeccionClientes = false;
                enSeccionReportes = false;
            }
        }


        private void btnSeccionReportes_Click(object sender, EventArgs e)
        {
            if (!enSeccionReportes)
            {
                MostrarSeccionReportes();
                enSeccionReportes = true;
                enSeccionClientes = false;
                enSeccionVentas = false;
            }
        }


        private void MostrarSeccionClientes()
        {
            // Esconder tabs de Reportes
            tabVentasPorVendedor.Visible = false;

            // Esconder tabs de Ventas
            tabVentas.Visible = false;

            // Mostrar tabs de Clientes
            tabBuscarCliente.Visible = true;
            tabAgregarCliente.Visible = true;
            tabModificarCliente.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabBuscarCliente.Checked = true;
            abrirFormInPanel(new BuscarClientesForm());
        }


        private void MostrarSeccionVentas()
        {
            // Esconder tabs de Clientes
            tabBuscarCliente.Visible = false;
            tabAgregarCliente.Visible = false;
            tabModificarCliente.Visible = false;

            // Esconder tabs de Reportes
            tabVentasPorVendedor.Visible = false;

            // Mostrar tabs de Ventas
            tabVentas.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabVentas.Checked = true;
            abrirFormInPanel(new VentasForm());
        }


        private void MostrarSeccionReportes()
        {
            // Esconder tabs de Clientes
            tabBuscarCliente.Visible = false;
            tabAgregarCliente.Visible = false;
            tabModificarCliente.Visible = false;


            // Esconder tabs de Ventas
            tabVentas.Visible = false;

            // Mostrar tabs de Reportes
            tabVentasPorVendedor.Visible = true;

            // Seleccionar tab por defecto y cargar el formulario correspondiente
            tabVentasPorVendedor.Checked = true;
            abrirFormInPanel(new ReporteStockForm());
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

        private void tabAltaClientes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new AltaClientesForm());
        }
        private void tabBuscarCliente_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new BuscarClientesForm());
        }
        private void tabModificarCliente_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new ModificarClientesForm());
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

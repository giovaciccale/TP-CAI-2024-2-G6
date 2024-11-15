using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Newtonsoft.Json;
using Persistencia;
namespace TemplateTPIntegrador.Modulos.Reportes
{
    public partial class ReportesPorVendedorForm : Form
    {
        private UsuariosWS usuariosWS; // Instancia de UsuariosWS
        
        public ReportesPorVendedorForm()
        {
            InitializeComponent();
            usuariosWS = new UsuariosWS(); // Inicializar la instancia
            CargarUsuarios(); // Cargar los usuarios al inicializar el formulario
        }

        private void CargarUsuarios()
        {
            var usuariosActivos = usuariosWS.buscarDatosUsuario();

            if (usuariosActivos != null)
            {
                // Limpia el ComboBox antes de llenarlo
                comboBoxVendedores.Items.Clear();

                // Llenar el ComboBox con los nombres de usuario y sus IDs si el host es igual a 1 (vendedor)
                foreach (var usuario in usuariosActivos)
                {
                    if (usuario.host == 1) // Verifica si el usuario es un vendedor
                    {
                        comboBoxVendedores.Items.Add(new { Dni = usuario.dni, Id = usuario.Id });
                    }
                }

                // Establecer el formato para mostrar el nombre en el ComboBox
                comboBoxVendedores.DisplayMember = "Dni"; // Campo que se mostrará
                comboBoxVendedores.ValueMember = "Id"; // Campo que se utilizará como valor
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

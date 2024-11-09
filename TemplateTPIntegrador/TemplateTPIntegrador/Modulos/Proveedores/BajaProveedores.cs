using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Proveedores
{
    public partial class BajaProveedores : Form
    {
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";
        private ProveedoresWS proveedoresWS; // Instancia de Proveedores
        public BajaProveedores()
        {
            InitializeComponent();
            proveedoresWS = new ProveedoresWS(); // Inicializar la instancia
            /*CargarUsuarios();*/ // Cargar los usuarios al inicializar el formulario
        }

        private void CargarProveedores()
        {
            var proveedoresActivos = proveedoresWS.buscarDatosProveedor();

            if (proveedoresActivos != null)
            {
                // Limpia el ComboBox antes de llenarlo
                cmb_proveedores.Items.Clear();

                // Llenar el ComboBox con los nombres de usuario y sus IDs
                foreach (var proveedor in proveedoresActivos)
                {
                    // Agrega un nuevo objeto con el nombre y el ID del usuario
                    cmb_proveedores.Items.Add(new { Nombre = proveedor.nombre, Id = proveedor.Id }); // Asegúrate de incluir Id aquí
                }

                // Establecer el formato para mostrar el nombre en el ComboBox
                cmb_proveedores.DisplayMember = "Nombre"; // Campo que se mostrará
                cmb_proveedores.ValueMember = "Id"; // Campo que se utilizará como valor
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los proveedores activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_desactivarProveedor_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un usuario
            if (cmb_proveedores.SelectedItem != null)
            {
                // Obtener el ID del usuario seleccionado
                Guid idUsuario = ((dynamic)cmb_proveedores.SelectedItem).Id; // Obtener el ID del usuario

                // Llamar al método para dar de baja al usuario
                bool resultado = proveedoresWS.DarDeBajaProveedor(idUsuario.ToString(), adminId); // Convertir a string solo si es necesario

                // Mostrar mensaje de éxito o error
                if (resultado)
                {
                    MessageBox.Show("Usuario desactivado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_proveedores.SelectedItem = null; // Limpiar la selección del ComboBox
                    CargarProveedores(); // Volver a cargar los usuarios en el ComboBox
                }
                else
                {
                    MessageBox.Show("Error al desactivar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

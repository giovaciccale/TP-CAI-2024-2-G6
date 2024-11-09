using System;
using System.Linq;
using System.Windows.Forms;
using Persistencia;

namespace TemplateTPIntegrador
{
    public partial class BajaUsuarios : Form
    {
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";
        private UsuariosWS usuariosWS; // Instancia de UsuariosWS

        public BajaUsuarios()
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
                cmb_usuarios.Items.Clear();

                // Llenar el ComboBox con los nombres de usuario y sus IDs
                foreach (var usuario in usuariosActivos)
                {
                    // Agrega un nuevo objeto con el nombre y el ID del usuario
                    cmb_usuarios.Items.Add(new { Nombre = usuario.nombreUsuario, Id = usuario.Id }); // Asegúrate de incluir Id aquí
                }

                // Establecer el formato para mostrar el nombre en el ComboBox
                cmb_usuarios.DisplayMember = "Nombre"; // Campo que se mostrará
                cmb_usuarios.ValueMember = "Id"; // Campo que se utilizará como valor
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_desactivarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un usuario
            if (cmb_usuarios.SelectedItem != null)
            {
                // Obtener el ID del usuario seleccionado
                Guid idUsuario = ((dynamic)cmb_usuarios.SelectedItem).Id; // Obtener el ID del usuario

                // Llamar al método para dar de baja al usuario
                bool resultado = usuariosWS.DarDeBajaUsuario(idUsuario.ToString(), adminId); // Convertir a string solo si es necesario

                // Mostrar mensaje de éxito o error
                if (resultado)
                {
                    MessageBox.Show("Usuario desactivado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_usuarios.SelectedItem = null; // Limpiar la selección del ComboBox
                    CargarUsuarios(); // Volver a cargar los usuarios en el ComboBox
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

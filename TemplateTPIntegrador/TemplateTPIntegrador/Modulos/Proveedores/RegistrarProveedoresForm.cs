using Datos;
using Negocio.utils;
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
    public partial class RegistrarProveedoresForm : Form
    {
        public string adminId = "990a1069-0e96-4b2b-8f8e-bc3d49d0cc30";

        public RegistrarProveedoresForm()
        {
            InitializeComponent();
        }

        private void btn_crearProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

                // Crear una instancia de ProveedoreWS con los datos del formulario
                ProveedoreWS proveedor = new ProveedoreWS
                {
                    idUsuario = adminId,
                    nombre = txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    email = txt_email.Text,
                    cuit = txt_cuit.Text,
                };

                // Instancia de ProveedoresWS para gestionar la creación
                ProveedoresWS proveedoresWS = new ProveedoresWS();

                // Intentar agregar el proveedor
                bool resultado = proveedoresWS.AgregarProveedor(proveedor);

                if (resultado)
                {
                    MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Llama al método para limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al agregar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_email.Clear();
            txt_cuit.Clear();
        }
    }
}

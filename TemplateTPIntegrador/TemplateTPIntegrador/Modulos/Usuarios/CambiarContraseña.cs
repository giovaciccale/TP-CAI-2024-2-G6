using System;
using System.Windows.Forms;
using Negocio.utils;
using Persistencia; // Agrega esto para usar UsuariosWS

namespace TemplateTPIntegrador.Modulos.Usuarios
{
    public partial class CambiarContraseña : Form
    {
        private string idUsuario;
        private string nombreUsuario;
        private string contraseñaActual;
        private DateTime fechaAlta;

        ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

        // Constructor para recibir los parámetros necesarios
        public CambiarContraseña(string idUsuario, string nombreUsuario, string contraseñaActual, DateTime fechaAlta)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contraseñaActual = contraseñaActual;
            this.fechaAlta = fechaAlta;
        }

        private void btn_ActualizarPass_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = txt_contraseña.Text; // Obtener la nueva contraseña del campo de texto

            if (string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Por favor, ingrese una nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la contraseña con el método ValidarContraseña
            if (!validacionesNegocioUtils.ValidarContraseña(nuevaContraseña))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres, incluir al menos una letra mayúscula y un número.",
                                "Validación de Contraseña",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Salir del método si la validación falla
            }

            // Verificar que la nueva contraseña no sea igual a la anterior
            if (nuevaContraseña == contraseñaActual)
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de UsuariosWS para cambiar la contraseña
            UsuariosWS usuariosWS = new UsuariosWS();

            // Cambiar la contraseña del usuario en el sistema
            bool contraseñaCambiada = usuariosWS.CambiarContraseña(nombreUsuario, contraseñaActual, nuevaContraseña, fechaAlta);
            if (contraseñaCambiada)
            {
                MessageBox.Show("Contraseña actualizada exitosamente. Vuelve a Iniciar Sesión", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconoCandado_MouseHover(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void IconoCandado_MouseLeave(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;

        }
    }
}

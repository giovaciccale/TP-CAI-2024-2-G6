using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Negocio.utils
{
    public class ValidacionesNegocioUtils
    {
        // Método que valida que el NombreUsuario tenga entre 8 y 15 caracteres
        public bool ValidarNombreUsuario(string UsuarioNombre, string Nombre, string Apellido)
        {
            // La longitud del nombre de usuario debe ser al menos 8 y como máximo 15 caracteres
            if (UsuarioNombre.Length < 8 || UsuarioNombre.Length > 15)
                return false;

            // El nombre de usuario no debe contener el nombre ni el apellido (ignorando mayúsculas)
            if (UsuarioNombre.ToLower().Contains(Nombre.ToLower()) || UsuarioNombre.ToLower().Contains(Apellido.ToLower()))
                return false;

            // Si pasa todas las validaciones, retorna true
            return true;
        }


        // Método que Valida largo de contraseña y que obtenga como mínimo una letra mayúscula y un número
        public bool ValidarContraseña(string nuevaContraseña)
        {
            if (nuevaContraseña.Length < 8 || nuevaContraseña.Length > 15)
                return false;

            bool tieneMayuscula = nuevaContraseña.Any(char.IsUpper);
            bool tieneNumero = nuevaContraseña.Any(char.IsDigit);

            if (!tieneMayuscula || !tieneNumero)
                return false;

            return true;
        }


        // Cambiar contraseña (no debe ser igual a la anterior)
        public bool CambiarContraseña(string nuevaContraseña, string Contraseña, DateTime FechaUltimaContraseña)
        {
            if (nuevaContraseña == Contraseña)
                return false;

            if (!ValidarContraseña(nuevaContraseña))
                return false;

            Contraseña = nuevaContraseña;
            FechaUltimaContraseña = DateTime.Now;
            return true;
        }
        
    }
    public static class ValidadorDeCampos
    {
        public static void ValidarCamposCliente(Dictionary<Control, (string nombreDelCampo, bool esNumerico, bool esFecha)> campos)
        {
            foreach (var campo in campos)
            {
                Control control = campo.Key;
                string nombreDelCampo = campo.Value.nombreDelCampo;
                bool esNumerico = campo.Value.esNumerico;
                bool esFecha = campo.Value.esFecha;

                if (control is TextBox textbox)
                {
                    if (string.IsNullOrEmpty(textbox.Text))
                    {
                        MessageBox.Show($"El campo '{nombreDelCampo}' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textbox.Focus();
                        return;
                    }

                    if (esNumerico)
                    {
                        if (!int.TryParse(textbox.Text, out int parsedValue))
                        {
                            MessageBox.Show($"El campo '{nombreDelCampo}' debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textbox.Focus();
                            return;
                        }

                        if (textbox.Text.Length != 8)
                        {
                            MessageBox.Show($"El campo '{nombreDelCampo}' debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textbox.Focus();
                            return;
                        }
                    }
                }
                    

                else if (control is DateTimePicker datePicker && esFecha)
                {
                    DateTime fechaSeleccionada = datePicker.Value;
                    DateTime fechaMinima = new DateTime(1924, 1, 1);
                    DateTime fechaMaxima = new DateTime(2006, 9, 11);

                    if (fechaSeleccionada < fechaMinima || fechaSeleccionada > fechaMaxima)
                    {
                        MessageBox.Show($"El campo '{nombreDelCampo}' debe ser una fecha entre {fechaMinima.ToShortDateString()} y {fechaMaxima.ToShortDateString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        datePicker.Focus();
                        return;
                    }
                }
            }

        }

    }
}




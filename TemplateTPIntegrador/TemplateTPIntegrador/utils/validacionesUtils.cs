using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.utils
{
    public class ValidacionesTemplateUtils
    {
        // Método que valida si el usuario está dejando vacío algún campo
        public bool ValidarInputVacio(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        // Método que valida si el Nombre de Usauario o Contraseña son vacíos. Devuelve un mensaje para el primer campo vacío.
        public string ValidarInicioSesion(string usuario, string contraseña)
        {
            if (ValidarInputVacio(usuario))
            {
                return "El campo \"Nombre De Usuario\" no puede estar vacío.";
            }
            else if (ValidarInputVacio(contraseña))
            {
                return "El campo \"Contraseña\" no puede estar vacío.";
            }

            // Si ambos campos son válidos, retorna null
            return null;
        }
    }
}

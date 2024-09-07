using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.utils
{
    public class ValidacionesNegocioUtils
    {
        // Metodo que valida que el input tenga entre 8 y 15 caracteres
        public bool ValidarUsuario(string input)
        {
            return (input.Length < 8 || input.Length > 15);
        }

        // Metodo que valida que el input tenga al menos 8 caracteres
        public bool ValidarContraseña(string ipnut)
        {
            return (ipnut.Length < 8);
        }

        // Metodo que valida que ambos campos contengan la cantidad de caracteres requeridas.
        // Devuelve un mensaje de error para el primer campo invalido
        public string ValidarCaracteres(string usuario, string contraseña)
        {
            if (ValidarUsuario(usuario))
            {
                return "El Nombre De Usuario debe tener entre 8 y 15 caracteres.";
            }
            else if (ValidarContraseña(contraseña))
            {
                return "La Contraseña debe tener al menos 8 caracteres.";
            }

            // Si ambos campos son válidos, retorna null
            return null;
        }
    }
}

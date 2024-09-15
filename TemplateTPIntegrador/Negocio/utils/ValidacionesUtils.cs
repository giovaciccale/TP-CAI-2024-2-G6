using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}


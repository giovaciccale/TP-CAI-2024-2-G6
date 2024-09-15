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
}


//// Verificar si la contraseña ha expirado (cada 30 días)
//public bool ContraseñaExpirada()
//{
//    if (!FechaUltimaContraseña.HasValue)
//        return false;

//    return (DateTime.Now - FechaUltimaContraseña.Value).TotalDays >= 30;
//}

//// Intento de login fallido
//public void IntentoFallido()
//{
//    IntentosLogin++;
//    if (IntentosLogin >= 3)
//    {
//        Estado = EstadoUsuario.INACTIVO;
//    }
//}

//// Login exitoso, resetear intentos
//public void LoginExitoso()
//{
//    IntentosLogin = 0;
//    if (Estado == EstadoUsuario.INACTIVO)
//    {
//        Estado = EstadoUsuario.ACTIVO;
//    }
//}


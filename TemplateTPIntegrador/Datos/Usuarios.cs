using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }
        public PerfilUsuario Host { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public EstadoUsuario Estado { get; set; }
        public int IntentosLogin { get; set; }
        public DateTime? FechaUltimaContraseña { get; set; } // Para validar expiración

        // Constructor
        public Usuario()
        {
            Id = Guid.NewGuid();
            Estado = EstadoUsuario.INACTIVO;
            IntentosLogin = 0;
            FechaAlta = DateTime.Now;
        }

        // Validar contraseña
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
        public bool CambiarContraseña(string nuevaContraseña)
        {
            if (nuevaContraseña == Contraseña)
                return false;

            if (!ValidarContraseña(nuevaContraseña))
                return false;

            Contraseña = nuevaContraseña;
            FechaUltimaContraseña = DateTime.Now;
            return true;
        }

        // Verificar si la contraseña ha expirado (cada 30 días)
        public bool ContraseñaExpirada()
        {
            if (!FechaUltimaContraseña.HasValue)
                return false;

            return (DateTime.Now - FechaUltimaContraseña.Value).TotalDays >= 30;
        }

        // Intento de login fallido
        public void IntentoFallido()
        {
            IntentosLogin++;
            if (IntentosLogin >= 3)
            {
                Estado = EstadoUsuario.INACTIVO;
            }
        }

        // Login exitoso, resetear intentos
        public void LoginExitoso()
        {
            IntentosLogin = 0;
            if (Estado == EstadoUsuario.INACTIVO)
            {
                Estado = EstadoUsuario.ACTIVO;
            }
        }
    }

    // Enum para perfiles
    public enum PerfilUsuario
    {
        Vendedor = 1,
        Supervisor = 2,
        Administrador = 3
    }

    // Enum para estado del usuario
    public enum EstadoUsuario
    {
        ACTIVO,
        INACTIVO
    }
}
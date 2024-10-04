using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioWS
    {

        // Constructor
        public UsuarioWS()
        {
            Id = Guid.NewGuid();
            Estado = EstadoUsuario.INACTIVO;
            IntentosLogin = 0;
            FechaAlta = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioNombre { get; set; }
        public PerfilUsuario Host { get; set; }
        public string DNI { get; set; }
        public string Contraseña { get; set; }
        public int IntentosLogin { get; set; }
        public DateTime? FechaUltimaContraseña { get; set; } // Para validar expiración
        public EstadoUsuario Estado { get; set; }

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



    

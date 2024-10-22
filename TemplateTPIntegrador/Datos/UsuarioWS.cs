using System;

namespace Datos
{
    public class UsuarioWS
    {
        // Constructor
        public UsuarioWS()
        {
            Id = Guid.NewGuid();
            FechaAlta = DateTime.Now;      
            FechaBaja = null;  // Estado ACTIVO al inicio
        }
        public Guid Id { get; set; }  // Correspondiente a "id" en JSON
        public string Nombre { get; set; }  // Correspondiente a "nombre" en JSON
        public string Apellido { get; set; }  // Correspondiente a "apellido" en JSON
        public int Dni { get; set; }  // Correspondiente a "dni" en JSON
        public string Direccion { get; set; }  // Correspondiente a "direccion" en JSON
        public string Telefono { get; set; }  // Correspondiente a "telefono" en JSON
        public string Email { get; set; }  // Correspondiente a "email" en JSON
        public DateTime FechaNacimiento { get; set; }  // Correspondiente a "fechaNacimiento" en JSON
        public DateTime FechaAlta { get; set; }  // Correspondiente a "fechaAlta" en JSON
        public DateTime? FechaBaja { get; set; }  // Correspondiente a "fechaBaja" en JSON
        public int Host { get; set; }  // Correspondiente a "host" en JSON, como un entero en este caso


        // Propiedades adicionales
        public string NombreUsuario { get; set; }  // Nuevo campo para nombre de usuario
        public string Contraseña { get; set; }  // Nuevo campo para contraseña
    }
}


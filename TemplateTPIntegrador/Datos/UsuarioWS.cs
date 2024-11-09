using System;

namespace Datos
{
    public class UsuarioWS
    {
        // Constructor
        public UsuarioWS()
        {
            Id = Guid.NewGuid();
            fechaAlta = DateTime.Now;
            fechaBaja = null;  // Estado ACTIVO al inicio si no no recibe el ID
         
        }

        public string idUsuario { get; set; }
        public Guid Id { get; set; }  // Correspondiente a "id" en JSON
        public string nombre { get; set; }  // Correspondiente a "nombre" en JSON
        public string apellido { get; set; }  // Correspondiente a "apellido" en JSON
        public int dni { get; set; }  // Correspondiente a "dni" en JSON
        public string direccion { get; set; }  // Correspondiente a "direccion" en JSON
        public string telefono { get; set; }  // Correspondiente a "telefono" en JSON
        public string email { get; set; }  // Correspondiente a "email" en JSON
        public DateTime fechaNacimiento { get; set; }  // Correspondiente a "fechaNacimiento" en JSON
        public DateTime fechaAlta { get; set; }  // Correspondiente a "fechaAlta" en JSON
        public DateTime? fechaBaja { get; set; }  // Correspondiente a "fechaBaja" en JSON
        public int host { get; set; }  // Correspondiente a "host" en JSON, como un entero en este caso


        // Propiedades adicionales
        public string nombreUsuario { get; set; }  // Nuevo campo para nombre de usuario
        public string contraseña { get; set; }  // Propiedad para la contraseña
       
    }
}


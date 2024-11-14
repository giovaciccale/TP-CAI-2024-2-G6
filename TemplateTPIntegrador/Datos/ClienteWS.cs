using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //Constructor
    public class ClienteWS
    {
        public ClienteWS()
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
        public string host { get; set; }  // Correspondiente a "host" en JSON, como un entero en este caso
    }
}

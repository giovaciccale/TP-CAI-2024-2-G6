using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaWS
    {
        public VentaWS()
        {
            Id = Guid.NewGuid();
            fechaAlta = DateTime.Now;

        }

        public string idUsuario { get; set; }
        public Guid Id { get; set; }  // Correspondiente a "id" en JSON
        public int idCliente { get; set; }  // Id del cliente
        public string idProducto { get; set; }  // Id del producto, cambiado a int
        public int Cantidad { get; set; }
        public DateTime fechaAlta { get; set; }  // Correspondiente a "fechaAlta" en JSON
        public int Estado { get; set; }
    }
}

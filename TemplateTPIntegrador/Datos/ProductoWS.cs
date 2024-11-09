using System;

namespace Datos
{
    public class ProductoWS
    {
        // Constructor
        public ProductoWS()
        {
            id = Guid.NewGuid();
            fechaAlta = DateTime.Now;
            fechaBaja = null;  // Estado ACTIVO al inicio si FechaBaja es null
        }

        // Propiedades
        public Guid id { get; set; }  // Id del producto
        public int idCategoria { get; set; }  // Id de la categoría del producto, cambiado a int
        public string nombre { get; set; }  // Nombre del producto
        public DateTime fechaAlta { get; set; }  // Fecha de alta
        public DateTime? fechaBaja { get; set; }  // Fecha de baja, si es null está activo
        public double precio { get; set; }  // Precio del producto
        public int stock { get; set; }  // Stock disponible
        public Guid idUsuario { get; set; }  // Id del usuario que registró el producto
        public Guid idProveedor { get; set; }  // Id del proveedor
    }
}

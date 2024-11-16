using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador.Modulos.Ventas
{
    public class CarritoItem
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; } // Precio unitario del producto
        public double Total { get; set; } // Total = Cantidad * PrecioUnitario
    }

    public class Promocion
    {
        public string Nombre { get; set; }
        public double Monto { get; set; }
    }
}

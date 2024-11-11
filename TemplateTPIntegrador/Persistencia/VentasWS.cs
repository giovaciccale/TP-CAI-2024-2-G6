using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Persistencia
{
    public class VentasWS
    {
        public bool AgregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            // Crea el objeto que será convertido a JSON
            var ventaData = new
            {
                idCliente = idCliente,
                idUsuario = idUsuario,
                idProducto = idProducto,
                cantidad = cantidad
            };

            // Convierte el objeto a JSON
            string jsonVenta = JsonConvert.SerializeObject(ventaData);

            // Realiza la solicitud POST
            var response = WebHelper.Post("Venta/AgregarVenta", jsonVenta);

            return response.IsSuccessStatusCode; // Retorna true si la solicitud fue exitosa
        }
    }
}

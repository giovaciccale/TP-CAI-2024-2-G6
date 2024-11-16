using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Datos;


namespace Persistencia
{
    public class VentasWS
    {
        public string AgregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            try
            {
                // Crea el objeto JSON para la solicitud
                var jsonVenta = JsonConvert.SerializeObject(new
                {
                    idCliente = idCliente,
                    idUsuario = idUsuario,
                    idProducto = idProducto,
                    cantidad = cantidad
                });

                // Realiza la solicitud POST al endpoint
                var response = WebHelper.Post("Venta/AgregarVenta", jsonVenta);

                if (response.IsSuccessStatusCode)
                {
                    // Obtén el Id de la venta de la respuesta del servidor
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    dynamic result = JsonConvert.DeserializeObject(responseBody);
                    return result.id; // Asegúrate de que 'id' sea el campo que contiene el Id de la venta
                }
                else
                {
                    Console.WriteLine("Error al agregar venta: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción al agregar venta: " + ex.Message);
                return null;
            }
        }



        public List<VentaWS> ObtenerVentasPorCliente(string idCliente)
        {
            string url = $"Venta/GetVentaByCliente?id={idCliente}";

            var response = WebHelper.Get(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                List<VentaWS> ventas = JsonConvert.DeserializeObject<List<VentaWS>>(jsonResponse);
                return ventas;
            }
            else
            {
                Console.WriteLine("Error al obtener las ventas del cliente: " + response.StatusCode);
                return null;
            }
        }
    }
}

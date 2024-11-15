using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;


namespace Persistencia
{
    public class ProductosWS
    {
        // Método para agregar un nuevo producto
        public bool AgregarProducto(ProductoWS producto)
        {
            try
            {
                // Serializar el objeto ProductoWS a JSON
                var jsonProducto = JsonConvert.SerializeObject(new
                {
                    id = producto.id,
                    idCategoria = producto.idCategoria,
                    nombre = producto.nombre,
                    fechaAlta = producto.fechaAlta.ToString("o"),
                    fechaBaja = producto.fechaBaja?.ToString("o"),
                    precio = producto.precio,
                    stock = producto.stock,
                    idUsuario = producto.idUsuario,
                    idProveedor = producto.idProveedor
                });

                // Mostrar el JSON generado en la consola para depuración
                System.Diagnostics.Debug.WriteLine("JSON antes de enviar: " + jsonProducto);

                // Llamar al método POST para agregar el producto
                HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonProducto);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Producto agregado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al agregar producto: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar producto: " + ex.Message);
                return false;
            }
        }


        public List<ProductoWS> buscarDatosProducto()
        {
            try
            {
                // URL del endpoint
                string url = "Producto/TraerProductos";

                // Realiza la solicitud GET al endpoint
                var response = WebHelper.Get(url);

                if (response.IsSuccessStatusCode)
                {
                    // Lee el contenido de la respuesta como string
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;

                    // Deserializa la respuesta JSON a una lista de objetos ProductoWS
                    List<ProductoWS> productos = JsonConvert.DeserializeObject<List<ProductoWS>>(jsonResponse);

                    return productos;
                }
                else
                {
                    Console.WriteLine("Error en la solicitud: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los productos: " + ex.Message);
                return null;
            }
        }

            public bool ActualizarStock(string idProducto, int cantidadVendida)
            {
                // Lógica para actualizar el stock del producto en la base de datos
                // Aquí deberías restar la cantidadVendida del stock actual del producto con idProducto

                // Ejemplo de lógica (esto dependerá de cómo manejes tu base de datos):
                var producto = buscarDatosProducto().FirstOrDefault(p => p.id.ToString() == idProducto);
                if (producto != null)
                {
                    producto.stock -= cantidadVendida;
                    // Código para guardar los cambios en la base de datos
                    return true; // Retorna true si la actualización fue exitosa
                }
                return false; // Retorna false si no se encontró el producto
            }
        
    }









}


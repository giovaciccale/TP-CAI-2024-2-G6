using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Persistencia
{
    public class ProveedoresWS
    {
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";
        DateTime FechaAlta = DateTime.Now;

        // Método para agregar un nuevo usuario
        public bool AgregarProveedor(ProveedoreWS proveedor)
        {


            try
            {

                // Serializar el objeto UsuarioWS a JSON
                var jsonUsuario = JsonConvert.SerializeObject(new
                {
                    idUsuario = adminId,
                    nombre = proveedor.nombre,
                    apellido = proveedor.apellido,
                    email = proveedor.email,
                    cuit = proveedor.cuit


                });

                // Mostrar el JSON generado en la consola para depuración
                System.Diagnostics.Debug.WriteLine("JSON antes de enviar: " + jsonUsuario);

                // Llamar al método POST para agregar el usuario
                HttpResponseMessage response = WebHelper.Post("Proveedor/AgregarProveedor", jsonUsuario);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Proveedor agregado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al agregar usuario: {response.StatusCode} - {response.ReasonPhrase}");
                    return false; // Retorna false si el agregado falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar usuario: " + ex.Message);
                return false; // Retorna false en caso de una excepción
            }
        }
        public bool DarDeBajaProveedor(string idUsuario, string adminId)
        {
            try
            {
                // Crear el objeto que será enviado en el cuerpo de la solicitud
                var request = new
                {
                    
                    idUsuario = adminId // ID del usuario con permisos para dar de baja (en este caso el admin)
                };

                // Convertir el objeto a formato JSON
                string jsonRequest = JsonConvert.SerializeObject(request);

                // Llamar al método DELETE con cuerpo del WebHelper
                HttpResponseMessage response = WebHelper.DeleteWithBody("Proveedor/BajaProveedor", jsonRequest);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Proveedor dado de baja exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al dar de baja proveedor: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al dar de baja proveedor: " + ex.Message);
                return false;
            }
        }

        public List<ProveedoreWS> buscarDatosProveedor()
        {
            try
            {
                HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<ProveedoreWS>>(contentStream);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Retorna null si la búsqueda falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de buscar los proveedores: " + ex.Message);
                return null; // Retorna null en caso de una excepción
            }
        }
    }
}

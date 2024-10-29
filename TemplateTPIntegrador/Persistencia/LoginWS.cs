using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Persistencia;

namespace Persistencia
{
    public class LoginWS
    {
        public String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public String login(String username, String password)
        {
            try
            {
                Dictionary<String, String> datos = new Dictionary<String, String>
                {
                    { "nombreUsuario", username },
                    { "contraseña", password }
                };

                var jsonData = JsonConvert.SerializeObject(datos);

                HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonData);

                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    return JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Retorna null si el login falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento del Login: " + ex.Message);
                return null; // Retorna null en caso de una excepción
            }
        }

        public List<UsuarioWS> buscarDatosUsuario()
        {
            try
            {
                HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Retorna null si la búsqueda falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de buscar los usuarios: " + ex.Message);
                return null; // Retorna null en caso de una excepción
            }
        }

        public bool DarDeBajaUsuario(string idUsuario, string adminId)
        {
            try
            {
                // Crear el objeto que será enviado en el cuerpo de la solicitud
                var request = new
                {
                    id = idUsuario,               // ID del usuario que quieres dar de baja
                    idUsuario = adminId // ID del usuario con permisos para dar de baja (en este caso el admin)
                };

                // Convertir el objeto a formato JSON
                string jsonRequest = JsonConvert.SerializeObject(request);

                // Llamar al método DELETE con cuerpo del WebHelper
                HttpResponseMessage response = WebHelper.DeleteWithBody("Usuario/BajaUsuario", jsonRequest);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Usuario dado de baja exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al dar de baja usuario: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al dar de baja usuario: " + ex.Message);
                return false;
            }
        }




    }
}

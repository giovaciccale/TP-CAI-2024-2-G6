using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Persistencia
{
    public class LoginWS
    {
        private String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

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
    }
}

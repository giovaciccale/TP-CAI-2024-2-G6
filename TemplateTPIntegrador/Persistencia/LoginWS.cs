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
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";

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


    }
}

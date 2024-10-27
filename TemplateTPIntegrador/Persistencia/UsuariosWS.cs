using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace Persistencia
{
    public class UsuariosWS
    {
        public String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        // Método para crear un usuario en la API
        public bool CrearUsuario(UsuarioWS nuevoUsuario)
        {
            try
            {
                // Asegúrate de asignar el `adminId` como `idUsuario` en el objeto nuevoUsuario
                nuevoUsuario.IdUsuario = adminId;

                // Serializa el objeto UsuarioWS a JSON
                string jsonData = JsonConvert.SerializeObject(nuevoUsuario);

                // Realiza la solicitud POST a la API usando el WebHelper
                HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonData);

                // Verifica si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Usuario creado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al crear el usuario: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el usuario: " + ex.Message);
                return false;
            }
        }


    }
 }


using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Net.Http;

namespace Persistencia
{
    public class UsuariosWS
    {
        public String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        // Método para agregar un nuevo usuario
        public bool AgregarUsuario(UsuarioWS usuario)
        {


            try
            {
                // Serializar el objeto UsuarioWS a JSON
                var jsonUsuario = JsonConvert.SerializeObject(new
                {
                    idUsuario = adminId,
                    nombre = usuario.nombre,
                    apellido = usuario.apellido,
                    dni = usuario.dni,
                    direccion = usuario.direccion,
                    telefono = usuario.telefono,
                    email = usuario.email,
                    fechaNacimiento = usuario.fechaNacimiento.ToString("o"),
                    host = usuario.host
                });

                // Llamar al método POST para agregar el usuario
                HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonUsuario);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Usuario agregado exitosamente.");
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
    }
}

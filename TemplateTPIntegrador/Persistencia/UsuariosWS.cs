using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Persistencia
{
    public class UsuariosWS
    {
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";
        public String contraseñaTemporal = "CAI20232";
        DateTime FechaAlta = DateTime.Now;

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
                    host = usuario.host,
                    nombreUsuario = usuario.nombreUsuario,
                    contraseña = contraseñaTemporal,
                    fechaAlta = FechaAlta


                });

                // Mostrar el JSON generado en la consola para depuración
                System.Diagnostics.Debug.WriteLine("JSON antes de enviar: " + jsonUsuario);

                // Llamar al método POST para agregar el usuario
                HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonUsuario);

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
        public bool ReactivarUsuario(string idUsuario)
        {
            try
            {
                // Crear el objeto que será enviado en el cuerpo de la solicitud
                var request = new
                {
                    id = idUsuario,        // ID del usuario que deseas reactivar
                    idUsuario = adminId    // ID del usuario administrador con permisos para reactivar
                };

                // Convertir el objeto a formato JSON
                string jsonRequest = JsonConvert.SerializeObject(request);

                // Llamar al método PATCH de WebHelper
                HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonRequest);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Usuario reactivado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al reactivar usuario: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reactivar usuario: " + ex.Message);
                return false;
            }
        }
        public bool CambiarContraseña(string nombreUsuario, string contraseñaActual, string contraseñaNueva, DateTime fechaAlta)
        {
            try
            {
  

                var request = new
                {
                    nombreUsuario = nombreUsuario,
                    contraseña = contraseñaActual,
                    contraseñaNueva = contraseñaNueva,
                    FechaUltimoCambio = fechaAlta // Incluye la fecha de último cambio en el request
                };

                string jsonRequest = JsonConvert.SerializeObject(request);

                // Llamar al método PATCH de WebHelper
                HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonRequest);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Contraseña cambiada exitosamente. Fecha de último cambio actualizada a: " + fechaAlta);
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al cambiar la contraseña: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cambiar la contraseña: " + ex.Message);
                return false;
            }
        }
        public bool EsContraseñaExpirada(DateTime? fechaUltimoCambio)
        {
            // Si la fecha de último cambio es null, consideramos que la contraseña ha expirado.
            if (!fechaUltimoCambio.HasValue)
            {
                return true;
            }

            // Si tiene valor, calcula los días desde el último cambio y verifica si son 30 o más.
            return (DateTime.Now - fechaUltimoCambio.Value).TotalDays >= 30;
        }


    }
}

using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Utils;

namespace Persistencia
{
    public class ClientesWS
    {
        public String adminId = "3220f419-a126-47a1-950f-202d19be8d4c";
        DateTime FechaAlta = DateTime.Now;

        // Método para agregar un nuevo cliente
        public bool Agregarcliente(ClienteWS cliente)
        {


            try
            {

                // Serializar el objeto ClienteWS a JSON
                var jsonCliente = JsonConvert.SerializeObject(new
                {
                    idcliente = adminId,
                    nombre = cliente.nombre,
                    apellido = cliente.apellido,
                    dni = cliente.dni,
                    direccion = cliente.direccion,
                    telefono = cliente.telefono,
                    email = cliente.email,
                    fechaNacimiento = cliente.fechaNacimiento.ToString("o"),
                    host = cliente.host,
                    fechaAlta = FechaAlta


                });

                // Mostrar el JSON generado en la consola para depuración
                System.Diagnostics.Debug.WriteLine("JSON antes de enviar: " + jsonCliente);

                // Llamar al método POST para agregar el cliente
                HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonCliente);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("cliente agregado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al agregar cliente: {response.StatusCode} - {response.ReasonPhrase}");
                    return false; // Retorna false si el agregado falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
                return false; // Retorna false en caso de una excepción
            }
        }
        public bool DarDeBajacliente(string idcliente, string adminId)
        {
            try
            {
                // Crear el objeto que será enviado en el cuerpo de la solicitud
                var request = new
                {
                    id = idcliente,               // ID del cliente que quieres dar de baja
                    idcliente = adminId // ID del cliente con permisos para dar de baja (en este caso el admin)
                };

                // Convertir el objeto a formato JSON
                string jsonRequest = JsonConvert.SerializeObject(request);

                // Llamar al método DELETE con cuerpo del WebHelper
                HttpResponseMessage response = WebHelper.DeleteWithBody("Cliente/BajaCliente", jsonRequest);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("cliente dado de baja exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al dar de baja cliente: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al dar de baja cliente: " + ex.Message);
                return false;
            }
        }
        public List<ClienteWS> buscarDatoscliente()
        {
            try
            {
                HttpResponseMessage response = WebHelper.Get("Cliente/GetClientes?id=" + adminId);

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<ClienteWS>>(contentStream);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Retorna null si la búsqueda falla
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de buscar los clientes: " + ex.Message);
                return null; // Retorna null en caso de una excepción
            }
        }
    }
}

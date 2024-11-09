using Datos;
using Persistencia;
using System;
using System.Linq;

namespace Negocio
{
    public class UsuarioBloqueadoException : Exception
    {
        public UsuarioBloqueadoException(string message) : base(message)
        {
        }
    }

    public class LoginNegocio
    {
        private const int MaxIntentos = 3; // Máximo de intentos permitidos

        public bool Login(string usuario, string password, out bool requiereCambioContraseña, out string idUsuario, out string 
            nombreUsuario, out string contraseñaActual, out DateTime fechaAlta, out int host)
        {
            requiereCambioContraseña = false;
            idUsuario = null;
            nombreUsuario = null;
            host = 0;
            contraseñaActual = password; // Asignar la contraseña actual
            fechaAlta = DateTime.MinValue; // Inicialización predeterminada para evitar errores CS0177


            LoginDB loginDB = new LoginDB();
            LoginWS loginWS = new LoginWS();
            UsuariosWS usuariosWS = new UsuariosWS();

            int cantidadIntentos = loginDB.obtenerIntentos(usuario);

            // Verificar si el usuario ha excedido los intentos permitidos
            if (cantidadIntentos >= MaxIntentos)
            {
                throw new UsuarioBloqueadoException("Su usuario ha sido bloqueado por exceder el número máximo de intentos. Por favor, póngase en contacto con el administrador.");
            }

            // Llamar al servicio de login
            idUsuario = loginWS.login(usuario, password);

            if (string.IsNullOrEmpty(idUsuario))
            {
                // Incrementar intentos si el login falla
                cantidadIntentos++;
                if (cantidadIntentos == 1)
                {
                    loginDB.guardarIntento(usuario); // Guarda el primer intento
                }
                else
                {
                    loginDB.actualizarIntento(usuario, cantidadIntentos.ToString()); // Actualiza si ya existía
                }

                // Verificar si el usuario ha alcanzado el máximo de intentos
                if (cantidadIntentos >= MaxIntentos)
                {
                    throw new UsuarioBloqueadoException("Su usuario ha sido bloqueado por exceder el número máximo de intentos. Por favor, póngase en contacto con el administrador.");
                }

                // Retornar false ya que el login no fue exitoso
                return false;
            }

            // Si el inicio de sesión es exitoso, restablece el contador de intentos a cero
            loginDB.actualizarIntento(usuario, "0");

            // Llamar a buscarDatosUsuario para obtener detalles de todos los usuarios activos
            var usuariosActivos = usuariosWS.buscarDatosUsuario();
            if (usuariosActivos == null)
            {
                throw new Exception("Error al obtener usuarios activos.");
            }

            // Buscar el usuario actual en la lista de usuarios activos
            var usuarioDetalles = usuariosActivos.FirstOrDefault(u => u.nombreUsuario == usuario);

            if (usuarioDetalles != null)
            {
                // Asignar detalles del usuario
                nombreUsuario = usuarioDetalles.nombreUsuario;
                host = usuarioDetalles.host;
              


                // Verificar si la contraseña ha expirado (30 días)
                if (usuariosWS.EsContraseñaExpirada(usuarioDetalles.fechaAlta))
                {
                    requiereCambioContraseña = true;
                    Console.WriteLine("La contraseña ha expirado o es el primer inicio la misma necesita ser cambiada.");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Usuario no encontrado entre los usuarios activos.");
                return false;
            }

            // Verificar si la contraseña es la contraseña temporal inicial
            if (password == "CAI20232")
            {
                requiereCambioContraseña = true;
                Console.WriteLine("El usuario debe cambiar la contraseña.");
                return true;
            }

            Console.WriteLine("Inicio de sesión exitoso.");
            return true;
        }
    }
}

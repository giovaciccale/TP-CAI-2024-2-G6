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

        public bool Login(String usuario, String password)
        {
            LoginDB loginDB = new LoginDB();
            LoginWS loginWS = new LoginWS();
            int cantidadIntentos = loginDB.obtenerIntentos(usuario);

            // Verificar si el usuario ha excedido los intentos permitidos
            if (cantidadIntentos >= MaxIntentos)
            {
                throw new UsuarioBloqueadoException("Su usuario ha sido bloqueado por exceder el número máximo de intentos. Por favor, póngase en contacto con el administrador.");
            }

            // Llamar al servicio de login
            String idUsuario = loginWS.login(usuario, password);

            if (string.IsNullOrEmpty(idUsuario))
            {
                // Si el login falla, incrementa los intentos
                cantidadIntentos++;
                if (cantidadIntentos == 1)
                {
                    loginDB.guardarIntento(usuario); // Guarda el primer intento si es nuevo
                }
                else
                {
                    loginDB.actualizarIntento(usuario, cantidadIntentos.ToString()); // Actualiza si ya existía
                }

                // Verificar si el usuario ha alcanzado el máximo de intentos después de este fallo
                if (cantidadIntentos >= MaxIntentos)
                {
                    // Llamar a buscarDatosUsuario para obtener todos los usuarios activos
                    var usuariosActivos = loginWS.buscarDatosUsuario();

                    // Buscar el usuario que está intentando ingresar
                    var usuarioEncontrado = usuariosActivos?.FirstOrDefault(u => u.NombreUsuario == usuario);

                    if (usuarioEncontrado != null)
                    {
                        string idUsuarioEncontrado = usuarioEncontrado.Id.ToString();

                        // Dar de baja al usuario usando el método DarDeBajaUsuario
                        bool usuarioDadoDeBaja = loginWS.DarDeBajaUsuario(idUsuarioEncontrado, loginWS.adminId);

                        if (usuarioDadoDeBaja)
                        {
                            Console.WriteLine("El usuario ha sido dado de baja correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Error al dar de baja al usuario.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró al usuario entre los usuarios activos.");
                    }

                    throw new UsuarioBloqueadoException("Su usuario ha sido bloqueado por exceder el número máximo de intentos. Por favor, póngase en contacto con el administrador.");
                }
                else
                {
                    // Mensaje si aún no ha alcanzado el máximo de intentos
                    Console.WriteLine($"Credenciales inválidas. Intento {cantidadIntentos} de {MaxIntentos}");
                }

                return false;
            }

            // Si el login es exitoso, restablece el contador de intentos a cero
            loginDB.actualizarIntento(usuario, "0");

            Console.WriteLine("Inicio de sesión exitoso.");
            return true;
        }
    }
}

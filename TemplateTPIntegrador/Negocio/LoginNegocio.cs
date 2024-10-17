using Datos;
using Persistencia;
using System;

namespace Negocio
{
    public class LoginNegocio
    {
        private const int MaxIntentos = 3; // Máximo de intentos permitidos

        public bool Login(String usuario, String password)
        {
            LoginDB loginDB = new LoginDB();
            int cantidadIntentos = loginDB.obtenerIntentos(usuario);

            // Verificar si el usuario ha excedido los intentos permitidos
            if (cantidadIntentos >= MaxIntentos)
            {
                Console.WriteLine("Usuario bloqueado por exceder intentos permitidos.");
                // Lanza una excepción para indicar que el usuario está bloqueado
                throw new Exception("Usuario bloqueado por exceder intentos permitidos.");
            }

            // Llamar al servicio de login
            LoginWS loginWS = new LoginWS();
            String idUsuario = loginWS.login(usuario, password);

            if (string.IsNullOrEmpty(idUsuario))
            {
                // Si el login falla, incrementa los intentos
                cantidadIntentos++;
                if (cantidadIntentos ==0 || cantidadIntentos == null)
                {
                    loginDB.guardarIntento(usuario); // Guarda el primer intento si es nuevo
                }
                else
                {
                    loginDB.actualizarIntento(usuario, cantidadIntentos.ToString()); // Actualiza si ya existía
                }

                // Verificar nuevamente si el usuario ha alcanzado el máximo de intentos después de este fallo
                if (cantidadIntentos >= MaxIntentos)
                {
                    Console.WriteLine("Usuario bloqueado por exceder intentos permitidos.");
                    // Lanza una excepción para indicar que el usuario está bloqueado
                    throw new Exception("Usuario bloqueado por exceder intentos permitidos.");
                }
                else
                {
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

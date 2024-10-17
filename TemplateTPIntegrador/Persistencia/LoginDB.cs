using Persistencia.Utils;
using System;

namespace Persistencia
{
    public class LoginDB
    {
        public void guardarIntento(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Insertar(username, "1"); // Guarda el primer intento
        }

        public void actualizarIntento(String key, String newValue)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Modificar(key, newValue); // Actualiza el valor del intento existente
        }

        public int obtenerIntentos(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            String valor = dbHelper.Buscar(username);

            if (valor == null)
            {
                valor = "0";
            }

            return int.Parse(valor);
        }
    }
}

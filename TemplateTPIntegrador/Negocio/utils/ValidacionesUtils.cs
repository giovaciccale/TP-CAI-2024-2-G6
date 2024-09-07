using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.utils
{
    public class ValidacionesNegocioUtils
    {
        public bool ValidarUsuario(string txt_usuario)
        {
            // Validación básica del nombre de usuario
            if (string.IsNullOrWhiteSpace(txt_usuario) || txt_usuario.Length < 8 || txt_usuario.Length > 15)
            {
                //MessageBox.Show("El nombre de usuario debe tener entre 8 y 15 caracteres.");
                return false;
            }
            return true;
        }
    }

 }

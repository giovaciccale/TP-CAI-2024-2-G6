using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.utils
{
    public class ValidacionesTemplateUtils
    {
        public bool ValidarStringVacio(string dato)
        {
            if (dato == "")
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}

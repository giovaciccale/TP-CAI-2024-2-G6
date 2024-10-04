using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        public void Login(string username, string password)
        {
            LoginWS loginWS = new LoginWS();
            loginWS.login(username, password);

            //aca escribo que hace el login
            //public void LoginNegocio(string usuario, string password
        }
    }
}

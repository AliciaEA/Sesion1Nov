using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion11.Modelos
{
    internal class UserManager
    {
        private string User = "uam";
        private string Pw = "1234";

        public bool Autenticar(string user, string pw)
        {
            return user == User && pw == Pw;
        }
    }
}

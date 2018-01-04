using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testproject.Services
{
    public class AccountsService
    {
        public bool Login(string email, string password)
        {
            if (email == "a@b.c" && password == "pass")
            {
                return true;
            }

            return false;
        }
    }
}

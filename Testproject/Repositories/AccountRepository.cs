using Testproject.Models;

namespace Testproject.Repositories
{
    public class AccountRepository
    {
        public Account GetAccount(string email)
        {
            return new Account
            {
                Id = 1,
                Email = "a@b.c",
                Password = "pass"
            };
        }
    }
}
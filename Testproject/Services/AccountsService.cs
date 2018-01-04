using Testproject.Repositories;

namespace Testproject.Services
{
    public class AccountsService
    {
        private readonly AccountRepository _repository;

        public AccountsService(AccountRepository repository)
        {
            _repository = repository;
        }

        public bool Login(string email, string password)
        {
            var account = _repository.GetAccount(email);

            if (account.Password == password) return true;

            return false;
        }
    }
}
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
            var exists = _repository.Exists(email, password);

            if (exists) return true;

            return false;
        }
    }
}
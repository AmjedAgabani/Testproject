using Microsoft.AspNetCore.Mvc;
using Testproject.Models;
using Testproject.Services;

namespace Testproject.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AccountsService _service;

        public AccountsController(AccountsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (_service.Login(viewModel.Email, viewModel.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }
    }
}
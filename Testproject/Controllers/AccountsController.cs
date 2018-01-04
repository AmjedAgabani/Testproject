using Microsoft.AspNetCore.Mvc;
using Testproject.Models;

namespace Testproject.Controllers
{
    public class AccountsController : Controller
    {
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
            if (viewModel.Email == "a@b.c" && viewModel.Password == "pass")
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }
    }
}
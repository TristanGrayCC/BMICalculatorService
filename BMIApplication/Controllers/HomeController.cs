using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BMIApplication.Models;
using BMIApplication.Data;
using BMIApplication.Services;

namespace BMIApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginService _loginService;

        public HomeController(ApplicationDbContext context)
        {
            _loginService = new LoginService(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            var userData = _loginService.GetUserData(User.Identity.Name);
            return View(userData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

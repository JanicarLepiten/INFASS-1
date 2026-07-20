using System.Diagnostics;
using INFASS_LEPITEN.Models;
using Microsoft.AspNetCore.Mvc;

namespace INFASS_LEPITEN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserModel user = new UserModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public string Register(
                string fullName,
                string email,
                int age,
                string gender,
                string username,
                string password,
                string confirmPassword)
        {
            UserModel user = new UserModel();

            string query = user.Sql(
                fullName,
                email,
                age,
                gender,
                username,
                password,
                confirmPassword);

            return query;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
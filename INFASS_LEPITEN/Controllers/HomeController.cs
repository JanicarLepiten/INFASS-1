using System.Diagnostics;
using INFASS_LEPITEN.Models;
using Microsoft.AspNetCore.Mvc;

namespace INFASS_LEPITEN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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
        public IActionResult Register(UserModel user)
        {
            string message =
                $"Full Name: {user.FullName}\n" +
                $"Email: {user.Email}\n" +
                $"Age: {user.Age}\n" +
                $"Gender: {user.Gender}\n" +
                $"Username: {user.Username}\n" +
                $"Password: {user.Password}\n" +
                $"Confirm Password: {user.ConfirmPassword}";

            return Json(message);
        }

        //[HttpPost]
        //public IActionResult Register(
        //   string fullName,
        //   string email,
        //   int age,
        //   string gender,
        //   string username,
        //   string password,
        //   string confirmPassword)
        //{
        //    string result =
        //        $"Full Name: {fullName}\n" +
        //        $"Email: {email}\n" +
        //        $"Age: {age}\n" +
        //        $"Gender: {gender}\n" +
        //        $"Username: {username}\n" +
        //        $"Password: {password}\n" +
        //        $"Confirm Password: {confirmPassword}";

        //    return Content(result);
        //}

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
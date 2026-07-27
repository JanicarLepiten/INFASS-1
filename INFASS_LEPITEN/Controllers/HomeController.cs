using System.Diagnostics;
using System.Xml.Linq;
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
                string age,
                string gender,
                string username,
                string password,
                string confirmPassword)
        {
            //-----------------OLD CODE----------------------------------
            //string[] fields = ["FullName", "Email", "Age", "Gender", "Username", "Password", "ConfirmPassword"];
            //string[] values = [fullName, email, age, gender, username, password, confirmPassword];

            //-----------------------------------------------NEW CODE------------------------------------------------------
            string[] fields = ["FullName", "Email", "Age", "Gender", "Username", "Password", "ConfirmPassword"];
            string[] values = ["Janicar" , "janicar2124@gmail.com" , "21" , "Female" , "Jani" , "jani" , "jani"];
            //string query = user._Insert(fields, values, "user");
            //string query = user._Update(fields,values,"user","UserId=2");
            string query = user._Delete("user","UserId=1");
            //string query = user._ViewAll("Users");

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
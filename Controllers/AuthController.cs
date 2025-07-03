using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("~/Views/Pages/Auth/Login.cshtml");
        }
    }
}

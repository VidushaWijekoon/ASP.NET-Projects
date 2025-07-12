using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Auth/Login.cshtml");
        }
    }
}
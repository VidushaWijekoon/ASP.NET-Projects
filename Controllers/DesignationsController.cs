using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class DesignationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

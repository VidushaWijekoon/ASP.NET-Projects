using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
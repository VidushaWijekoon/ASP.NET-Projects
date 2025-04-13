using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class SuperAdminController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
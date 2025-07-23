using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
             return View("~/Views/Pages/Departments/Index.cshtml");
        }
    }
}

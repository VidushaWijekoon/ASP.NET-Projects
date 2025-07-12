using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is Department Controller");
        }
    }
}

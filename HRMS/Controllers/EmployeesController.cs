using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Employee CRUD");
        }
    }
}

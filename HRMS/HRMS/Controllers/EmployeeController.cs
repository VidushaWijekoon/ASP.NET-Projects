using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
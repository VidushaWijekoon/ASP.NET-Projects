using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class BranchesController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Pages/Branches/Index.cshtml");
        }
    }
}

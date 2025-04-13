using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Branches()
        {
            return View("Branches/Branches");
        }

        public IActionResult CreateBranch()
        {
            return View("Branches/CreateBranch");
        }

        // public IActionResult SaveBranch()
        // {
            
        // }
    }
}
using Microsoft.AspNetCore.Mvc;
using HRMS.Data;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public BranchesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var branches = _dbContext.Branches.ToList();
            return View("~/Views/Pages/Branches/Index.cshtml", branches);
        }

        [HttpPost]
        [Route("Branches/Create")]
        public IActionResult Create()
        {
            var formData = Request.Form
                .ToDictionary(kvp => kvp.Key.ToLower(), kvp => kvp.Value.ToString());

            TimeZoneInfo dubaiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime dubaiTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, dubaiTimeZone);

            var branch = new Branch
            {
                BranchName = formData.GetValueOrDefault("name"),
                BranchEmailAddress = formData.GetValueOrDefault("email"),
                BranchAddress = formData.GetValueOrDefault("address"),
                ContactNo = formData.GetValueOrDefault("contactno"),
                LandlineNo = formData.GetValueOrDefault("landlineno"),
                FaxNo = formData.GetValueOrDefault("faxno"),
                City = formData.GetValueOrDefault("emirates"),
                BranchCityCode = formData.GetValueOrDefault("citycode"),
                BranchPostalCode = formData.GetValueOrDefault("postalcode"),
                BranchLabourFileno = formData.GetValueOrDefault("labourfileno"),
                BranchAreaManager = formData.GetValueOrDefault("area_manager"),
                BranchManager = formData.GetValueOrDefault("branch_manager"),
                BranchAssistantManager = formData.GetValueOrDefault("asst_manager"),
                CreatedBy = "system",
                CreatedAt = dubaiTime,
                BranchStatus = BranchStatusEnum.Active
            };

            _dbContext.Branches.Add(branch);
            _dbContext.SaveChanges();

            TempData["SuccessMessage"] = "Branch created successfully!";
            return RedirectToAction("Index");
        }
    }
}

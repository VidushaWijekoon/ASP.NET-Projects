using Microsoft.AspNetCore.Mvc;
using HRMS.Data;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Controllers
{
    public class CheckConnectionController : Controller
    {
        private readonly AppDbContext _context;

        public CheckConnectionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("/check-connection")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var canConnect = await _context.Database.CanConnectAsync();
                if (canConnect)
                {
                    return Ok("✅ Database connection successful.");
                }
                else
                {
                    return StatusCode(500, "❌ Cannot connect to the database.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"❌ Error: {ex.Message}");
            }
        }
    }
}

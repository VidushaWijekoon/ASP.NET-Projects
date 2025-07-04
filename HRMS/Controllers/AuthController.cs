using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View("~/Views/Auth/Login.cshtml");
        }

        [HttpPost]
        public IActionResult LoginCheck()
        {
            var postData = string.Join("\n", Request.Form.Select(d => $"{d.Key}: {d.Value}"));
            Content("LoginCheck endpoint is working!\n\n" + postData);

            string email = Request.Form["email"];
            string password = Request.Form["password"];

            return Content("Email " + email + "Password" + password);
        }

        public IActionResult ForgetPassword()
        {
            return View("~/Views/Auth/ForgetPassword.cshtml");
        }
    }
}

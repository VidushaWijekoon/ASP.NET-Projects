using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult LoginCheck()
        {
            var postData = string.Join("\n", Request.Form.Select(d => $"{d.Key}: {d.Value}"));
            Content("LoginCheck endpoint is working!\n\n" + postData);

            return Content(postData);
        }

        public IActionResult ForgetPassword()
        {
            return View("~/Views/Auth/ForgetPassword.cshtml");
        }
    }
}

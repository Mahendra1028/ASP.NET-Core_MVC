using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class SignUpController : Controller
    {

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                //To Do:
                TempData["Message"] = "Your account has been created!";

                return View("~/views/signup/Message.cshtml");
            }
            return View();
        }

    }
}

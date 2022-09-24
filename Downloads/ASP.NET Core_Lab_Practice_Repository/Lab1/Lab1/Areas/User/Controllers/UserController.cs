using Lab1.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {

        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]

        [Route("User/User/UserLogin")]
        public IActionResult UserLogin(UserLoginModel mg)
        {
            string username = mg.Username;
            string password = mg.Password;
            if(!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("UserDashboard");
           
        }
        [Route("User/User/UserDashboard")]
        public IActionResult UserDashboard()
        {
            return View();
        }
        [Route("User/User/UserProfile")]
        public IActionResult UserProfile()
        {
            return View();
        }
    }
}

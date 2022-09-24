using Lab1.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Admin/Login/Login")]
        public IActionResult Login(LoginModel model)
        {
            LoginModel lg = new LoginModel();
            if (!ModelState.IsValid)
            {
                return View();              
            }
            lg.Username = model.Username;
            lg.Password = model.Password;
            return RedirectToAction("Dashboard");

        }
        [Route("Admin/Login/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [Route("Admin/Login/Profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }

}

using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult CommentHistory()
        {
            return View();
        }

        public IActionResult Index(comment cst)
        {
            var cm = cst.comments;
            if (cm != null)
            {
                if (ModelState.IsValid)
                {
                    ViewData["comments"] = cst.comments;
                    return ViewComponent("ArticleComments", new { cs = cst.comments });
                }
            }
            return View();

        }
    }
}

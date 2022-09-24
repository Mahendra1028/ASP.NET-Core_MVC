using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.ViewComponents
{
    public class ArticleCommentsViewComponent : ViewComponent
    {
        List<string> com = new List<string>();
        public IViewComponentResult Invoke(string cs)
        {
            

            com.Add(cs);
            ViewData["CommentCount"] = com.Count;

            if (com.Count >= 1)
            {
                return View("~/views/component/comments.cshtml", com);
            }
            else
            {
                return View("~/views/article/Index.cshtml");
            }
        }
    }

}

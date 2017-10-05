using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class TagController : Controller
    {
        BlogContext context = new BlogContext();
        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TagWidget()
        {
            return PartialView(context.Tags.ToList());
        }
    }
}
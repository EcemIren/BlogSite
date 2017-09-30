using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ListJournalWidget()
        {
            return PartialView(context.Journals.ToList());
        }
    }
}
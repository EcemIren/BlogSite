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

        public ActionResult ListJournalWidget()
        {
            var data = context.Journals.ToList();
            return View("ListJournalWidget",data);
        }

        public PartialViewResult PopularJournalWidget()
        {
            var model = context.Journals.OrderByDescending(x => x.CreationDate).Take(3);
            return PartialView(model);
        }
    }
}
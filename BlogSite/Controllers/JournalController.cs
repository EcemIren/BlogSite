using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class JournalController : Controller
    {
        BlogContext context = new BlogContext();
        // GET: Journal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var data = context.Journals.FirstOrDefault(x => x.JournalId == id);
            return View(data);
        }
    }
}
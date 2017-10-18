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
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult TagWidget()
        {
            return PartialView(context.Tags.ToList());
        }


        public ActionResult ListJournalsOfTag(int id)
        {
            var data = context.Journals.Where(x => x.Tags.Any(y => y.TagId == id)).ToList();

            return View("ListJournalWidget", data);
        }
    }
}
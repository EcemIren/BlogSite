using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class CategoryController : Controller
    {
        BlogContext context = new BlogContext();

        // GET: Category
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult CategoryWidget()
        {
            return PartialView(context.Categories.ToList());
        }

        public ActionResult ListJournalsOfCategory(int id)
        {
            var data = context.Journals.Where(x => x.CategoryId == id).ToList();
            return View("ListJournalWidget",data);
        }
    }
}
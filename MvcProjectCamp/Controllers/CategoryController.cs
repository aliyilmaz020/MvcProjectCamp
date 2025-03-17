using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var values = manager.GetAllBL();
            return View(values);
        }
    }
}
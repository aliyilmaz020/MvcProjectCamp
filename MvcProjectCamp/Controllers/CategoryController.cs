using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        public ActionResult AddCategory(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            p.CategoryStatus = true;
            manager.CategoryAddBL(p);
            return RedirectToAction("Index");
        }
    }
}
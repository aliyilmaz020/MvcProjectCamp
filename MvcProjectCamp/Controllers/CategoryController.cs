using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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
        CategoryManager manager = new CategoryManager(new EfCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            var values = manager.GetList();
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
            //manager.CategoryAddBL(p);
            return RedirectToAction("Index");
        }
    }
}
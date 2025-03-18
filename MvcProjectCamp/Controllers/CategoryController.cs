using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator validator = new CategoryValidator();
            ValidationResult results = validator.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                manager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
    }
}
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
    public class AdminCategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator validations = new CategoryValidator();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult Remove(int id)
        {
            var value = cm.GetById(id);
            cm.CategoryRemove(value);
            return RedirectToAction("Index");
        }
        
    }
}
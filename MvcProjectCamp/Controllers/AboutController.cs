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
    [Authorize(Roles="A")]
    public class AboutController : Controller
    {
        AboutManager manager = new AboutManager(new EfAboutDal());
        AboutValidator validations = new AboutValidator();
        public ActionResult Index()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            ModelState.Clear();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                manager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return RedirectToAction("Partial1");
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
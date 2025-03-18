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
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        HeadingValidator validations = new HeadingValidator();
        public ActionResult Index()
        {
            var value = hm.TGetList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> category = cm.TGetList().Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
            category.Insert(0, new SelectListItem { Value = "0", Text = "Lütfen Kategori Seçiniz" });
            ViewBag.Category = category;

            List<SelectListItem> writer = wm.TGetList().Select(x => new SelectListItem
            {
                Text = x.WriterName + " " + x.WriterSurname,
                Value = x.WriterId.ToString()
            }).ToList(); 
            writer.Insert(0, new SelectListItem { Value = "0", Text = "Lütfen Yazar Seçiniz" });
            ViewBag.Writer = writer;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            ModelState.Clear();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                p.HeadingDate = DateTime.Now;
                hm.TAdd(p);
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
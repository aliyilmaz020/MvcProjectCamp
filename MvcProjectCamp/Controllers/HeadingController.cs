using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using PagedList;
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
        public ActionResult Index(int page=1)
        {
            var value = hm.TGetList().ToPagedList(page,6);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            ViewBag.Category = GetCategories();
            ViewBag.Writer = GetWriters();
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
                hm.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            ViewBag.Category = GetCategories();
            ViewBag.Writer = GetWriters();
            return View();
        }
        private List<SelectListItem> GetCategories()
        {
            var values = cm.TGetList().Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
            values.Insert(0, new SelectListItem { Value = "0", Text = "Lütfen Kategori Seçiniz" });
            return values;
        }
        private List<SelectListItem> GetWriters()
        {
            var values = wm.TGetList().Select(x => new SelectListItem
            {
                Text = x.WriterName + " " + x.WriterSurname,
                Value = x.WriterId.ToString()
            }).ToList();
            values.Insert(0, new SelectListItem { Value = "0", Text = "Lütfen Yazar Seçiniz" });
            return values;
        }
    }
}
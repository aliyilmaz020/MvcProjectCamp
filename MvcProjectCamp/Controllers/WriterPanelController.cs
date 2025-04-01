using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    [Authorize(Roles = "W")]
    public class WriterPanelController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingValidator validations = new HeadingValidator();

        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading()
        {
            string mail = Session["Username"].ToString();
            var values = hm.GetListByWriter(mail);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            ViewBag.Category = GetCategories();
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            ViewBag.Category = GetCategories();
            return View();
        }
        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            ViewBag.Category = GetCategories();
            var value = hm.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            ModelState.Clear();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                hm.TUpdate(p);
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
            return View();
        }
        public ActionResult RemoveHeading(int id)
        {
            var value = hm.TGetById(id);
            value.HeadingStatus = false;
            hm.TUpdate(value);
            return RedirectToAction("MyHeading", "WriterPanel");
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
    }
}
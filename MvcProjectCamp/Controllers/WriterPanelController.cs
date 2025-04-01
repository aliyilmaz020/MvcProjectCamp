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
        WriterManager wm = new WriterManager(new EfWriterDal());
        HeadingValidator validations = new HeadingValidator();

        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            string mail = Session["Username"].ToString();
            int id = wm.TWriterId(mail);
            var value = wm.TGetById(id);
            return View(value);
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
            ModelState.Clear();
            p.WriterId = int.Parse(Session["WriterId"].ToString());
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                hm.TInsert(p);
                return RedirectToAction("MyHeading");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            ViewBag.Category = GetCategories();
            return View(p);
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
                return RedirectToAction("MyHeading","WriterPanel");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            ViewBag.Category = GetCategories();
            return View(p);
        }
        public ActionResult RemoveHeading(int id)
        {
            var value = hm.TGetById(id);
            value.HeadingStatus = false;
            hm.TUpdate(value);
            return RedirectToAction("MyHeading", "WriterPanel");
        }
        public ActionResult AllHeading()
        {
            var values = hm.TGetList();
            return View(values);
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
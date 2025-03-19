using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator validations = new WriterValidator();

        public ActionResult Index()
        {
            var values = wm.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                wm.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName, result.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult RemoveWriter(int id)
        {
            var value = wm.TGetById(id);
            wm.TRemove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var value = wm.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName, result.ErrorMessage);
                }
            }
            return View();
        }

    }
}
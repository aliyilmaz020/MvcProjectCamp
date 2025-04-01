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
    public class WriterContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        ContentValidator validationRules = new ContentValidator();
        // GET: WriterContent
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading()
        {
            string mail = Session["Username"].ToString();
            var values = cm.GetListByWriter(mail);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            ModelState.Clear();
            string mail = Session["Username"].ToString();
            p.ContentStatus = true;
            p.WriterId = wm.TWriterId(mail);
            p.ContentDate = DateTime.Now;
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                cm.TInsert(p);
                return RedirectToAction("AllHeading", "WriterPanel");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}
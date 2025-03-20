using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator validations = new ContactValidator();
        public ActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
        public ActionResult GetContactDetails(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }
    }
}
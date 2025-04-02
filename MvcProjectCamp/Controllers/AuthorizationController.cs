using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    [AllowAnonymous]
    public class AuthorizationController : Controller
    {
        private readonly AdminManager admin = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var values = admin.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            admin.TInsert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var value = admin.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            admin.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
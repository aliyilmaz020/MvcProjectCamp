using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    }
}
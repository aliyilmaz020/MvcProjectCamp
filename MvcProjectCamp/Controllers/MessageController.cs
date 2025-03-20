using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class MessageController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageDal());
        // GET: Message
        public ActionResult Inbox()
        {
            var values = manager.TGetList();
            return View(values);
        }
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }
    }
}
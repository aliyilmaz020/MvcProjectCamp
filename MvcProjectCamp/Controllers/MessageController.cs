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
    public class MessageController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageDal());
        MessageValidator validations = new MessageValidator();
        // GET: Message
        public ActionResult Inbox()
        {
            var values = manager.GetListInbox().OrderByDescending(x=>x.MessageDate).ToList();
            return View(values);
        }
        public ActionResult SendBox()
        {
            var values = manager.GetListSendBox().OrderByDescending(x => x.MessageDate).ToList();
            return View(values);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var value = manager.TGetById(id);
            return View(value);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var value = manager.TGetById(id);
            return View(value);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ModelState.Clear();
            p.SenderMail = "admin@manager.com";
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Now;
                manager.TInsert(p);
                return RedirectToAction("Inbox");
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
        public PartialViewResult Sidebar()
        {
            int sendCount = 0, inCount = 0;
            if (manager.GetListInbox() != null)
            {
                inCount = manager.GetListInbox().Count();
            }
            if (manager.GetListSendBox() != null)
            {
                sendCount = manager.GetListSendBox().Count();
            }
            ViewBag.d1 = inCount;
            ViewBag.d2 = sendCount;
            return PartialView();
        }
    }
}
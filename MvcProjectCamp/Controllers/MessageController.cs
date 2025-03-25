using BusinessLayer.Abstract;
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
    [Authorize]
    public class MessageController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageDal());
        MessageValidator validations = new MessageValidator();
        // GET: Message
        public ActionResult Inbox()
        {
            string mail = Session["Username"].ToString();
            var values = manager.GetListInbox(mail).OrderByDescending(x => x.MessageDate).ToList();
            return View(values);
        }
        public ActionResult SendBox()
        {
            string mail = Session["Username"].ToString();
            var values = manager.GetListSendBox(mail).OrderByDescending(x => x.MessageDate).ToList();
            return View(values);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var value = manager.TGetById(id);
            manager.IsRead(id,true);
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
            string mail = Session["Username"].ToString();
            p.SenderMail = mail;
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
        [HttpPost]
        public ActionResult MarkAsRead(List<int> messageIds)
        {

            if (messageIds == null || !messageIds.Any())
            {
                TempData["Message"] = "Hiç mesaj seçilmedi!";
                return RedirectToAction("Inbox");
            }

            manager.MarkAsRead(messageIds);

            TempData["Message"] = "Seçili mesajlar okundu olarak işaretlendi!";
            return RedirectToAction("Inbox");
        }
        [HttpPost]
        public ActionResult MarkAsUnRead(List<int> messageIds)
        {
            if(messageIds == null || !messageIds.Any())
            {
                TempData["Message"] = "Hiç mesaj seçilmedi!";
                return RedirectToAction("Inbox");
            }
            manager.MarkAsUnRead(messageIds);

            TempData["Message"] = "Seçili mesajlar okunmadı olarak işaretlendi!";
            return RedirectToAction("Inbox");
        }


        public PartialViewResult Sidebar()
        {
            string mail = Session["Username"].ToString();

            if (manager.GetListInbox(mail) != null)
            {
                ViewBag.d1 = manager.GetReadMessageCount(mail);
            }
            if (manager.GetListSendBox(mail) != null)
            {
                ViewBag.d2 = manager.GetSentMessageCount(mail);
            }

            return PartialView();
        }
    }
}
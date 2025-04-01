using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjectCamp.Controllers
{
    public class LoginController : Controller
    {
        AdminManager admin = new AdminManager(new EfAdminDal());
        WriterManager writer = new WriterManager(new EfWriterDal());
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            bool isAdminLogin = admin.TIsLogin(username, password);
            bool isUserLogin = writer.TIsLogin(username, password);
            if (isAdminLogin)
            {
                FormsAuthentication.SetAuthCookie(username.ToString(), false);
                Session["Username"] = username.ToString();
                return RedirectToAction("Index", "Writer");
            }
            else if (isUserLogin)
            {
                FormsAuthentication.SetAuthCookie(username.ToString(), false);
                Session["Username"] = username.ToString();
                return RedirectToAction("MyHeading", "WriterPanel");
            }
            else
            {
                TempData["Error"] = "Kullanıcı Adı veya Şifre Hatalı!";
                return View();
            }
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
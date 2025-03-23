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
        AdminManager manager = new AdminManager(new EfAdminDal());
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            bool isLogin = manager.TIsLogin(username, password);
            if (isLogin)
            {
                FormsAuthentication.SetAuthCookie(username.ToString(), false);
                Session["Username"] = username.ToString();
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                TempData["Error"] = "Kullanıcı Adı veya Şifre Hatalı!";
                return View();
            }
        }
    }
}
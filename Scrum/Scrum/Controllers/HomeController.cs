using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Scrum.Model;
using System.Configuration;

namespace Scrum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var secret = ConfigurationManager.AppSettings["Secret"];
            ViewBag.Secret = secret;
            return View();
        
            //if (Session["UserName"] == null)
            //{
            //    ViewBag.LoggedStatus = "Out";
            //}
            //else ViewBag.LoggedStatus = "In";
            //return View();
        } 

        public ActionResult Login()
        {
             return View();
        }

        [HttpPost]
        public ActionResult Authorize(Logins LoginsModel)
        {
            ScrumEntities1 db = new ScrumEntities1();
            var LoggedUser = db.Logins.SingleOrDefault(x => x.UserName == LoginsModel.UserName && x.PassWord == LoginsModel.PassWord);
            if (LoggedUser != null)
            {
                ViewBag.LoginMessage = "Successfull login";
                ViewBag.LoggedStatus = "In";
                Session["UserName"] = LoggedUser.UserName;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginMessage = "Login unsuccessfull";
                ViewBag.LoggedStatus = "Out";
                LoginsModel.PassWord = "Tuntematon käyttäjä tai salasana.";
                return View("Login", LoginsModel);
            }

            //public ActionResult Koulujutut()
            //{

            //    return View();
            //}
        }
    }
}
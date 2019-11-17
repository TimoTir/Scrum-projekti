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



            public ActionResult Login()
            {
                ViewBag.Message = "Titityyy.";

                return View();
            }

            public ActionResult Koulujutut()
            {

                return View();
            }
        }
    }
}
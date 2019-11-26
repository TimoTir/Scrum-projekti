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

        }

        public ActionResult Hae()
        {
            var x = "";

            ScrumEntities1 db = new ScrumEntities1();
            var a = from b in db.Opettajat
                    select b;
            foreach (var s in a)
            {

                x += s.Etunimi.ToString();

            }
            ViewBag.Message = x;




            return View();
        }

        public ActionResult Login()
            {
                ViewBag.Message = "Titityyy.";

                return View();
            }


        }
    }

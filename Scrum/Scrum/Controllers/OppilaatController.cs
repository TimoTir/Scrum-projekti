using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scrum.Model;

namespace Scrum.Controllers
{
    public class OppilaatController : Controller
    {
        // GET: Oppilaat
        public ActionResult Index()
        {
            _ = new ScrumEntities1();
            return View();
        }
    }
}
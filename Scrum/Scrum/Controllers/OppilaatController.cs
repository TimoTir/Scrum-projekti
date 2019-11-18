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
        ScrumEntities1 db = new ScrumEntities1();
        // GET: Oppilaat
        public ActionResult Index()
        {
            List<Opiskelijat> model = db.Opiskelijat.ToList();
            return View(model);
        }
    }
}
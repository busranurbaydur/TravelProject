using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Siniflar;

namespace TravelProject.Controllers
{
    public class MuzelerController : Controller
    {
        // GET: Muzeler
        Context c = new Context();
        public ActionResult Index()
        {
            var muze = c.Muzes.ToList();
            return View(muze);
        }
    }
}
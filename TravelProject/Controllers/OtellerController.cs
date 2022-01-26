using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Siniflar;

namespace TravelProject.Controllers
{
    public class OtellerController : Controller
    {
        // GET: Oteller
        Context c = new Context();
        public ActionResult Index()
        {
            var otel = c.Otels.ToList();
            return View(otel);
        }
    }
}
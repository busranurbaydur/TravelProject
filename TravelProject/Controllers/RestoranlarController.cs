using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Siniflar;

namespace TravelProject.Controllers
{
    public class RestoranlarController : Controller
    {
        // GET: Restoranlar
        Context c = new Context();
        public ActionResult Index()
        {
            var restoran = c.Restorans.ToList();
            return View(restoran);
        }
    }
}
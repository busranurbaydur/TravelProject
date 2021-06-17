﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Siniflar;

namespace TravelProject.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var result = c.Iletisims.ToList();
            return View(result);
        }
    }
}
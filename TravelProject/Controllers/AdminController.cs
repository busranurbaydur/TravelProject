using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Siniflar;

namespace TravelProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var result = c.Blogs.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {

            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }


        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.Id);
            blog.Aciklama = b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.FotoUrl = b.FotoUrl;
            blog.Tarih = b.Tarih;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
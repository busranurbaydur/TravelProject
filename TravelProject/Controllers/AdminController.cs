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

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
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
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {

            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public ActionResult YorumGetir(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yorum = c.Yorumlars.Find(y.Id);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Email = y.Email;
            yorum.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("Index");

            
        }

        public ActionResult HakkimizdaListele()
        {
            var hakkimizda = c.Hakkimizdas.ToList();
            return View(hakkimizda);
        }

        public ActionResult HakkimizdaSil(int id)
        {
            var hakkimizda = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(hakkimizda);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListele");
        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var aciklama = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", aciklama);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hakkimizda = c.Hakkimizdas.Find(h.Id);
            hakkimizda.FotoUrl = h.FotoUrl;
            hakkimizda.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListele");

        }


    }
}
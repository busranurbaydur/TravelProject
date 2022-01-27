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

        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var blg = c.Blogs.Find(id);
            return View("BlogGuncelle", blg);
        }

        [HttpPost]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.Id);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.FotoUrl = b.FotoUrl;
            blg.Tarih = b.Tarih;

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
            return RedirectToAction("YorumListesi");

            
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

        public ActionResult MesajListele()
        {
            var mesaj = c.Iletisims.ToList();
            return View(mesaj);
        }

        public ActionResult OtelListele()
        {
            var otel = c.Otels.ToList();
            return View(otel);
        }

        [HttpGet]
        public ActionResult OtelEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OtelEkle(Otel otel)
        {
            c.Otels.Add(otel);
            c.SaveChanges();
            return RedirectToAction("OtelListele");

        }

        public ActionResult OtelSil(int id)
        {
            var otel = c.Otels.Find(id);
            c.Otels.Remove(otel);
            c.SaveChanges();
            return RedirectToAction("OtelListele");
        }

        [HttpGet]
        public ActionResult OtelGuncelle(int id)
        {
            var otel = c.Otels.Find(id);
            return View("OtelGuncelle",otel);
        }

        [HttpPost]
        public ActionResult OtelGuncelle(Otel otel)
        {
            var otl = c.Otels.FirstOrDefault(x => x.Id == otel.Id);

            otl.Adi = otel.Adi;
            otl.Adresi = otel.Adresi;
            otl.FotoUrl = otel.FotoUrl;
            otl.Ozellikleri = otel.Ozellikleri;
            c.SaveChanges();
            return RedirectToAction("OtelListele");
        }

        public ActionResult MuzeListele()
        {
            var muze = c.Muzes.ToList();
            return View(muze);
        }

        [HttpGet]
        public ActionResult MuzeEkle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult MuzeEkle(Muze muze)
        {
            c.Muzes.Add(muze);
            c.SaveChanges();
            return RedirectToAction("MuzeListele");
        }

        public ActionResult MuzeSil(int id)
        {
            var muze = c.Muzes.Find(id);
            c.Muzes.Remove(muze);
            c.SaveChanges();
            return RedirectToAction("MuzeListele");

        }
        [HttpGet]
        public ActionResult MuzeGuncelle(int id)
        {
            var muze = c.Muzes.Find(id);
            return View("MuzeGuncelle",muze);
        }

        [HttpPost]
        public ActionResult MuzeGuncelle(Muze muze)
        {
            var guncellenecekMuze = c.Muzes.FirstOrDefault(x => x.Id == muze.Id);
            guncellenecekMuze.Adi = muze.Adi;
            guncellenecekMuze.Adresi = muze.Adresi;
            guncellenecekMuze.FotoUrl = muze.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("MuzeListele");
            
        }


        public ActionResult RestoranListele()
        {
            var restoran = c.Restorans.ToList();
            return View(restoran);
        }

        [HttpGet]
        public ActionResult RestoranEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RestoranEkle(Restoran restoran)
        {
            c.Restorans.Add(restoran);
            c.SaveChanges();
            return RedirectToAction("RestoranListele");
        }

        public ActionResult RestoranSil(int id)
        {
            var restoran = c.Restorans.Find(id);
            c.Restorans.Remove(restoran);
            c.SaveChanges();
            return RedirectToAction("RestoranListele");

        }
        [HttpGet]
        public ActionResult RestoranGuncelle(int id)
        {
            var restoran = c.Restorans.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult RestoranGuncelle(Restoran restoran)
        {
            var guncellenecekRestoran = c.Restorans.Find(restoran.Id);
            guncellenecekRestoran.Adi = restoran.Adi;
            guncellenecekRestoran.Adresi = restoran.Adresi;
            guncellenecekRestoran.FotoUrl = restoran.FotoUrl;
            guncellenecekRestoran.YemekCesidi = restoran.YemekCesidi;
            c.SaveChanges();
            return RedirectToAction("RestoranListele");

        }

    }
}
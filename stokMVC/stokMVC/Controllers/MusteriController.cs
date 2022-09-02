using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokMVC.Models.Entity;

namespace stokMVC.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        mvcDbStokEntities db=new mvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.musteriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {        
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(musteriler p1)
        {
            db.musteriler.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var musteri=db.musteriler.Find(id);
            db.musteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mus= db.musteriler.Find(id);
            return View("MusteriGetir", mus);
        }
        public ActionResult Guncelle(musteriler m1)
        {
            var mustri=db.musteriler.Find(m1.musteriId);
            mustri.musteriAd = m1.musteriAd;
            mustri.musteriSoyad = m1.musteriSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
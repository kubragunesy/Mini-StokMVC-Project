using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokMVC.Models.Entity;

namespace stokMVC.Controllers
{
    public class ÜrünController : Controller
    {
        // GET: Ürün
        mvcDbStokEntities db= new mvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.urunler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler=(from i in db.kategoriler.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.kategoriAd,
                                               Value = i.kategoriId.ToString()
                                           }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        
        [HttpPost]
        public ActionResult YeniUrun(urunler p1)
        {
          var ktg = db.kategoriler.Where(m=>m.kategoriId==p1.kategoriler.kategoriId).FirstOrDefault();
          p1.kategoriler = ktg;
          db.urunler.Add(p1);
          db.SaveChanges();
          return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var urun= db.urunler.Find(id);
            db.urunler.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}

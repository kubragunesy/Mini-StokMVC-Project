using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokMVC.Models.Entity;

namespace stokMVC.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        mvcDbStokEntities db = new mvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler= db.kategoriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(kategoriler p1)
        {
            db.kategoriler.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var kategori = db.kategoriler.Find(id);
            db.kategoriler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        
    }
}
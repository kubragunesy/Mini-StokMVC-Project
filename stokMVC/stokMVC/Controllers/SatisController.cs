using stokMVC.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokMVC.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        mvcDbStokEntities db = new mvcDbStokEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(satislar p)
        {
            db.satislar.Add(p);
            db.SaveChanges();
            return View("Index");

        }
    }
}
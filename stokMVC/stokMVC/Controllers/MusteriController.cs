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
    }
}
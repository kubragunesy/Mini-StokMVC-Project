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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDbStokEntities db = new MvcDbStokEntities();
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
        public ActionResult YeniSatis(TBLSATISLAR p1)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            db.TBLSATISLAR.Add(p1);
            db.SaveChanges();
            return View("Index");
        }
    }
}
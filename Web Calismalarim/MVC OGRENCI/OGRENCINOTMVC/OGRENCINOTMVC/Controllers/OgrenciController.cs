using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OGRENCINOTMVC.Models.Entity;
namespace OGRENCINOTMVC.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        Db_MVCOKULEntities db = new Db_MVCOKULEntities();
        public ActionResult OgrenciList()
        {
            var getir = db.Tbl_Ogrenci.ToList();
            return View(getir);
        }

        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> liste = (from x in db.Tbl_Kulupler.ToList() select new SelectListItem { Value = x.KULUPID.ToString(), Text = x.KULUPADI }).ToList();
            ViewBag.listele = liste;

            return View();
        }

        [HttpPost]
        public ActionResult YeniOgrenci(Tbl_Ogrenci p)
        {
            var query = db.Tbl_Kulupler.Where(x => x.KULUPID == p.Tbl_Kulupler.KULUPID).FirstOrDefault();
            p.Tbl_Kulupler = query;
            db.Tbl_Ogrenci.Add(p);
            db.SaveChanges();
            return RedirectToAction("OgrenciList");
        }

        public ActionResult O_DELETE(int id)
        {
            var query = db.Tbl_Ogrenci.Find(id);
            db.Tbl_Ogrenci.Remove(query);
            db.SaveChanges();
            return RedirectToAction("OgrenciList");

        }

        public ActionResult OgrenciGetir(int id, Tbl_Ogrenci p1)
        {
            var x = db.Tbl_Ogrenci.Find(id);
            List<SelectListItem> klpliste = (from y in db.Tbl_Kulupler.ToList() select new SelectListItem { Value = y.KULUPID.ToString(), Text = y.KULUPADI }).ToList();
            ViewBag.kg = klpliste;
            ViewBag.ogrimg = x.OGRFOTO;
            return View("OgrenciGetir", x);
        }

        public ActionResult Guncelle(Tbl_Ogrenci p1)
        {
            var klpgnc = db.Tbl_Kulupler.Where(x => x.KULUPID == p1.Tbl_Kulupler.KULUPID).FirstOrDefault();
            var query = db.Tbl_Ogrenci.Find(p1.OGRENCIID);
            query.OGRAD = p1.OGRAD;
            query.OGRSOYAD = p1.OGRSOYAD;
            query.OGRCINSIYET = p1.OGRCINSIYET;
            query.OGRFOTO = p1.OGRFOTO;
            query.Tbl_Kulupler = klpgnc;
            db.SaveChanges();
            return RedirectToAction("OgrenciList");
        }
    }
}
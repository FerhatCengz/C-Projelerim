using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OGRENCINOTMVC.Models.Entity;
namespace OGRENCINOTMVC.Controllers
{
    public class DerslerController : Controller
    {
        // GET: Dersler
        Db_MVCOKULEntities db = new Db_MVCOKULEntities();
        public ActionResult DersListesi()
        {
            var getir = db.Tbl_Dersler.ToList();
            return View(getir);
        }
        [HttpGet]
        public ActionResult YeniDers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniDers(Tbl_Dersler p1)
        {
            db.Tbl_Dersler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("DersListesi");
        }
        public ActionResult D_Delete(int id)
        {
            var query = db.Tbl_Dersler.Find(id);
            db.Tbl_Dersler.Remove(query);
            db.SaveChanges();
            return RedirectToAction("DersListesi");
        }

        public ActionResult DersGetir(int id)
        {
            var ders = db.Tbl_Dersler.Find(id);
            return View("DersGetir", ders);
        }
        public ActionResult Guncelle(Tbl_Dersler p1)
        {
            var query = db.Tbl_Dersler.Find(p1.DERSID);
            query.DERSAD = p1.DERSAD;
            db.SaveChanges();
            return RedirectToAction("DersListesi");
        }
    }
}
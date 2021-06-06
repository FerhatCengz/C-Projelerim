using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OGRENCINOTMVC.Models.Entity;
namespace OGRENCINOTMVC.Controllers
{
    public class KulupController : Controller
    {
        // GET: Kulup
        Db_MVCOKULEntities db = new Db_MVCOKULEntities();
        public ActionResult KulupList()
        {
            var getir = db.Tbl_Kulupler.ToList();
            return View(getir);
        }

        [HttpPost]
        public ActionResult KulupEkle(Tbl_Kulupler p1)
        {
            db.Tbl_Kulupler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("KulupList");

        }

        [HttpGet]
        public ActionResult KulupEkle()
        {
            return View();
        }



        public ActionResult K_Delete(int id)
        {
            var query = db.Tbl_Kulupler.Find(id);
            db.Tbl_Kulupler.Remove(query);
            db.SaveChanges();


            return RedirectToAction("KulupList");
        }

        public ActionResult K_Update(int id)
        {
            var klp = db.Tbl_Kulupler.Find(id);
            return View("K_Update", klp);
        }


        public ActionResult Guncelle(Tbl_Kulupler p1)
        {
            var query = db.Tbl_Kulupler.Find(p1.KULUPID);
            query.KULUPADI = p1.KULUPADI;
            query.KULUPKONTENJAN = p1.KULUPKONTENJAN;
            db.SaveChanges();
            return RedirectToAction("KulupList");
        }



    }
}
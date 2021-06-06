using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OGRENCINOTMVC.Models.Entity;
using OGRENCINOTMVC.Models;
using PagedList;
using PagedList.Mvc;
namespace OGRENCINOTMVC.Controllers
{
    public class NotListesiController : Controller
    {
        // GET: NotListesi
        Db_MVCOKULEntities db = new Db_MVCOKULEntities();
        public ActionResult NotListesi(int sayfa = 1)
        {
            //var getir = db.Tbl_Notlar.ToList();
            var getir = db.Tbl_Notlar.ToList().ToPagedList(sayfa, 8);
            return View(getir);
        }



        [HttpPost]
        public ActionResult YeniSinav(Tbl_Notlar p, byte s = 0, byte s2 = 0, byte s3 = 0, byte s4 = 0)
        {
            bool durum;
            decimal sonuc = (s + s2 + s3 + s4) / 4;
            if (sonuc >= 50)
            {
                ViewBag.snc = sonuc;
                durum = ViewBag.gct = true;

            }
            else
            {
                ViewBag.snc = sonuc;
                durum = ViewBag.gct = false;

            }

            var query = db.Tbl_Dersler.Where(x => x.DERSID == p.Tbl_Dersler.DERSID).FirstOrDefault();
            var query2 = db.Tbl_Ogrenci.Where(x => x.OGRENCIID == p.Tbl_Ogrenci.OGRENCIID).FirstOrDefault();
            p.Tbl_Dersler = query;
            p.Tbl_Ogrenci = query2;
            p.SINAV1 = s;
            p.SINAV2 = s2;
            p.SINAV3 = s3;
            p.PROJE = s4;
            p.ORTALAMA = sonuc;
            p.DURUM = durum;
            db.Tbl_Notlar.Add(p);
            db.SaveChanges();

            return RedirectToAction("YeniSinav");
        }


        [HttpGet]
        public ActionResult YeniSinav()
        {
            List<SelectListItem> lstdersler = (from x in db.Tbl_Dersler.ToList() select new SelectListItem { Text = x.DERSAD.ToString(), Value = x.DERSID.ToString() }).ToList();
            ViewBag.derslistele = lstdersler;
            List<SelectListItem> lstogrenci = (from x in db.Tbl_Ogrenci.ToList() select new SelectListItem { Text = x.OGRAD + " " + x.OGRSOYAD, Value = x.OGRENCIID.ToString() }).ToList();
            ViewBag.ogrencilistele = lstogrenci;
            return View();
        }

        [HttpGet]
        public ActionResult NotGetir(int id)
        {
            List<SelectListItem> lstdersler = (from x in db.Tbl_Dersler.ToList() select new SelectListItem { Text = x.DERSAD.ToString(), Value = x.DERSID.ToString() }).ToList();
            ViewBag.qwer = lstdersler;

            var query = db.Tbl_Notlar.Find(id);
            string adsoyad = query.Tbl_Ogrenci.OGRAD + " " + query.Tbl_Ogrenci.OGRSOYAD;
            ViewBag.adsy = adsoyad;
            return View("Notgetir", query);
        }

        [HttpPost]
        public ActionResult NotGetir(Tbl_Notlar p, Sonuc snc, byte SINAV1 = 0, byte SINAV2 = 0, byte SINAV3 = 0, byte PROJE = 0)
        {

            decimal Orrtalm = (SINAV1 + SINAV2 + SINAV3 + PROJE) / 4;


            if (snc.islem == "GUNCELLE")
            {
                if (Orrtalm >= 50)
                {
                    p.DURUM = true;
                    ViewBag.drm = p.DURUM;
                }
                else
                {
                    p.DURUM = false;
                    ViewBag.drm = p.DURUM;

                }

                var list = db.Tbl_Dersler.Where(x => x.DERSID == p.Tbl_Dersler.DERSID).FirstOrDefault();

                var query = db.Tbl_Notlar.Find(p.NOTID);
                query.SINAV1 = p.SINAV1;
                query.SINAV2 = p.SINAV2;
                query.SINAV3 = p.SINAV3;
                query.PROJE = p.PROJE;
                query.ORTALAMA = (SINAV1 + SINAV2 + SINAV3 + PROJE) / 4;
                query.DURUM = p.DURUM;
                query.Tbl_Dersler = list;
                db.SaveChanges();



                return RedirectToAction("NotListesi");

            }
            return View();




        }


    }
}
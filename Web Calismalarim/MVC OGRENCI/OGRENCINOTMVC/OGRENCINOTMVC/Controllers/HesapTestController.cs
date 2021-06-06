using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OGRENCINOTMVC.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0
            )
        {
            double topla = sayi1 + sayi2;
            double carp = sayi1 * sayi2;
            double bol = sayi1 / sayi2;
            double cikar = sayi1 - sayi2;

            ViewBag.t = topla;
            ViewBag.crp = carp;
            ViewBag.b = bol;
            ViewBag.c = cikar;
            return View();
        }
    }
}
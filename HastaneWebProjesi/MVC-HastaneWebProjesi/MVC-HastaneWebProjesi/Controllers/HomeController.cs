using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HastaneWebProjesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Baslik = "Ana Sayfa";
            ViewBag.AnaSayfa = "active";
            return View();
        }
        public ActionResult İletisim()
        {
            ViewBag.Baslik = "İletişim Sayfası";
            ViewBag.İletisim = "active";
            return View();
        }

        public ActionResult Hakkimizda()
        {
            ViewBag.Baslik = "Hakkimizda Sayfası";
            ViewBag.Hakkimizda = "active";
            return View();
        }
        public ActionResult Servis()
        {
            ViewBag.Baslik = "Servis Sayfası";
            ViewBag.Servis = "active";  
            return View();  
        }
        public ActionResult Fiyatlandirma()
        {
            ViewBag.Baslik = "Fiyatlandirma Sayfası";
            ViewBag.Fiyatlandirma = "active";
            return View() ; 
        }
    }
}
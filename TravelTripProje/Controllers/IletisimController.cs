using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c=new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim p)
        {
            c.iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Adres() 
        { 
            var a=c.AdresBlogs.ToList();
            return PartialView(a);
        }
        

    }
}
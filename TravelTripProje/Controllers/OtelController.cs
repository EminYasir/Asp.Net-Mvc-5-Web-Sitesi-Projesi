using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class OtelController : Controller
    {
        // GET: Otel
        Context c=new Context();
        OtelYorum oy=new OtelYorum();
        public ActionResult Index()
        {
            var dgr=c.Otels.ToList();
            return View(dgr);
        }

        public ActionResult OtelDetails(int id) 
        {
            oy.Deger1 = c.Otels.Where(x => x.Id == id).ToList();
            oy.Deger2 = c.OtelYorumlars.Where(x => x.Otelid == id).ToList();
            return View(oy);
        }
        [HttpGet]
        public PartialViewResult OtelYorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult OtelYorumYap(OtelYorumlar y)
        {
            c.OtelYorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public ActionResult BesYildizOtels()
        {
            oy.Deger3 = c.Otels.Where(x => x.Yildiz==5).ToList();
            return PartialView(oy);
        }

        public ActionResult SonOtelYorums()
        {
            var yrms = c.OtelYorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(yrms);
        }
    }
}
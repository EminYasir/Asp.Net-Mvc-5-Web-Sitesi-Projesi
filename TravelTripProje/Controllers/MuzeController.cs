using System;
using System.Collections.Generic;
using System.Linq;
using TravelTripProje.Models.Siniflar;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers
{
    public class MuzeController : Controller
    {
        // GET: Muze
        Context c =new Context();
        MuzeYorum my=new MuzeYorum();
        public ActionResult Index()
        {
            var dgr = c.Muzes.ToList();
            return View(dgr);
        }
        public ActionResult MuzeDetails(int id)
        {
            my.Deger1 = c.Muzes.Where(x => x.Id == id).ToList();
            my.Deger2 = c.MuzeYorumlars.Where(x => x.Muzeid == id).ToList();
            return View(my);
        }
        [HttpGet]
        public PartialViewResult MuzeYorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MuzeYorumYap(MuzeYorumlar y)
        {
            c.MuzeYorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public ActionResult EnCokZiyaretMuze()
        {
            my.Deger3 = c.Muzes.OrderByDescending(x => x.ZiyaretSayisi).Take(5).ToList();
            return PartialView(my);
        }
        public ActionResult SonMuzeYorums()
        {
            var yrms = c.MuzeYorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(yrms);
        }
    }
}
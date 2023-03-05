using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c=new Context();    
        public ActionResult Index()
        {
            var degerler=c.Blogs.Take(5).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1() 
        {
            var dgr = c.Blogs.OrderBy(x=>x.ID).Take(4).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial2() 
        {
            var deg = c.Blogs.Take(10).ToList();
            return PartialView(deg);
        }
        public PartialViewResult Partial3()
        {
            var deg = c.Blogs.OrderBy(x => x.ID).Take(4).ToList();
            return PartialView(deg);
        }
        public PartialViewResult Partial4()
        {
            var deg = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(deg);
        }
    }
}
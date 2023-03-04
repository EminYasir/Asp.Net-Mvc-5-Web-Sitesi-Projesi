
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c=new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            var bilgi=c.Admins.FirstOrDefault(x=>x.Kullanici==adm.Kullanici && x.Sifre==adm.Sifre);
            if(bilgi!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.Kullanici,false);
                Session["Kullaniciadi"]=bilgi.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else {
                return View();
            }
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","GirisYap");
        }
    }
}
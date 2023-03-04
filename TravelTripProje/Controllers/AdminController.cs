using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c= new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger=c.Blogs.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniBlog() //Sayfa güncelleme yaparsa diye
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)//buda dolunca buton kullanarak kayıt etme
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSilme(int id)
        {
            var b=c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir",b);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var a = c.Blogs.Find(b.ID);
            a.Aciklama = b.Aciklama;
            a.Tarih=b.Tarih;
            a.BlogImage=b.BlogImage;
            a.Baslik=b.Baslik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //Blok Yorum Kontrol
        public ActionResult YorumlarıListele()
        {
            var yorums = c.Yorumlars.ToList();
            return View(yorums);
        }
        public ActionResult YorumSilme(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(yrm);
            c.SaveChanges();
            return RedirectToAction("YorumlarıListele");
        }
        public ActionResult YorumGetir(int id)
        {
            var b = c.Yorumlars.Find(id);
            return View("YorumGetir", b);
        }
        public ActionResult YorumGuncelle(Yorumlar yrm)
        {
            var a = c.Yorumlars.Find(yrm.ID);
            a.ID = yrm.ID;
            a.Kullaniciadi= yrm.Kullaniciadi;
            a.Yorum=yrm.Yorum;
            a.Blogid=yrm.Blogid;
            c.SaveChanges();
            return RedirectToAction("YorumlarıListele");
        }
        //İletişim Sayfası Mail Kontrol
        public ActionResult MailListele()
        {
            var mails = c.iletisims.ToList();
            return View(mails);
        }
        public ActionResult MailSilme(int id)
        {
            var mail = c.iletisims.Find(id);
            c.iletisims.Remove(mail);
            c.SaveChanges();
            return RedirectToAction("MailListele");
        }

        //Admin yönetici Kontrol
        public ActionResult YoneticiListele()
        {
            var adm = c.Admins.ToList();
            return View(adm);
        }
        public ActionResult YoneticiSilme(int id)
        {
            var adm = c.Admins.Find(id);
            c.Admins.Remove(adm);
            c.SaveChanges();
            return RedirectToAction("YoneticiListele");
        }
        [HttpGet]
        public ActionResult YoneticiEkle() //Sayfa güncelleme yaparsa diye
        {
            return View();
        }
        [HttpPost]
        public ActionResult YoneticiEkle(Admin a)//buda dolunca buton kullanarak kayıt etme
        {
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("YoneticiListele");
        }
        public ActionResult YoneticiGetir(int id)
        {
            var b = c.Admins.Find(id);
            return View("YoneticiGetir", b);
        }
        public ActionResult YoneticiGuncelle(Admin a) //Sayfa güncelleme yaparsa diye
        {
            var y=c.Admins.Find(a.ID);
            y.ID= a.ID;
            y.Kullanici= a.Kullanici;
            y.Sifre= a.Sifre;
            c.SaveChanges();
            return RedirectToAction("YoneticiListele");
        }

        //İletişim Sayfasında ki Adres Kısmı Kontrol
        public ActionResult AdresListele()
        {
            var adrs = c.AdresBlogs.ToList();
            return View(adrs);
        }
        public ActionResult AdresGetir(int id)
        {
            var b = c.AdresBlogs.Find(id);
            return View("AdresGetir", b);
        }
        public ActionResult AdresGuncelle(AdresBlog a)
        {
            var adres=c.AdresBlogs.Find(a.ID);
            adres.ID= a.ID;
            adres.AdresAcik = a.AdresAcik;
            adres.Telefon=a.Telefon;
            adres.Baslik=a.Baslik;
            adres.Aciklama=a.Aciklama;
            adres.Mail=a.Mail;
            adres.Konum=a.Konum;
            c.SaveChanges();
            return RedirectToAction("AdresListele");
        }

        //Otel Kontrol
        public ActionResult OtelListele()
        {
            var otels=c.Otels.ToList();
            return View(otels);
        }
        [HttpGet]
        public ActionResult YeniOtelEkle() //Sayfa güncelleme yaparsa diye
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOtelEkle(Otel o)//buda dolunca buton kullanarak kayıt etme
        {
            c.Otels.Add(o);
            c.SaveChanges();
            return RedirectToAction("OtelListele");
        }
        public ActionResult OtelSilme(int id)
        {
            var o = c.Otels.Find(id);
            c.Otels.Remove(o);
            c.SaveChanges();
            return RedirectToAction("OtelListele");
        }
        public ActionResult OtelGetir(int id)
        {
            var b = c.Otels.Find(id);
            return View("OtelGetir", b);
        }
        public ActionResult OtelGuncelle(Otel o)
        {
            var a = c.Otels.Find(o.Id);
            a.Aciklama = o.Aciklama;
            a.Yildiz = o.Yildiz;
            a.Otelimage = o.Otelimage;
            a.Baslik = o.Baslik;
            a.imageDetails1= o.imageDetails1;
            a.imageDetails2= o.imageDetails2;
            a.imageDetails3= o.imageDetails3;
            a.imageDetails4= o.imageDetails4;
            a.imageDetails5= o.imageDetails5;
            c.SaveChanges();
            return RedirectToAction("OtelListele");
        }

        //Otel Yorumları Kontrol
        public ActionResult OtelYorumlarıListele()
        {
            var yorums = c.OtelYorumlars.ToList();
            return View(yorums);
        }
        public ActionResult OtelYorumSilme(int id)
        {
            var yrm = c.OtelYorumlars.Find(id);
            c.OtelYorumlars.Remove(yrm);
            c.SaveChanges();
            return RedirectToAction("OtelYorumlarıListele");
        }
        public ActionResult OtelYorumGetir(int id)
        {
            var b = c.OtelYorumlars.Find(id);
            return View("OtelYorumGetir", b);
        }
        public ActionResult OtelYorumGuncelle(OtelYorumlar yrm)
        {
            var a = c.OtelYorumlars.Find(yrm.ID);
            a.ID = yrm.ID;
            a.Kullaniciadi = yrm.Kullaniciadi;
            a.Yorum = yrm.Yorum;
            a.Otelid = yrm.Otelid;
            c.SaveChanges();
            return RedirectToAction("OtelYorumlarıListele");
        }
        //Müze Kontrol
        public ActionResult MuzeListele()
        {
            var muzes = c.Muzes.ToList();
            return View(muzes);
        }
        [HttpGet]
        public ActionResult YeniMuzeEkle() //Sayfa güncelleme yaparsa diye
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMuzeEkle(Muze m)//buda dolunca buton kullanarak kayıt etme
        {
            c.Muzes.Add(m);
            c.SaveChanges();
            return RedirectToAction("MuzeListele");
        }
        public ActionResult MuzeSilme(int id)
        {
            var m = c.Muzes.Find(id);
            c.Muzes.Remove(m);
            c.SaveChanges();
            return RedirectToAction("MuzeListele");
        }
        public ActionResult MuzeGetir(int id)
        {
            var b = c.Muzes.Find(id);
            return View("MuzeGetir", b);
        }
        public ActionResult MuzeGuncelle(Muze m)
        {
            var a = c.Muzes.Find(m.Id);
            a.Aciklama = m.Aciklama;
            a.ZiyaretSayisi = m.ZiyaretSayisi;
            a.Baslik = m.Baslik;
            a.imageDetails1 = m.imageDetails1;
            a.imageDetails2 = m.imageDetails2;
            a.imageDetails3 = m.imageDetails3;
            a.imageDetails4 = m.imageDetails4;
            a.imageDetails5 = m.imageDetails5;
            a.imageDetails6 = m.imageDetails6;
            c.SaveChanges();
            return RedirectToAction("MuzeListele");
        }
        //Müze Yorum Kontrol
        public ActionResult MuzeYorumlarıListele()
        {
            var yorums = c.MuzeYorumlars.ToList();
            return View(yorums);
        }
        public ActionResult MuzeYorumSilme(int id)
        {
            var yrm = c.MuzeYorumlars.Find(id);
            c.MuzeYorumlars.Remove(yrm);
            c.SaveChanges();
            return RedirectToAction("MuzeYorumlarıListele");
        }
        public ActionResult MuzeYorumGetir(int id)
        {
            var b = c.MuzeYorumlars.Find(id);
            return View("MuzeYorumGetir", b);
        }
        public ActionResult MuzeYorumGuncelle(MuzeYorumlar yrm)
        {
            var a = c.MuzeYorumlars.Find(yrm.ID);
            a.ID = yrm.ID;
            a.Kullaniciadi = yrm.Kullaniciadi;
            a.Yorum = yrm.Yorum;
            a.Muzeid = yrm.Muzeid;
            c.SaveChanges();
            return RedirectToAction("MuzeYorumlarıListele");
        }

        // Hakkımızda Kontrol
        public ActionResult Hakkimizda() 
        {
            var hak=c.Hakkimizdas.ToList();
            return View(hak);

        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var b = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", b);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var yeni = c.Hakkimizdas.Find(h.ID);
            yeni.ID = h.ID;
            yeni.FotoUrl = h.FotoUrl;
            yeni.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
    }
}
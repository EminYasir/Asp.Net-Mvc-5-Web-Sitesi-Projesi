using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Muze
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public int ZiyaretSayisi { get; set; }
        public double GirisFiyat { get; set; }
        public string imageDetails1 { get; set; }
        public string imageDetails2 { get; set; }
        public string imageDetails3 { get; set; }
        public string imageDetails4 { get; set; }
        public string imageDetails5 { get; set; }
        public string imageDetails6 { get; set; }
    }
}
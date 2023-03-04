using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Models.Siniflar
{
    public class MuzeYorumlar
    {
        [Key]
        public int ID { get; set; }
        public string Kullaniciadi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Muzeid { get; set; }
        public virtual Muze Otel { get; set; }
    }
}
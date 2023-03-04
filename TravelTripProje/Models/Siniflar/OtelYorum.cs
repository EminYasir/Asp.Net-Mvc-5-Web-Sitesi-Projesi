using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Models.Siniflar
{
    public class OtelYorum
    {
        public IEnumerable<Otel> Deger1 { get; set; }
        public IEnumerable<OtelYorumlar> Deger2 { get; set; }
        public IEnumerable<Otel> Deger3 { get; set; }
    }
}
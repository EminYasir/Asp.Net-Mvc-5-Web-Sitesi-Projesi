using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Models.Siniflar
{
    public class MuzeYorum
    {
        public IEnumerable<Muze> Deger1 { get; set; }
        public IEnumerable<MuzeYorumlar> Deger2 { get; set; }
        public IEnumerable<Muze> Deger3 { get; set; }
    }
}
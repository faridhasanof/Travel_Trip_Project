using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Mekan
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public string sekil { get; set; }
        public string yazi { get; set; }
    }
}
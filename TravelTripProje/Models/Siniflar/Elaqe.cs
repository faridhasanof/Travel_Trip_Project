using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Elaqe
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(30),MinLength(3)]
        public string ad { get; set; }
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required,MaxLength(30)]
        public string nomre { get; set; }
        [MaxLength(30)]
        public string mesaj { get; set; }
    }
}
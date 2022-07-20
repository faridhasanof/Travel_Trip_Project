using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class MekanController : Controller
    {
        // GET: Mekan
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Mekans.ToList();
            return View(deger);
          
        }
    }
}
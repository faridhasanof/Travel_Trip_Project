using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class ElaqeController : Controller
    {
        //// GET: Elaqe

        //private readonly Context db;
        //public ElaqeController(Context _db)
        //{
        //    db = _db;
        //}
        //public ActionResult Index()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(Elaqe contact)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    db.Elaqes.Add(contact);
        //    db.SaveChanges();
        //    return View();
        //}
        Context c = new Context();
       
       public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Elaqe contact)
        {
            c.Elaqes.Add(contact);
            c.SaveChanges();
            return View();
        }
    }
}
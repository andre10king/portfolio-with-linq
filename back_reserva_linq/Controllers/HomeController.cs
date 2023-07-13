using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using back_reserva_linq.Models;
using Newtonsoft.Json;

namespace back_reserva_linq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public string GetReservaandres()

        {
            using (Models.Aviatur70Entities db = new Models.Aviatur70Entities())
            {


                IEnumerable<Models.Reservaandres> lst =
                    from r in db.Reservaandres.Where(x => x.origen.Contains("panama") || x.origen.Contains("rio de janeiro")).ToList()
                    select r;


                foreach (var oElement in lst)
                {


                    Console.WriteLine(oElement.nombre + oElement.categoria + "\t\t\t" + oElement.origen);
                }

                return JsonConvert.SerializeObject(lst);

            }
        }
    }
}

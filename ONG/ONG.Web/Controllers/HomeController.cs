using ONG.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var beneficiosBL = new BeneficiosBL();
            var listadeBeneficios = beneficiosBL.ObtenerBeneficios();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];


            return View(listadeBeneficios);
        }
    }
}

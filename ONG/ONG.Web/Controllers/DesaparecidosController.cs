using ONG.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG.Web.Controllers
{
    public class DesaparecidosController : Controller
    {
       
        // GET: Desaparecidos
        public ActionResult Index()
        {
            var _desaparecidosBL = new DesaparecidosBL();
            var listadeDesaparecidos = _desaparecidosBL.ObtenerDesaparecidosActivos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeDesaparecidos);
    
        }
    }
}
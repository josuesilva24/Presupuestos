using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class CargasSocialesController : Controller
    {
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        // GET: CargasSociales
        public ActionResult Index()
        {
            return View();
        }

        
              public JsonResult getCargasSociales()
        {
            return new JsonResult() { Data = Channel.GetAllCargasSociales(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
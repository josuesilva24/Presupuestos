using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;

namespace Presupuesto.Controllers
{
    public class CentroCostoController : Controller
    {
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();
        // GET: CentroCosto
        public ActionResult Index()
        {
            return View();
        }

        JsonResult getCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto() , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        
        JsonResult updateCentroCosto()
        {
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
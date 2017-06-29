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

        public ActionResult ProyectoCentroCosto()
        {
            return View();
        }


      public  JsonResult getCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto() , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        
   public JsonResult updateCentroCosto(string IdBD, string Estado)
        {
            return new JsonResult() { Data = Channel.updateCentroCosto(Convert.ToInt32(IdBD), Convert.ToBoolean(Estado)) , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult getProyectosCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getProyectosCentrosCosto(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
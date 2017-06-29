using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class InflacionesController : Controller
    {
        // GET: Inflaciones
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getInflaciones()
        {
            return new JsonResult() { Data = Channel.getInflaciones() , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult updateInflacion(string IdBD, string anno, string PrimerSemestre, string SegundoSemestre)
        {
            if(IdBD.Equals("jqg1"))
            return new JsonResult() { Data = Channel.AddInflaciones(Convert.ToInt32(anno), PrimerSemestre, SegundoSemestre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            return new JsonResult() { Data = Channel.UpdateInflaciones( Convert.ToInt32(IdBD), PrimerSemestre, SegundoSemestre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }



    }
}
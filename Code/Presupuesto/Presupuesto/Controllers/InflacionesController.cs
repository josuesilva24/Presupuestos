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
            if (string.IsNullOrEmpty(IdBD))
            {
                return new JsonResult() { Data = Channel.AddInflaciones(int.Parse(anno), PrimerSemestre, SegundoSemestre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            return new JsonResult() { Data = Channel.UpdateInflaciones(int.Parse(IdBD), PrimerSemestre, SegundoSemestre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult getInflacionesPorAnno(string anno)
        {
            int annoAux = int.Parse(anno);
            return new JsonResult() { Data = Channel.getInflaciones().Where(e=>e.Anno== annoAux), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}
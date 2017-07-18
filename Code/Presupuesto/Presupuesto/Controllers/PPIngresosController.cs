using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class PPIngresosController : Controller
    {
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        // GET: PPIngresos
        public ActionResult Index(string tipo)
        {
            ViewBag.tipo = tipo.Equals("PS")?"Presupuesto":"Proyeccion";
            return View();
        }

        public JsonResult getProyeccionIngreso()
        {
            return new JsonResult() { Data = "" /*Channel.getMoneda(anno)*/, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult getCuentaContable()
        {
            return new JsonResult() { Data = Channel.getCuentaContable(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult getCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class PPGastosController : Controller
    {
        // GET: PPGastos
        public ActionResult Index(string tipo)
        {
            ViewBag.tipo = tipo.Equals("PS") ? "Presupuesto" : "Proyeccion";
            return View();
        }

        public JsonResult getProyeccionGastos()
        {
            return new JsonResult() { Data = "" /*Channel.getMoneda(anno)*/, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class MonedaController : Controller
    {
        // GET: Moneda
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getMoneda()
        {
            return new JsonResult() { Data =Channel.GetMoneda(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult getMonedaActiva()
        {
            return new JsonResult() { Data = Channel.GetMoneda().Where(e => e.Activo == true), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult updateMoneda(string IdBD, string Estado, string Descripcion, string Nombre)
        {
           if (IdBD.Contains("jqg"))
                return new JsonResult() { Data = Channel.AddMoneda(Nombre, Descripcion,Convert.ToBoolean(Estado)) , JsonRequestBehavior = JsonRequestBehavior.AllowGet };
               return new JsonResult() { Data = Channel.UpdateMonedaById(int.Parse(IdBD), Nombre, Descripcion, bool.Parse(Estado)), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}
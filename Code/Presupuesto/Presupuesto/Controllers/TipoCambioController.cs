using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class TipoCambioController : Controller
    {
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();
        // GET: TipoCambio
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getTipoCambio(string anno)
        {
            return new JsonResult() { Data = Channel.GetAllTipoCambio(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        //public JsonResult updateTipoCambio(string IdBD, string tipo, string Enero, string Febrero, string Marzo, string Abril, string Mayo, string Junio, string Julio, string Agosto, string Septiembre, string Octubre, string Noviembre, string Diciembre)
        //{

        //    if (IdBD.Equals("jqg1"))
        //        return new JsonResult() { Data = Channel.AddTipoCambio(0, 1, "Enero", Enero, tipo) };
                    
        //            Febrero,  Marzo,  Abril,  Mayo,  Junio,  Julio,  Agosto,  Septiembre,  Octubre,  Noviembre,  Diciembre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //        return new JsonResult() { Data =Channel(int.Parse(IdBD), tipo, Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre),JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        //}
    }
}
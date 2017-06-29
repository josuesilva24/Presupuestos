using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class TipoCambioController : Controller
    {
        // GET: TipoCambio
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getTipoCambio(string anno)
        {
            return new JsonResult() { Data ="" /*Channel.getMoneda(anno)*/, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult updateMoneda(string IdBD, string tipo, string Enero, string Febrero, string Marzo, string Abril, string Mayo, string Junio, string Julio, string Agosto, string Septiembre, string Octubre, string Noviembre, string Diciembre)
        {
            if (IdBD.Equals("jqg1"))
                return new JsonResult() { Data ="",/* Channel.AddMoneda( tipo,  Enero,  Febrero,  Marzo,  Abril,  Mayo,  Junio,  Julio,  Agosto,  Septiembre,  Octubre,  Noviembre,  Diciembre*/ JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                return new JsonResult() { Data ="", /*Channel.updateMoneda(Convert.ToInt32(IdBD), tipo, Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre*/ JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}
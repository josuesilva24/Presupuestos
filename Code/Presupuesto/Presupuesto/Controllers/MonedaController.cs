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
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getMoneda()
        {
            return new JsonResult() { Data ="",/* Channel.getMoneda()*/ JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult updateMoneda(string IdBD, string Estado, string Descripcion, string Codigo)
        {
            if (IdBD.Equals("jqg1"))
                return new JsonResult() { Data ="",/* Channel.AddMoneda(Estado, Codigo, Descripcion*/ JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            return new JsonResult() { Data ="",/* Channel.updateMoneda(Convert.ToInt32(IdBD), Codigo, Descripcion*/ JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }


    }
}
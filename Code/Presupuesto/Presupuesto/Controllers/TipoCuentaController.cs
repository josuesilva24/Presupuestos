using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class TipoCuentaController : Controller
    {
        // GET: TipoCuenta
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getCuentaContable()
        {
            return new JsonResult() { Data = Channel.getCuentaContable(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult updateCuentaContable(string IdBD, string TipoCuenta)
        {
            return new JsonResult() { Data = Channel.updateCuetaContable(Convert.ToInt32(IdBD),Convert.ToInt32(TipoCuenta)), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        
    }
}
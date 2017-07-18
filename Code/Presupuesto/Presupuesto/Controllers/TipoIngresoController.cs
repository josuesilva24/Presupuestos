using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presupuesto.Controllers
{
    public class TipoIngresoController : Controller
    {
        // GET: TipoIngreso
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();

        public ActionResult Index()
        {
            return View();
        }

    }
}
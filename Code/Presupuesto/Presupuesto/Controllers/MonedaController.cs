﻿using System;
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
        public JsonResult updateMoneda(string IdBD, string Estado, string Descripcion, string Nombre)
        {
       //     if (IdBD.Contains("jqg"))
                return new JsonResult() { Data = Channel.AddMoneda(Nombre, Descripcion,Convert.ToBoolean(Estado)) , JsonRequestBehavior = JsonRequestBehavior.AllowGet };
     //      return new JsonResult() { Data = Channel.updateMoneda(Convert.ToInt32(IdBD), Nombre, Descripcion), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }


    }
}
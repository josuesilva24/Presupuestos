using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;

namespace Presupuesto.Controllers
{
    public class CentroCostoController : Controller
    {
        PresupuestoSisWS.Service1Client Channel = new PresupuestoSisWS.Service1Client();
        // GET: CentroCosto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProyectoCentroCosto()
        {
            return View();
        }


      public  JsonResult getCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto() , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult getCentrosCostoForView()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto().Select(x =>  x.Descripcion), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult updateCentroCosto(string IdBD, string Estado)
        {
            return new JsonResult() { Data = Channel.updateCentroCosto(Convert.ToInt32(IdBD), Convert.ToBoolean(Estado)) , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult getProyectosCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getProyectosCentrosCosto(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }


        public JsonResult getProyectosPorCentrosCosto(string codigo)
        {
            return new JsonResult() { Data = Channel.getProyectosCentrosCosto().Where(x=> x.Codigo.Equals(codigo))  , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }



        public JsonResult getCentrosCostoList()
        {
            List<SelectListItem> ListaCentroCosto = new List<SelectListItem>();
            var lista = Channel.getCentrosCosto();
            foreach (var Adu in lista)
            {
                ListaCentroCosto.Add(new SelectListItem { Text = Adu.Descripcion, Value = Adu.Codigo });
            }

            return new JsonResult() { Data = ListaCentroCosto, JsonRequestBehavior = JsonRequestBehavior.AllowGet }; 

        }

        


         public JsonResult updateProyectoCentroCosto(string IdBD, string descripcion,  string Estado, string CentroCosto)

        {
            return new JsonResult() { Data = Channel.UpdateProyectoPorCentroCosto(Convert.ToInt32(IdBD), Convert.ToBoolean(Estado), CentroCosto), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }


    }
}
using Presupuesto.Models;
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

        public JsonResult getProyeccionIngreso(/*string cuentaContable, string CentroCosto, string modeda*/)
        {

            var lista = Channel.GetAllIngresos().Where(e => e.CuentaContable.IdBD == 1 && e.CentroCostos.IdBD == 1).ToList();


            var ListaIngreso = new List<IngresoMap>();
            for (var i = 0; i < lista.Count; i++)
            {
                var item = lista[i];

                var ingreso = new IngresoMap();
                var meses = item.Ano;
                ingreso.Enero = meses.Enero;
                ingreso.Febrero = meses.Febrero;
                ingreso.Marzo = meses.Marzo;
                ingreso.Abril = meses.Abril;
                ingreso.Mayo = meses.Mayo;
                ingreso.Junio = meses.Junio;
                ingreso.Julio = meses.Julio;
                ingreso.Agosto = meses.Agosto;
                ingreso.Septiembre = meses.Septiembre;
                ingreso.Octubre = meses.Octubre;
                ingreso.Noviembre = meses.Noviembre;
                ingreso.Diciembre = meses.Diciembre;
                ingreso.ano = meses.Ano;
                ingreso.Descripcion = item.Descripcion;

                i++;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Marzo = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Abril = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Mayo = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Junio = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Julio = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Agosto = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Septiembre = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Octubre = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Noviembre = meses[0].Valor;

                //i++;
                //item = lista[i];
                //meses = item.Meses.ToList();
                //ingreso.Diciembre = meses[0].Valor;

                ListaIngreso.Add(ingreso);


            }


                return new JsonResult() { Data = ListaIngreso, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult getCuentaContable()
        {
            return new JsonResult() { Data = Channel.getCuentaContable().Where(e=>e.TipoCuenta=="1"), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult getCentrosCosto()
        {
            return new JsonResult() { Data = Channel.getCentrosCosto().Where(e=>e.Estado=="Activo"), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
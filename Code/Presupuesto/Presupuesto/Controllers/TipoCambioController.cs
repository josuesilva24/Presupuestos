using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Presupuesto.Models;

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
        public JsonResult getMoneda()
        {
            return new JsonResult() { Data = Channel.GetMoneda().Where(e=>e.Activo==true), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult getTipoCambio(string anno)
        { 
            var lista = Channel.GetAllTipoCambio().OrderBy(e=>e.Año).ToList();
            var ListaTipoCambio = new List<TipoCambioMap>();
            for (var i = 0; i< lista.Count; i++)
            {
                var item = lista[i];

                var tipoCambio = new TipoCambioMap();
                var meses = item.Meses.ToList();
                tipoCambio.Enero = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Febrero = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Marzo = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Abril = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Mayo = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Junio = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Julio = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Agosto = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Septiembre = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Octubre = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Noviembre = meses[0].Valor;

                i++;
                item = lista[i];
                meses = item.Meses.ToList();
                tipoCambio.Diciembre = meses[0].Valor;

                ListaTipoCambio.Add(tipoCambio);

                
                
               
            }
            return new JsonResult() { Data = ListaTipoCambio, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult updateTipoCambio(string IdBD, string tipo, string moneda, string Enero, string Febrero, string Marzo, string Abril, string Mayo, string Junio, string Julio, string Agosto, string Septiembre, string Octubre, string Noviembre, string Diciembre)
        {
            var meses = new Dictionary<string, decimal>();
            meses.Add("Enero", decimal.Parse(Enero.Replace('.',',')));
            meses.Add("Febrero",decimal.Parse(Febrero.Replace('.', ',')));
            meses.Add("Marzo",decimal.Parse(Marzo.Replace('.', ',')));
            meses.Add("Abril",decimal.Parse(Abril.Replace('.', ',')));
            meses.Add("Mayo",decimal.Parse(Mayo.Replace('.', ',')));
            meses.Add("Junio",decimal.Parse(Junio.Replace('.', ',')));
            meses.Add("Julio",decimal.Parse(Julio.Replace('.', ',')));
            meses.Add("Agosto",decimal.Parse(Agosto.Replace('.', ',')));
            meses.Add("Septiembre",decimal.Parse(Septiembre.Replace('.', ',')));
            meses.Add("Octubre",decimal.Parse(Octubre.Replace('.', ',')));
            meses.Add("Noviembre",decimal.Parse(Noviembre.Replace('.', ',')));
            meses.Add("Diciembre",decimal.Parse(Diciembre.ToDecimal()));
            return new JsonResult() { Data = Channel.AddTipoCambio(0,int.Parse(moneda),2016,meses,tipo) };
            /*
                Febrero,  Marzo,  Abril,  Mayo,  Junio,  Julio,  Agosto,  Septiembre,  Octubre,  Noviembre,  Diciembre), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                return new JsonResult() { Data = Channel(int.Parse(IdBD), tipo, Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre),JsonRequestBehavior = JsonRequestBehavior.AllowGet };
*/
        }
}
public static class StringExtension
    {
        public static string  ToDecimal(this String s)
        {
            return s.Replace('.', ',');
        }
    }

}
using BL;
using ModelMap;
using System;
using System.Collections.Generic;

namespace WS_PresupuestoSis
{
    public class TipoCambioPorcess
    {
        readonly Lazy<Tipo_CambioBL> _tipo_CambioBL = new Lazy<Tipo_CambioBL>(() => new Tipo_CambioBL());
        Tipo_CambioBL Tipo_CambioBL { get { return _tipo_CambioBL.Value; } }

       public  List<TipoCambioMap> GetAllTipoCambio()
        {
            return Tipo_CambioBL.GetAllTipoCambio();
        }

        public bool AddTipoCambio(int Id, int moneda, int ano, string mes, decimal valor, string Tipo_Cambio)
        {
            return Tipo_CambioBL.AddTipoCambio(Id, moneda, ano, mes, valor, Tipo_Cambio);
        }

    }
}
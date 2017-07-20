using BL;
using ModelMap;
using System;
using System.Collections.Generic;

namespace WS_PresupuestoSis
{
    public class IngresosProcess
    {
        readonly Lazy<IngresosBL> _ingresosBL = new Lazy<IngresosBL>(() => new IngresosBL());
        IngresosBL IngresosBL { get { return _ingresosBL.Value; } }

        public List<IngresosMap> GetAllIngresos()
        {
            return IngresosBL.GetAllIngresos();
        }

        public int AddIngresosWithReturnId(int moneda, string descripcion, int ano, decimal enero,
                                decimal febrero, decimal marzo, decimal abril, decimal mayo,
                                decimal junio, decimal julio, decimal agosto, decimal septiembre,
                                decimal octubre, decimal noviembre, decimal diciembre, bool lineal,
                                bool puntual, decimal monto, int idCentroCostos, int iCuentaContable)
        {
            return IngresosBL.AddIngresosWithReturnId(moneda, descripcion, ano, enero, febrero, marzo, abril, mayo, junio, julio, agosto,
                                                      septiembre, octubre, noviembre, diciembre, lineal, puntual, monto, idCentroCostos, iCuentaContable);
        }
    }
}
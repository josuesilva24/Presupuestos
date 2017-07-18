using System;
using LD;
using ModelMap;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class IngresosBL
    {
        readonly Lazy<IngresosLD> _ingresosLD = new Lazy<IngresosLD>(() => new IngresosLD());
        IngresosLD IngresosLD { get { return _ingresosLD.Value; } }

        public bool AddIngresos(int moneda, string descripcion, int ano, decimal enero,
                                decimal febrero, decimal marzo, decimal abril, decimal mayo,
                                decimal junio, decimal julio, decimal agosto, decimal septiembre,
                                decimal octubre, decimal noviembre, decimal diciembre, bool lineal,
                                bool puntual, decimal monto, int idCentroCostos, int iCuentaContable)
        {
           IngresosLD.AddIngresos(moneda, descripcion, ano, enero, febrero, marzo, abril, mayo,
                                 junio, julio, agosto, septiembre, octubre, noviembre, diciembre,
                                 lineal, puntual, monto, idCentroCostos, iCuentaContable);
            return true;
        }

        public List<IngresosMap> GetAllIngresos()
        {
            return IngresosLD.GetAllIngresos();
        }
    }
}

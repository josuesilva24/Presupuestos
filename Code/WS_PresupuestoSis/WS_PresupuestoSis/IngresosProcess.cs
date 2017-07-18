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
    }
}
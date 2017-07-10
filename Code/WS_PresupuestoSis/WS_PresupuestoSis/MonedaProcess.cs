using BL;
using ModelMap;
using System;
using System.Collections.Generic;

namespace WS_PresupuestoSis
{
    public class MonedaProcess
    {
        readonly Lazy<MonedaBL> _monedaBL = new Lazy<MonedaBL>(() => new MonedaBL());
        MonedaBL MonedaBL { get { return _monedaBL.Value; } }

        public List<MonedaMap> GetMoneda()
        {
            return MonedaBL.GetMonedas();
        }

        public bool AddMoneda(string moneda, string descripcion, bool activo)
        {
            return MonedaBL.AddMoneda(moneda, descripcion,activo);
        }

        public bool UpdateMonedaById(int id, string moneda, string descripcion, bool activo)
        {
           return MonedaBL.UpdateMonedaById(id, moneda, descripcion, activo);
        }
    }
}
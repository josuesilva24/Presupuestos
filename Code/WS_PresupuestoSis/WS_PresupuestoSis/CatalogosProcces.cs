using System;
using System.Collections.Generic;
using ModelMap;
using BL;

namespace WS_PresupuestoSis
{
    public class CatalogosProcces
    {
        #region Dependencias
        readonly Lazy<CentroCostosBL> _centroCostosBl = new Lazy<CentroCostosBL>(() => new CentroCostosBL());
        CentroCostosBL CentroCostosBl { get { return _centroCostosBl.Value; } }
        #endregion

        public List<CentroCostosMap> GetCentrosCosto()
        {
            return CentroCostosBl.GetCentroCostos();
        }

    }
}
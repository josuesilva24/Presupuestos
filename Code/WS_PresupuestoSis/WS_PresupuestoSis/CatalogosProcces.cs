using System.Collections.Generic;
using ModelMap;
using BL;

namespace WS_PresupuestoSis
{
    public class CatalogosProcces
    {
        public CentroCostosBL centroCostosBL
        {
            get
            {
                return new CentroCostosBL();
            }
        }
        public List<CentroCostosMap> getCentrosCosto()
        {
             return centroCostosBL.getCentroCostos();
        }

    }
}
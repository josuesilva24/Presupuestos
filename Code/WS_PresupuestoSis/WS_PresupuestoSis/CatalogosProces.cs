using System;
using System.Collections.Generic;
using ModelMap;
using BL;

namespace WS_PresupuestoSis
{
    public class CatalogosProces
    {
        #region Dependencias
        readonly Lazy<CentroCostosBL> _centroCostosBl = new Lazy<CentroCostosBL>(() => new CentroCostosBL());
        CentroCostosBL CentroCostosBl { get { return _centroCostosBl.Value; } }
        #endregion

        public List<CentroCostosMap> GetCentrosCosto()
        {
            return CentroCostosBl.getCentroCostos();
        }


        public bool UpdateCentrocosto(int id, bool estado)
        {
            return CentroCostosBl.updateCentroCosto(id, estado);
        }

        public List<ProyectoCentroCostosMap> GetProyectosCentrosCosto()
        {
            return CentroCostosBl.getProyectoCentroCostos();
        }


        public bool UpdateProyectoPorCentroCosto(int id, bool estado, string codigoCentroCosto)
        {
            return CentroCostosBl.updateProyectosCentrosCosto(id, estado, codigoCentroCosto);
        }

        //public bool AddProyectoPorCentroCosto( bool estado, string codigoCentroCosto)
        //{
        //    return CentroCostosBl.updateCentroCosto(id, estado);
        //}

    }
}
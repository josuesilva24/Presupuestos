using System;
using LD;
using System.Collections.Generic;
using ModelMap;

namespace BL
{
    public class CentroCostosBL:BaseModel
    {

#region Dependencias
        readonly Lazy<CentroCostosLD> _centroCostosLd = new Lazy<CentroCostosLD>(() => new CentroCostosLD());
        CentroCostosLD CentroCostosLd { get { return _centroCostosLd.Value; } }
#endregion
        

        public List<CentroCostosMap> GetCentroCostos()
        {
            var ListaCentroCostos = new List<CentroCostosMap>();
            foreach (var item in CentroCostosLd.getCentrosCosto().ToList())
            {
                ListaCentroCostos.Add
                    (
                        new CentroCostosMap
                        {
                            Descripcion = item.DESCRIPCION
                        }
                    );
            }
            return ListaCentroCostos;
        }

    }
}

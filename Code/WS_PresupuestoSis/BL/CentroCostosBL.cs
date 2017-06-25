using System;
using LD;
using System.Collections.Generic;
using ModelMap;
using System.Linq;

namespace BL
{
    public class CentroCostosBL:BaseModel
    {

#region Dependencias
        readonly Lazy<CentroCostosLD> _centroCostosLd = new Lazy<CentroCostosLD>(() => new CentroCostosLD());
        CentroCostosLD CentroCostosLd { get { return _centroCostosLd.Value; } }
        #endregion


        public List<CentroCostosMap> getCentroCostos()
        {
            var ListaCentroCostos = new List<CentroCostosMap>();
            foreach (var item in CentroCostosLd.getCentrosCosto().ToList())
            {
                ListaCentroCostos.Add
                    (
                        new CentroCostosMap
                        {
                            Id = item.LNGIDCENTROCOSTO,
                            Descripcion = item.STRDESCRIPCION,
                            Codigo = item.STRCODIGO,
                            Estado = item.STRACTIVO
                        }
                        );


            }

            return ListaCentroCostos;
        }


        public bool updateCentroCosto(int id, string estado)
        {
          return  CentroCostosLd.updateCentroCosto(id,estado);

        }


    }
}

using LD;
using System.Collections.Generic;
using ModelMap;
using System.Linq;

namespace BL
{
    public class CentroCostosBL:BaseModel
    {

        public CentroCostosLD _CentroCostos
        {
            get
            {
                return new CentroCostosLD();
            }
        }


        public List<CentroCostosMap> getCentroCostos()
        {
            var ListaCentroCostos = new List<CentroCostosMap>();
            foreach (var item in _CentroCostos.getCentrosCosto().ToList())
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

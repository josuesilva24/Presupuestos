using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EntityModel;

namespace LD
{
    public  class CentroCostosLD:BaseModel
    {
        public IQueryable<CENTRO_COSTO> getCentrosCosto()
        {
            var a= Model.CENTRO_COSTO;
            return a;
        }
    }
}

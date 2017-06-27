using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EntityModel;

namespace LD
{
    public  class CentroCostosLD:BaseModel
    {
        public IQueryable<TBLCENTROCOSTO> getCentrosCosto()
        {
            return Model.TBLCENTROCOSTO;
        }

        public IQueryable<TBLCENTROCOSTO> getCentrosCostoPorId(int id)
        {
            return  Model.TBLCENTROCOSTO.Where(e => e.LNGIDCENTROCOSTO == id);
        }
        public bool updateCentroCosto(int id, string estado)
        {

            var CC = getCentrosCostoPorId(id).FirstOrDefault();

            if (CC != null)
            {
                CC.STRACTIVO = estado;
                Model.SaveChanges();
                return true;
            }

            return false;
        }

         public IQueryable<TBLPROYECTO> getProyectosCentrosCosto()
        {
            return Model.TBLPROYECTO;
        }
        public IQueryable<TBLPROYECTO> getProyectosCentrosCostoPorId(int id)
        {
            return Model.TBLPROYECTO.Where(e => e.LNGIDPROYECTO == id);
        }


    }


}

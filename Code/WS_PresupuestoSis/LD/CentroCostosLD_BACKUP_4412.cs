using System.Linq;
using EntityModel;

namespace LD
{
    public  class CentroCostosLD:BaseModel
    {
        public IQueryable<Centro_Costos> getCentrosCosto()
        {
            return Model.Centro_Costos;
        }

        public IQueryable<Centro_Costos> getCentrosCostoPorId(int id)
        {
            return  Model.Centro_Costos.Where(e => e.Id == id);
        }
        public bool updateCentroCosto(int id, bool estado)
        {

            var CC = getCentrosCostoPorId(id).FirstOrDefault();

            if (CC != null)
            {
                CC.Activo = estado;
                Model.SaveChanges();
                return true;
            }

            return false;
        }

         public IQueryable<PROYECTO> getProyectosCentrosCosto()
        {
            /*
                SELECT	t2.* 
                FROM	TBLPROYECTO pro
                JOIN	TBLPROYECTOCENTRODECOSTO t ON t.LNGIDPROYECTO = pro.LNGIDPROYECTO
                JOIN	TBLCENTROCOSTO t2 ON t2.LNGIDCENTROCOSTO = t.LNGIDCENTROCOSTO
                WHERE	t2.STRACTIVO = 'S'
             */
<<<<<<< HEAD
            // var query = from proy in  Model.TBLPROYECTO
                         //join proyCC in Model.
             return Model.TBLPROYECTO;
=======

            return Model.PROYECTOes;
>>>>>>> josue
        }
        public IQueryable<PROYECTO> getProyectosCentrosCostoPorId(int id)
        {
            return Model.PROYECTOes.Where(e => e.Id == id);
        }


    }


}

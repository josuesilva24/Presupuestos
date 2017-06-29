using System.Linq;
using EntityModel;
using ModelMap;

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

        public IQueryable<ProyectoCentroCostosMap> GetProyectosCentrosCosto()
        {
            return from proye in Model.PROYECTOes
                        join proyCC in Model.Proyecto_Centro_Costos on proye.Id equals proyCC.Id_Proyecto
                        join CC in Model.Centro_Costos on proyCC.Id_Centro_Costos equals CC.Id
                        select new ProyectoCentroCostosMap
                        {
                            IdBD = proye.Id,
                            Codigo  = proye.CODIGO,
                            Estado = proye.ACTIVO,
                            Descripcion = proye.DESCRIPCION,
                            CentroCosto = CC.Descripcion
                        };

        }
        public IQueryable<PROYECTO> getProyectosCentrosCostoPorId(int id)
        {
            return Model.PROYECTOes.Where(e => e.Id == id);
        }


    }


}

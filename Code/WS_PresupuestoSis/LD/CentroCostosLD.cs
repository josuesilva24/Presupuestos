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

        public IQueryable<Proyecto_Centro_Costos> getInflaciones()
        {
            return Model.Proyecto_Centro_Costos;
        }

        public IQueryable<Centro_Costos> getCentrosCostoPorId(int id)
        {
            return Model.Centro_Costos.Where(e => e.Id == id);
        }

        public IQueryable<Centro_Costos> getCentrosCostoPorCodigo(string codigo)
        {
            return Model.Centro_Costos.Where(e => e.Codigo == codigo);
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
        public IQueryable<Proyecto_Centro_Costos> getProyectosCentrosCosto(string codigo)
        {
            return from proyCC in Model.Proyecto_Centro_Costos
                   join proye in Model.PROYECTOes on proyCC.Id_Proyecto equals proye.Id
                   join CC in Model.Centro_Costos on proyCC.Id_Centro_Costos equals CC.Id
                   where proye.CODIGO == codigo
                   select proyCC;                
        }


        public bool updateProyectosCentrosCosto(int id, string descripcion, bool estado, string codigoCentroCosto)
        {

            var CC = getProyectosCentrosCostoPorId(id).FirstOrDefault();

            if (CC != null)
            {
                CC.ACTIVO = estado;
                ////CC.Proyecto_Centro_Costos
                //CC.DESCRIPCION=descripcion;
  
                var proyecto_Centro_Costos = CC.Proyecto_Centro_Costos.FirstOrDefault();
                //var centroCostos = getCentrosCostoPorId(proyecto_Centro_Costos.Id_Centro_Costos).FirstOrDefault();
                proyecto_Centro_Costos.Id_Centro_Costos = getCentrosCostoPorCodigo(codigoCentroCosto).FirstOrDefault().Id;
                Model.SaveChanges();
                return true;
            }

            return false;
        }



        public bool AddProyectosCentrosCosto(string descripcion, bool estado, string codigoCentroCosto)
        {
            PROYECTO Proyecto = new PROYECTO
            {
            CODIGO   = codigoCentroCosto,
            DESCRIPCION= descripcion,
            ACTIVO=estado
            };

            Model.PROYECTOes.Add(Proyecto);
            Model.SaveChanges();

            Proyecto_Centro_Costos PPC = new Proyecto_Centro_Costos
            {
                Id_Centro_Costos = getCentrosCostoPorCodigo(codigoCentroCosto).FirstOrDefault().Id,
                Id_Proyecto = Proyecto.Id
            };

            Model.Proyecto_Centro_Costos.Add(PPC);
            Model.SaveChanges();

            return false;
        }


    }


}

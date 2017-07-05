using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ModelMap;

namespace WS_PresupuestoSis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<CentroCostosMap> getCentrosCosto()
        {
            return new CatalogosProces().GetCentrosCosto();
        }
        public bool updateCentroCosto(int id, bool estado)
        {
            return new CatalogosProces().UpdateCentrocosto(id, estado);
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<ProyectoCentroCostosMap> getProyectosCentrosCosto()
        {
            return new CatalogosProces().GetProyectosCentrosCosto();
        }

        public List<InflacionMap> getInflaciones()
        {
            return new InflacionProcess().GetInflaciones();
        }

        public bool UpdateInflaciones(int id, string semestreI, string semestreII)
        {
            return new InflacionProcess().UdpdateInflacion( id,  semestreI,  semestreII);
        }

        public bool AddInflaciones(int anno, string semestreI, string semestreII)
        {
            return new InflacionProcess().AddInflacion(anno,semestreI,semestreII);
        }

        public bool UpdateProyectoPorCentroCosto(int id, bool estado, string codigoCentroCogosto)
        {
            return new CatalogosProces().UpdateProyectoPorCentroCosto(id,estado,codigoCentroCogosto);
        }
    }
}

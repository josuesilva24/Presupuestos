using ModelMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_PresupuestoSis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region Centro de costo
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
         List<CentroCostosMap> getCentrosCosto();

        [OperationContract]
        bool updateCentroCosto(int id, bool estado);

        [OperationContract]
        List<ProyectoCentroCostosMap> getProyectosCentrosCosto();


        [OperationContract]
        bool UpdateProyectoPorCentroCosto(int id, bool estado, string codigoCentroCogosto);
        [OperationContract]
        bool updateCuetaContable(int id, int tipoCC);

        #endregion
        #region inflacion
        [OperationContract]
        List<InflacionMap> getInflaciones();

        [OperationContract]
        bool UpdateInflaciones(int id, string semestreI, string semestreII);

        [OperationContract]
        bool AddInflaciones(int anno, string semestreI, string semestreII);
        #endregion

        #region MonedaMap
        [OperationContract]
         List<MonedaMap> GetMoneda();

        [OperationContract]
        bool AddMoneda(string moneda, string descripcion, bool activo);
        #endregion
        [OperationContract]
        List<CuentaContableMap> getCuentaContable();
    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

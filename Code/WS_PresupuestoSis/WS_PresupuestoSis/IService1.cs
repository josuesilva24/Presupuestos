using ModelMap;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

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

        #region Moneda
        [OperationContract]
         List<MonedaMap> GetMoneda();

        [OperationContract]
        bool AddMoneda(string moneda, string descripcion, bool activo);

        [OperationContract]
        bool UpdateMonedaById(int id, string moneda, string descripcion, bool activo);
        #endregion

        #region Cuenta Contable
        [OperationContract]
        List<CuentaContableMap> getCuentaContable();
        #endregion

        #region Tipo Cambio
        [OperationContract]
        List<TipoCambioMap> GetAllTipoCambio();
        [OperationContract]
        bool AddTipoCambio(int Id, int moneda, int ano, List<MesMap> meses, string Tipo_Cambio);

        #endregion

        #region Cargas Sociales
         List<CargasSocialesMap> GetAllCargasSociales();
        #endregion


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

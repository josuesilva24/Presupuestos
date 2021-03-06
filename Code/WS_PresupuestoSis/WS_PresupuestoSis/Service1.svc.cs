﻿using System;
using System.Collections.Generic;
using ModelMap;

namespace WS_PresupuestoSis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region Service Methods
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

        #endregion

        #region Centro Costos
        public List<CentroCostosMap> getCentrosCosto()
        {
            return new CatalogosProces().GetCentrosCosto();
        }
        public bool updateCentroCosto(int id, bool estado)
        {
            return new CatalogosProces().UpdateCentrocosto(id, estado);
        }
        public List<ProyectoCentroCostosMap> getProyectosCentrosCosto()
        {
            return new CatalogosProces().GetProyectosCentrosCosto();
        }
        public bool UpdateProyectoPorCentroCosto(int id, bool estado, string codigoCentroCogosto)
        {
            return new CatalogosProces().UpdateProyectoPorCentroCosto(id, estado, codigoCentroCogosto);
        }
        #endregion

        #region Inflaciones 
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
        #endregion

        #region Monedas
        public List<MonedaMap> GetMoneda()
        {
            return new MonedaProcess().GetMoneda();
        }
        public bool AddMoneda(string moneda, string descripcion, bool activo)
        {
            return new MonedaProcess().AddMoneda(moneda, descripcion, activo);
        }
        public bool UpdateMonedaById(int id, string moneda, string descripcion, bool activo)
        {
            return new MonedaProcess().UpdateMonedaById(id, moneda, descripcion, activo);
        }

        #endregion

        #region Cuenta Contable
        public List<CuentaContableMap> getCuentaContable()
        {
            return new CuentaContableProces().GetCuentaContable();
        }
        public bool updateCuetaContable(int id, int tipoCC)
        {
            return new CuentaContableProces().updateCuentaContable(id, tipoCC);
        }

        public List<TipoCuentaContableMap> GetTipoCuentaContable()
        {
            return new CuentaContableProces().GetTipoCuentaContable();
        }
        #endregion

        #region Tipo Cambio
        public List<TipoCambioMap> GetAllTipoCambio()
        {
            return new TipoCambioPorcess().GetAllTipoCambio();
        }

        public bool AddTipoCambio(int Id, int moneda, int ano, Dictionary<string,decimal> meses, string Tipo_Cambio)
        {
            return new TipoCambioPorcess().AddTipoCambio(Id, moneda, ano, meses, Tipo_Cambio);
        }
        #endregion

        #region Cargas Sociales
        public List<CargasSocialesMap> GetAllCargasSociales()
        {
            return new CargasSocialesProcess().GetAllCargasSociales();
        }
        #endregion

        #region Ingresos
        public List<IngresosMap> GetAllIngresos()
        {
            return new IngresosProcess().GetAllIngresos();
        }

        public int AddIngresosWithReturnId(int moneda, string descripcion, int ano, decimal enero,
                                decimal febrero, decimal marzo, decimal abril, decimal mayo,
                                decimal junio, decimal julio, decimal agosto, decimal septiembre,
                                decimal octubre, decimal noviembre, decimal diciembre, bool lineal,
                                bool puntual, decimal monto, int idCentroCostos, int iCuentaContable)
        {

           return new IngresosProcess().AddIngresosWithReturnId(moneda, descripcion, ano, enero, febrero, marzo, abril, mayo, junio, julio, agosto, 
                                                                septiembre, octubre, noviembre, diciembre, lineal, puntual, monto, idCentroCostos, iCuentaContable);
        }
        #endregion
    }
}

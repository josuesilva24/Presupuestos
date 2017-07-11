using BL;
using ModelMap;
using System;
using System.Collections.Generic;

namespace WS_PresupuestoSis
{
    public class CargasSocialesProcess
    {

        #region Dependencias
        readonly Lazy<CargasSocialesBL> cargasSocialesBL = new Lazy<CargasSocialesBL>(() => new CargasSocialesBL());
        CargasSocialesBL CargasSocialesBL { get { return cargasSocialesBL.Value; } }
        #endregion


        public List<CargasSocialesMap> GetAllCargasSociales()
        {
            return CargasSocialesBL.GetAllCargasSociales();

        }
    }
}
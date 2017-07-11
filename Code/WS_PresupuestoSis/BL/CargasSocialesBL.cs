using System;
using LD;
using System.Collections.Generic;
using ModelMap;
using System.Linq;

namespace BL
{
    public class CargasSocialesBL
    {
        #region Dependencias
        readonly Lazy<CargasSocialesLD> cargasSocialesLD = new Lazy<CargasSocialesLD>(() => new CargasSocialesLD());
        CargasSocialesLD CargasSocialesLD { get { return cargasSocialesLD.Value; } }
        #endregion

        public List<CargasSocialesMap> GetAllCargasSociales()
        {
            var ListaCargasSociales = new List<CargasSocialesMap>();

            foreach (var item in CargasSocialesLD.GetAllCargasSociales().ToList())
            {
                ListaCargasSociales.Add
                    (
                        new CargasSocialesMap
                        {
                            CuentaContable = item.Cuenta_Contable.Descripcion,
                            Id = item.Id,
                            Porcentaje = item.Porcentaje
                        }
                    );


            }
            return ListaCargasSociales;
        }

    }
}

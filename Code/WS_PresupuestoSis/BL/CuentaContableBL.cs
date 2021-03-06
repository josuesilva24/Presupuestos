﻿using EntityModel;
using LD;
using ModelMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CuentaContableBL:BaseModel
    {

        #region Dependencias
        readonly Lazy<CuentaContableLD> _cuentacontableLd = new Lazy<CuentaContableLD>(() => new CuentaContableLD());
        CuentaContableLD CuentaContableLD { get { return _cuentacontableLd.Value; } }
        #endregion

        public List<CuentaContableMap> GetCuentaContable()
        {

            var ListaCuantasContables = new List<CuentaContableMap>();
            var tipocuenta = CuentaContableLD.getTipoCuenta();
            foreach (var item in CuentaContableLD.getCuentaContable().ToList())
            {
                ListaCuantasContables.Add
                    (
                        new CuentaContableMap
                        {
                            IdBD = item.Id,
                            Descripcion = item.Descripcion,
                            TipoCuenta = item.TipoCuenta.HasValue? item.Tipo_CuentaContable.TipoCC:"No Tiene Relacion",
                            Codigo= item.Cuenta_Contable1
                        }
                        );


            }

            return ListaCuantasContables;

        }

        public bool updateCuentaContable(int id, int tipoCC)
        {
            return CuentaContableLD.updateCuentaContable(id, tipoCC);

        }

        public List<TipoCuentaContableMap> GetTipoCuentaContable()
        {
            var ListTipoCuentaContable = new List<TipoCuentaContableMap>();
            var TipoCuentaContable = CuentaContableLD.getTipoCuenta().ToList();

            foreach (var item in TipoCuentaContable)
            {
                ListTipoCuentaContable.Add
                    (
                        new TipoCuentaContableMap
                        {
                            Id = item.Id,
                            Descripcion = item.TipoCC
                        }
                    );
            }
            return ListTipoCuentaContable;

        }
    }
}

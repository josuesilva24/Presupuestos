﻿using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL;
using ModelMap;

namespace WS_PresupuestoSis
{
    public class CuentaContableProces
    {
        #region Dependencias
        readonly Lazy<CuentaContableBL> _cuentacontableLd = new Lazy<CuentaContableBL>(() => new CuentaContableBL());
        CuentaContableBL CuentaContableBL { get { return _cuentacontableLd.Value; } }
        #endregion

        public List<CuentaContableMap> GetCuentaContable()
        {
            return CuentaContableBL.GetCuentaContable();
        }
        public bool updateCuentaContable(int id, int tipoCC)
        {
            return CuentaContableBL.updateCuentaContable(id, tipoCC);
        }

    }
}
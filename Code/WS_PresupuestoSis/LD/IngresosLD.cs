using System;
using EntityModel;
using System.Linq;
using ModelMap;
using System.Collections.Generic;

namespace LD
{
    public class IngresosLD:BaseModel
    {
        #region Dependencias

        readonly Lazy<MonedaLD> _MonedaLD = new Lazy<MonedaLD>(() => new MonedaLD());
        MonedaLD MonedaLD { get { return _MonedaLD.Value; } }

        readonly Lazy<AnosLD> _AnosLD = new Lazy<AnosLD>(() => new AnosLD());
        AnosLD AnosLD { get { return _AnosLD.Value; } }

        #endregion

        public IQueryable<Ingresos> AddIngresos(int  moneda, string descripcion, int ano, decimal enero, 
                                decimal febrero, decimal marzo, decimal abril, decimal mayo, 
                                decimal junio, decimal julio, decimal agosto, decimal septiembre, 
                                decimal octubre, decimal noviembre, decimal diciembre, bool lineal, 
                                bool puntual, decimal monto, int idCentroCostos, int iCuentaContable)
        {
            var IdMoneda = MonedaLD.GetIdMonedas(moneda);
            var IdAno = AnosLD.AddAnosWithreturnId(ano, enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre);

            var ingreso =  Model.Ingresos.Add(new Ingresos {
                Id_Anos = IdAno,
                 Descripcion = descripcion,
                 Id_Tipo_Moneda = IdMoneda,
                 Lineal = lineal,
                 Puntual = puntual,
                 Monto = monto,
                 Id_Centro_Costos = idCentroCostos,
                 Id_Cuenta_Contable = iCuentaContable
            });
            return ingreso as IQueryable<Ingresos>;
        }

        public List<IngresosMap> GetAllIngresos()
        {
            var query = from ingreso in Model.Ingresos
                        join cContable in Model.Cuenta_Contable on ingreso.Id_Cuenta_Contable equals cContable.Id
                        join cCostos in Model.Centro_Costos on ingreso.Id_Centro_Costos equals cCostos.Id
                        join moneda in Model.Moneda on ingreso.Id_Tipo_Moneda equals moneda.Id
                        join ano in Model.Anos on ingreso.Id_Anos equals ano.Id
                        select new IngresosMap
                        {
                            Id = ingreso.Id,
                            Descripcion = ingreso.Descripcion,
                            Lineal = ingreso.Lineal,
                            Puntual = ingreso.Puntual,
                            Monto = ingreso.Monto.Value,
                            Ano = new AnosMap
                            {
                                Id = ingreso.Anos.Id,
                                Ano = ingreso.Anos.Ano,
                                Enero = ingreso.Anos.Enero.Value,
                                Febrero = ingreso.Anos.Febrero.Value,
                                Marzo = ingreso.Anos.Marzo.Value,
                                Abril = ingreso.Anos.Abril.Value,
                                Mayo = ingreso.Anos.Mayo.Value,
                                Junio = ingreso.Anos.Junio.Value,
                                Julio = ingreso.Anos.Julio.Value,
                                Agosto = ingreso.Anos.Agosto.Value,
                                Septiembre = ingreso.Anos.Septiembre.Value,
                                Octubre = ingreso.Anos.Octubre.Value,
                                Noviembre = ingreso.Anos.Noviembre.Value,
                                Diciembre = ingreso.Anos.Diciembre.Value
                            },
                            Moneda = new MonedaMap
                            {
                                id = ingreso.Moneda.Id,
                                Activo = ingreso.Moneda.Activo.Value,
                                Descripcion = ingreso.Moneda.Descripcion,
                                Nombre = ingreso.Moneda.Descripcion
                            },
                            CentroCostos = new CentroCostosMap
                            {
                                IdBD = ingreso.Centro_Costos.Id,
                                Codigo = ingreso.Centro_Costos.Codigo,
                                Descripcion = ingreso.Centro_Costos.Descripcion,
                                Estado = ingreso.Centro_Costos.Activo.ToString()
                            },
                            CuentaContable = new CuentaContableMap
                            {
                                IdBD = ingreso.Cuenta_Contable.Id,
                                Codigo = ingreso.Cuenta_Contable.Cuenta_Contable1,
                                Descripcion = ingreso.Cuenta_Contable.Descripcion,
                                TipoCuenta = ingreso.Cuenta_Contable.TipoCuenta.ToString()
                            }

                        };
            return query.ToList();

        }

    }
}

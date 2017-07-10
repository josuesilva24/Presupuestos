using LD;
using ModelMap;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BL
{
    public class Tipo_CambioBL
    {
        readonly Lazy<TipoCambioLD> _tipoCambioLD = new Lazy<TipoCambioLD>(() => new TipoCambioLD());
        TipoCambioLD TipoCambioLD { get { return _tipoCambioLD.Value; } }

        public List<TipoCambioMap> GetAllTipoCambio()
        {
            var tiposCambio = TipoCambioLD.GetAllTipoCambio().ToList();
            var ListaTiposCambios = new List<TipoCambioMap>();

            foreach (var item in tiposCambio)
            {
                ListaTiposCambios.Add
                    (
                        new TipoCambioMap
                        {
                            Año = item.Ano,
                            Codigo = item.Moneda.Descripcion,
                            Id = item.Id,
                            Mes = item.Mes,
                            Moneda = item.Moneda.Descripcion,
                            Valor = item.Valor.Value
                        }
                    );
            };
            return ListaTiposCambios;
        }

        public bool AddTipoCambio(int Id, int moneda, int ano, string mes, decimal valor, string Tipo_Cambio)
        {
            return TipoCambioLD.AddTipoCambio(Id, moneda, ano, mes, valor, Tipo_Cambio);
        }
    }
}

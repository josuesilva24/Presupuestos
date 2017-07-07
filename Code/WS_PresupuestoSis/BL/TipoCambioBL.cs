using System;
using LD;
using ModelMap;
using System.Collections.Generic;
using System.Linq;
namespace BL
{
    public class TipoCambioBL
    {
        readonly Lazy<TipoCambioLD> _tipoCambioLD = new Lazy<TipoCambioLD>(() => new TipoCambioLD());
        TipoCambioLD TipoCambioLD { get { return _tipoCambioLD.Value; } }

        public List<TipoCambioMap> GetAllTipoCambio()
        {
            var tiposCambios = TipoCambioLD.GetAllTipoCambio().ToList();
            var ListaTipoCambios = new List<TipoCambioMap>();

            foreach (var item in tiposCambios)
            {
                ListaTipoCambios.Add
                    (new TipoCambioMap
                        {
                            Id = item.Id,
                            Mes = item.Mes,
                            Año = item.Ano,
                            Valor = item.Valor,
                            Codigo = item.Moneda.Descripcion,
                            Moneda = item.Moneda.Moneda1
                        }
                    );
            }
            return ListaTipoCambios;
        }
    }
}

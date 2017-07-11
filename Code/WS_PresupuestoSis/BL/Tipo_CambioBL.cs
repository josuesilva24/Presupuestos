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
                var meses = new List<MesMap>
                {
                    new MesMap
                    {
                        Mes = item.Mes,
                        Valor = item.Valor.Value
                    }
                };
                ListaTiposCambios.Add
                    (
                        new TipoCambioMap
                        {
                            Año = item.Ano,
                            Codigo = item.Moneda.Descripcion,
                            Id = item.Id,
                            Meses = meses
                        }
                    );
            };
            return ListaTiposCambios;
        }

        public bool AddTipoCambio(int Id, int moneda, int ano, Dictionary<string, decimal> Meses, string Tipo_Cambio)
        {
            return TipoCambioLD.AddTipoCambio(Id, moneda, ano, Meses, Tipo_Cambio);
        }
    }
}

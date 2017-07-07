using LD;
using ModelMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MonedaBL
    {

        readonly Lazy<MonedaLD> _MonedaLD = new Lazy<MonedaLD>(() => new MonedaLD());
        MonedaLD MonedaLD { get { return _MonedaLD.Value; } }

        public List<MonedaMap> GetMonedas()
        {
            var monedas =  MonedaLD.GetMonedas();
            var ListaMonedas = new List<MonedaMap>();

            foreach (var item in monedas.ToList())
            {
                ListaMonedas.Add
                    (
                        new MonedaMap
                        {
                            Activo = item.Activo.Value,
                            Descripcion = item.Descripcion,
                            id = item.Id,
                            Nombre = item.Moneda1
                        }
                    );
            }
            return ListaMonedas;
        }

        public bool AddMoneda(string moneda, string descripcion, bool activo)
        {
            return MonedaLD.AddMoneda(moneda, descripcion, activo);
        }
    }
}

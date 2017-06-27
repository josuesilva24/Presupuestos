using System;
using LD;
using ModelMap;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class InflacionBL:BaseModel
    {

        readonly Lazy<InflacionLD> _inflacionld = new Lazy<InflacionLD>(() => new InflacionLD());
        InflacionLD InflacionLd { get { return _inflacionld.Value; } }


        public List<InflacionMap> getInflaciones()
        {
            var ListaInf = new List<InflacionMap>();
            foreach (var item in InflacionLd.getInflaciones().ToList())
            {
                ListaInf.Add
                    (
                        new InflacionMap
                        {
                            IdBD = item.LNGIDINFLACION,
                            Anno = item.STRAÑO,
                            PrimerSemestre = item.STRSEMSTRE_1,
                            SegundoSemestre = item.STRSEMSTRE_2,
                            Fecha = item.DTMFECHA
                        }
                        );
            }

            return ListaInf;
        }

        public bool UdpdateInflacion(int id, string semestreI, string semestreII)
        {
            return InflacionLd.updateInflacion(id, semestreI, semestreII);
        }

        public bool AddInflacion(string anno, string semestreI, string semestreII)
        {
            return InflacionLd.addInflacion(anno, semestreI, semestreII);
        }
    }
}

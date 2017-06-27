using BL;
using ModelMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_PresupuestoSis
{
    public class InflacionProcess
    {
        readonly Lazy<InflacionBL> _inflacionBl = new Lazy<InflacionBL>(() => new InflacionBL());
        InflacionBL  InflacionBL { get { return _inflacionBl.Value; } }

        public List<InflacionMap> GetInflaciones()
        {
            return InflacionBL.getInflaciones();
        }
        public bool UdpdateInflacion(int id, string semestreI, string semestreII)
        {
            return InflacionBL.UdpdateInflacion( id,  semestreI,  semestreII);
        }
        public bool AddInflacion(string anno, string semestreI, string semestreII)
        {
            return InflacionBL.AddInflacion(  anno,  semestreI,  semestreII);
        }

    }
}
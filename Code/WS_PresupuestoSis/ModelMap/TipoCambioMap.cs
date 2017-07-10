using System.Collections.Generic;

namespace ModelMap
{
    public class TipoCambioMap
    {
        public int Id { get; set; }
        public int Año { get; set; }
        public string Moneda { get; set; }
        public List<MesMap> Meses  { get; set; }
        public string Codigo { get; set; }
    }
}

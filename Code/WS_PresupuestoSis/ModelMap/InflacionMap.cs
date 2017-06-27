using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMap
{
 public   class InflacionMap
    {
        public int IdBD { get; set; }
        public string Anno { get; set; }
        public string PrimerSemestre { get; set; }
        public string SegundoSemestre { get; set; }
        public DateTime? Fecha { get; set; }
    }
}

using System.Linq;
using EntityModel;
namespace LD
{
    public class InflacionLD:BaseModel
    {
        public IQueryable<TBLINFLACION> getInflaciones()
        {
            return Model.TBLINFLACION;
        }

        public IQueryable<TBLINFLACION> getInflacionPorId(int id)
        {
            return Model.TBLINFLACION.Where(e => e.LNGIDINFLACION == id);
        }
        public bool updateInflacion(int id, string semestreI, string semestreII)
        {

            TBLINFLACION Inflacion = getInflacionPorId(id).FirstOrDefault();

            if (Inflacion != null)
            {
                Inflacion.STRSEMSTRE_1 = semestreI;
                Inflacion.STRSEMSTRE_2 = semestreII;
                Model.SaveChanges();
                return true;
            }

            return false;
        }

        public bool addInflacion( string anno, string semestreI, string semestreII)
        {
            var inflaciones= getInflaciones().Where(e=>e.STRAÑO.Equals(anno)).FirstOrDefault();
            if (inflaciones == null)
            {
                TBLINFLACION inf = new TBLINFLACION();
                inf.STRAÑO = anno;
                inf.STRSEMSTRE_1 = semestreI;
                inf.STRSEMSTRE_2 = semestreII;
                inf.DTMFECHA = System.DateTime.Today;
                Model.TBLINFLACION.Add(inf);
                Model.SaveChanges();
                return true;
            }
            return false;
         
        }
    }
}

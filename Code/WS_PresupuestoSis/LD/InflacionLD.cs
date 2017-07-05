using System.Linq;
using EntityModel;
namespace LD
{
    public class InflacionLD:BaseModel
    {
        public IQueryable<Inflacion> getInflaciones()
        {
            return Model.Inflacions;
        }

        public IQueryable<Inflacion> getInflacionPorId(int id)
        {
            return Model.Inflacions.Where(e => e.Id == id);
        }
        public bool updateInflacion(int id, string semestreI, string semestreII)
        {

            Inflacion Inflacion = getInflacionPorId(id).FirstOrDefault();

            if (Inflacion != null)
            {
                Inflacion.Semetre_1 = semestreI;
                Inflacion.Semestre_2 = semestreII;
                Model.SaveChanges();
                return true;
            }

            return false;
        }

        public bool addInflacion( int anno, string semestreI, string semestreII)
        {
            var inflaciones= getInflaciones().Where(e=>e.Ano==anno).FirstOrDefault();
            if (inflaciones == null)
            {
                var inf = new Inflacion();
                inf.Ano = anno;
                inf.Semetre_1 = semestreI;
                inf.Semestre_2 = semestreII;
                inf.Fecha = System.DateTime.Today;
                Model.Inflacions.Add(inf);
                Model.SaveChanges();
                return true;
            }
            return false;
         
        }
    }
}

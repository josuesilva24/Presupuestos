using EntityModel;
using System.Linq;

namespace LD
{
    public class MonedaLD: BaseModel {

        public IQueryable<Moneda> GetMonedas()
        {
           return Model.Moneda;
        }
        public bool AddMoneda(string moneda, string descripcion, bool activo)
        {
            Model.Moneda.Add(new Moneda
            {
                Activo = activo,
                Descripcion = descripcion,
                Moneda1 = moneda
            });
            Model.SaveChanges();
            return true;
        }
        public int GetIdMonedas(int IdMoneda)
        {
            return GetMonedas().Where(x => x.Id.Equals(IdMoneda)).FirstOrDefault().Id;
        }
        public bool UpdateMonedaById(int id, string moneda, string descripcion, bool activo)
        {
            var Moneda = GetMonedas().Where(x => x.Id.Equals(id)).FirstOrDefault();

            if (Model == null) return false;

                Moneda.Descripcion = descripcion;
                Moneda.Activo = activo;
                Moneda.Moneda1 = moneda;
                Model.SaveChanges();
                return true;

            
        }
    }
}

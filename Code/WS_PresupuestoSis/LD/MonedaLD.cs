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
    }
}

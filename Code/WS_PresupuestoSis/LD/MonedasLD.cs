using EntityModel;
using System.Linq;

namespace LD
{
    public class MonedasLD:BaseModel
    {
        public IQueryable<TBLMONEDA> getMonedas()
        {
            return Model.TBLMONEDA;
        }
    }
}

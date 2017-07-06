using System.Linq;
using EntityModel;
namespace LD
{
    public class TipoCambioLD:BaseModel
    {
        public IQueryable<Tipo_Cambio> GetAllTipoCambio()
        {
            return 
                    from    tipoCambio in Model.Tipo_Cambio
                    join    moneda in Model.Monedas on tipoCambio.Id_Moneda equals moneda.Id
                    select  tipoCambio;
        }
    }
}

using System.Linq;
using EntityModel;


namespace LD
{
    public class CargasSocialesLD:BaseModel
    {
        public IQueryable<Cargas_Sociales> GetAllCargasSociales()
        {
            return from cargasSociales in Model.Cargas_Sociales
                   join cuentaContable in Model.Cuenta_Contable on cargasSociales.Id_Cuenta_Contable equals cuentaContable.Id
                   select cargasSociales;
        }
    }
}

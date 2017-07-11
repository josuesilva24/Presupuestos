using EntityModel;
using System.Linq;

namespace LD
{
    public   class CuentaContableLD:BaseModel
    {
        public IQueryable<Cuenta_Contable> getCuentaContable()
        {
            return Model.Cuenta_Contable;
        }
        public IQueryable<Cuenta_Contable> getCuentaContablePorid(int id)
        {
            return Model.Cuenta_Contable.Where(e=>e.Id==id);
        }
        public IQueryable<Tipo_CuentaContable> getTipoCuenta()
        {
            return Model.Tipo_CuentaContable;
        }
        public bool updateCuentaContable(int id, int tipoCC)
        {

            var CC = getCuentaContablePorid(id).FirstOrDefault();

            if (CC != null)
            {
                CC.TipoCuenta = tipoCC;
                Model.SaveChanges();
                return true;
            }

            return false;
        }

    }
}

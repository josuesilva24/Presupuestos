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
                    join    moneda in Model.Moneda on tipoCambio.Id_Moneda equals moneda.Id
                    select  tipoCambio;
        }
        public bool AddTipoCambio(int Id, int moneda, int ano, string mes, decimal valor, string  Tipo_Cambio)
        {
            var tipoCambio = GetAllTipoCambio().Where(x => x.Id.Equals(Id));
            var IdMoneda = 1;
            var Id_Tipo_Tipo_Cambio = 1;
            if (tipoCambio == null) return false;

            Model.Tipo_Cambio.Add(
                    new Tipo_Cambio
                    {
                        Ano = ano,
                        Id_Moneda = IdMoneda,
                        Mes = mes,
                        Valor = valor,
                        Id_Tipo_Tipo_Cambio = Id_Tipo_Tipo_Cambio
                    }
                );
            Model.SaveChanges();
            return true;
        }
    }
}

using EntityModel;
using System.Linq;
namespace LD
{
    public class AnosLD:BaseModel
    {
        public int AddAnosWithreturnId(int ano, decimal enero, decimal febrero, decimal marzo,
                                        decimal abril, decimal mayo, decimal junio, decimal julio,
                                        decimal agosto, decimal septiembre,decimal octubre, decimal noviembre, decimal diciembre)
        {
           var AnosId = Model.Anos.Add
                (
                    new Anos
                    {
                        Ano = ano,
                        Enero = enero,
                        Febrero = febrero,
                        Marzo = marzo,
                        Abril = abril,
                        Mayo = mayo,
                        Junio = junio,
                        Julio = julio,
                        Agosto = agosto,
                        Septiembre = septiembre,
                        Octubre = octubre,
                        Noviembre = noviembre,
                        Diciembre = diciembre
                    }
                );
            Model.SaveChanges();
            return AnosId.Id;
        }
    }
}

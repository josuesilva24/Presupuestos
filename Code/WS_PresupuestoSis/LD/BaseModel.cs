using EntityModel;

namespace LD
{
    public class BaseModel
    {
        private PRESUPUESTOEntities _dataContext;
        protected PRESUPUESTOEntities Model
        {
            get
            {
                if (_dataContext == null)
                    _dataContext = new PRESUPUESTOEntities();
                return _dataContext;
            }
            set
            {
                _dataContext = value;
            }
        }
    }
}
//mae dejalo asi luego lo vemos xq ya tengo que trabajar jajaja tranquilo yo confio en vos.
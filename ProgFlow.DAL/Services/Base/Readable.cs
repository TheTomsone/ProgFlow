using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Readable<TModel> : BaseService<TModel>, IReadable<TModel> where TModel : class
    {
        public IEnumerable<TModel> GetAll()
        {
            throw new NotImplementedException();
        }
        public TModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public TModel Map(IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}

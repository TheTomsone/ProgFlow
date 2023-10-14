using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Interfaces.Base
{
    public interface IReadable<TModel> : IBaseService<TModel> where TModel : class
    {
        TModel Map(IDataReader reader);
        TModel GetById(int id);
        IEnumerable<TModel> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Interfaces.Base
{
    public interface IModifiable<TModel> : IReadable<TModel> where TModel : class
    {
        bool Update(TModel model);
        bool Delete(int id);
    }
}

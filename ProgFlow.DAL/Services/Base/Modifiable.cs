using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Modifiable<TModel> : Readable<TModel>, IModifiable<TModel> where TModel : class
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public bool Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}

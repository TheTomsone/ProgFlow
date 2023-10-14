using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Creatable<TModel> : Modifiable<TModel>, ICreatable<TModel> where TModel : class
    {
        public bool Create(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}

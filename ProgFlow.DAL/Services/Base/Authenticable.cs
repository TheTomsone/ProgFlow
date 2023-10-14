using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Authenticable<TModel> : Modifiable<TModel>, IAuthenticable<TModel> where TModel : class
    {
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
        public bool Register(string username, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}

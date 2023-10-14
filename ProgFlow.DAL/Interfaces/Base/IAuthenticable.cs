using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Interfaces.Base
{
    public interface IAuthenticable<TModel> : IModifiable<TModel> where TModel : class
    {
        bool Register(string username, string email, string password);
        bool Login(string username, string password);
    }
}

using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Base;
using ProgFlow.DAL.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Authenticable : Modifiable<User>, IAuthenticable
    {
        public Authenticable(IConfiguration config) : base(config)
        {
        }

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

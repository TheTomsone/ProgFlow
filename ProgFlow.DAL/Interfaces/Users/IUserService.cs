using ProgFlow.DAL.Interfaces.Base;
using ProgFlow.DAL.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Interfaces.Users
{
    public interface IUserService : IAuthenticable<User>
    {
    }
}

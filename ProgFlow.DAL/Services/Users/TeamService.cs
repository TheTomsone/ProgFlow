using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Users;
using ProgFlow.DAL.Models.Users;
using ProgFlow.DAL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Users
{
    public class TeamService : Creatable<Team>, ITeamService
    {
        public TeamService(IConfiguration config) : base(config)
        {
        }
    }
}

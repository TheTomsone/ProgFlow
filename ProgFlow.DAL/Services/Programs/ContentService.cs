using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Programs;
using ProgFlow.DAL.Models.Programs;
using ProgFlow.DAL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Programs
{
    public class ContentService : Creatable<Content>, IContentService
    {
        public ContentService(IConfiguration config) : base(config)
        {
        }
    }
}

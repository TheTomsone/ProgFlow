﻿using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces;
using ProgFlow.DAL.Models;
using ProgFlow.DAL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services
{
    public class DataService : Creatable<Data>, IDataService
    {
        public DataService(IConfiguration config) : base(config)
        {
        }
    }
}

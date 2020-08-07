using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class Service_Analyze : Repository<Service_Analyzes>, IService_Analyze
    {
        public Service_Analyze(DB db) : base(db)
        {
        }
    }
}

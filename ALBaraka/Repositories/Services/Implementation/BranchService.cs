using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class BranchService : Repository<Branch>, IBranchService
    {
        public BranchService(DB db) : base(db)
        {
        }
    }
}

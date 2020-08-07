using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class ServiceService : Repository<Service>, IServiceService
    {
        public ServiceService(DB db) : base(db)
        {
        }

        public Service GetServiceInclude(int ID)
        {
            return db.Set<Service>().Include(service => service.Comments).Include(service=>service.Service_Analyzes).FirstOrDefault(service => service.ID == ID);
        }
    }
}

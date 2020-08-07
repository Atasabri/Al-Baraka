using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class SubscriperService : Repository<Subscriber> , ISubscriberService
    {
        public SubscriperService(DB db) : base(db)
        {
        }
    }
}

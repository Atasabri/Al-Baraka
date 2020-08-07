using ALBaraka.Repositories.Email;
using ALBaraka.Repositories.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.UnitOfWork
{
   public interface IUnitOfWork
    {
        IServiceService Services { get; }
        IBranchService Branchs { get; }
        ICommentService Comments { get; }
        IImageService Images { get; }
        IContactService Contacts { get;}
        ISubscriberService Subscripers { get; }
        IService_Analyze Service_Analyze { get; }

        IEmail Emails { get; }

        void Save();

    }
}

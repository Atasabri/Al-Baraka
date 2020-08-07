using Microsoft.Extensions.Configuration;
using ALBaraka.Models;
using ALBaraka.Repositories.Email;
using ALBaraka.Repositories.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Repositories.Services.Implementation;

namespace ALBaraka.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DB db;
        private IConfiguration configuration;

        private IServiceService services;
        private IBranchService branches;
        private ICommentService comments;
        private IImageService images;
        private IContactService contacts;
        private ISubscriberService subscripers;
        private IService_Analyze service_Analyze;


        private IEmail emails;

        public UnitOfWork(DB db,IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        public IServiceService Services
        {
            get
            {
                if (services == null)
                {
                    services = new ServiceService(db);
                }
                return services;
            }
        }
        public IBranchService Branchs
        {
            get
            {
                if (branches == null)
                {
                    branches = new BranchService(db);
                }
                return branches;
            }
        }
        public ICommentService Comments
        {
            get
            {
                if (comments == null)
                {
                    comments = new CommentService(db);
                }
                return comments;
            }
        }
        public IImageService Images
        {
            get
            {
                if (images == null)
                {
                    images = new ImageService(db);
                }
                return images;
            }
        }
        public IContactService Contacts
        {
            get
            {
                if (contacts == null)
                {
                    contacts = new ContactService(db);
                }
                return contacts;
            }
        }
        public ISubscriberService Subscripers
        {
            get
            {
                if (subscripers == null)
                {
                    subscripers = new SubscriperService(db);
                }
                return subscripers;
            }
        }
        public IService_Analyze Service_Analyze
        {
            get
            {
                if (service_Analyze == null)
                {
                    service_Analyze = new Service_Analyze(db);
                }
                return service_Analyze;
            }
        }

        public IEmail Emails
        {
            get
            {
                if (emails == null)
                {
                    emails = new Email.Email(configuration);
                }
                return emails;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

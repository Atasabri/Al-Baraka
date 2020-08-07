using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class CommentService : Repository<Comment>, ICommentService
    {
        public CommentService(DB db) : base(db)
        {
        }
    }
}

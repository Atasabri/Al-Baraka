using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.Email
{
    public interface IEmail
    {
        void Send_Mail(string Subject, IFormFile file, List<string> To);
    }
}

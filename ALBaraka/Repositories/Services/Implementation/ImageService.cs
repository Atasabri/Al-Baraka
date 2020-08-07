using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Models;
using ALBaraka.Repositories.Services.Interfaces;

namespace ALBaraka.Repositories.Services.Implementation
{
    public class ImageService : Repository<Image> , IImageService
    {
        public ImageService(DB db) : base(db)
        {
        }
    }
}

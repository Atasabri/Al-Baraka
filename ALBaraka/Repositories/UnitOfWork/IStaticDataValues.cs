using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.UnitOfWork
{
    public interface IStaticDataValues
    {
        string GetValue(string Key, string Lan);
    }
}

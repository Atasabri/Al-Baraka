using ALBaraka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Repositories.UnitOfWork
{
    public class StaticDataValues : IStaticDataValues
    {
        private DB _db;
        List<StaticData> List = new List<StaticData>();
        public StaticDataValues(DB db)
        {
            this._db = db;
            List = _db.StaticData.ToList();
        }
        public string GetValue(string Key,string Lan=null)
        {
            if(Lan=="ar" || Lan==null)
            {
                return List.SingleOrDefault(x => x.Key == Key).Value;
            }
            else
            {
                return List.SingleOrDefault(x => x.Key == Key).Value_EN;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public abstract class StoreBase : IStore
    {
        public virtual void InsertData(string key, int value) { throw new NotImplementedException(); }
        public virtual int RetrieveData(string key) { throw new NotImplementedException(); }
        
        protected bool CheckDataIntegrity(int value)
        {
            return (value >= 0) && (value <= 100);
        }
    }
}

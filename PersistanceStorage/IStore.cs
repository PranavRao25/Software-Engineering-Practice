﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public interface IStore
    {
        public void InsertData(string key, int  value);
        public int RetrieveData(string key);
    }
}

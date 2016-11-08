using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Utility.Session
{
    interface ISessionProvider
    {
        string SessionId { get; }
        void Set(string key,object value);
        object Get(string key);
        TEntity Get<TEntity>(string key) where TEntity : class;
    }
}

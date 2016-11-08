using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BookShop.Utility.Session
{
    class DefaultSessionProvider : ISessionProvider
    {
        public string SessionId
        {
            get
            {
                return HttpContext.Current.Session.SessionID;
            }
        }

        public object Get(string key)
        {
            return HttpContext.Current.Session[key];
        }

        public TEntity Get<TEntity>(string key) where TEntity : class
        {
            return Get(key) as TEntity;
        }

        public void Set(string key, object value)
        {
            HttpContext.Current.Session[key] =value;
        }
    }
}

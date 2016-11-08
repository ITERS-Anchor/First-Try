using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Utility.Session
{
    public static class SessionHelper
    {
        static ISessionProvider provider = null;
        static SessionHelper()
        {
            string config = "mysession";
            switch (config)
            {
                case "mysession":
                    provider = new MySessionProvider();
                    break;
                case "defaultsession":
                    provider = new DefaultSessionProvider();
                    break;
            }      
        }
        public static string SessionId
        {
            get
            {
                return provider.SessionId;
            }
        }

        public static void Set(string key, object value)
        {
            provider.Set(key,value);
        }
        public static object Get(string key)
        {
            return provider.Get(key);
        }
        public static TEntity Get<TEntity>(string key) where TEntity : class
        {
            return provider.Get<TEntity>(key);
        }
    }
}

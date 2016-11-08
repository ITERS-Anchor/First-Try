using BookShop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class MySession
    {
        private static IDictionary<string, IDictionary<string, object>> SessionStorage { get; set; }

        static MySession()
        {
            SessionStorage = new Dictionary<string, IDictionary<string, object>>();
        }

        public static string SessionId
        {
            get
            {
                var res = CookieHelper.Get("Sid");
                if (string .IsNullOrEmpty(res))
                {
                    res = Guid.NewGuid().ToString("N");
                    CookieHelper.Set("Sid",res);
                }
                return res;
            }
        }

        public static void Set(string key,object value)
        {
            IDictionary<string, object> temp = new Dictionary<string, object>();
            if (SessionStorage.ContainsKey(SessionId))
            {//当前session中已经存在
                temp = SessionStorage[SessionId];
                if (temp.ContainsKey(key))
                {
                    temp[key] = value;
                }
                else
                {
                    temp.Add(key,value);
                }
            }
            else
            {//session中 没有当前盒子
                temp.Add(key, value);
                SessionStorage.Add(SessionId,temp);
            }
            
        }
        public static object Get(string key)
        {
            if (!SessionStorage.ContainsKey(SessionId))
            {
                return null;
            }
            //存在的情况下， 先找用户盒子
            IDictionary<string, object> temp = SessionStorage[SessionId];
            if (!temp .ContainsKey(key))
            {
                return null;
            }
            return temp[key];
        }
        public static TEntity Get<TEntity>(string key) where TEntity : class
        {
            return Get(key) as TEntity;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace System.Web
{
    public static class RequestHelper
    {
        /// <summary>
        /// 获取当前Request是否为POST请求,
        /// </summary>
        /// <param name="request">获取当前Request</param>
        /// <returns>true/false</returns>
        /// 扩展方法3要素：静态类，静态方法，this关键字
        public static bool IsPostBack(this HttpRequest request)
        {
            return request.HttpMethod.Equals("post", StringComparison.InvariantCultureIgnoreCase);
        }
        /// <summary>
        /// 获取请求参数中的Int类型值
        /// </summary>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int GetInt(this HttpRequest request, string key, int def = 0)
        {
            int res;
            var temp = request[key];
            if (int.TryParse(temp, out res))
            {
                return res;
            }
            return def;
        }
    }
}

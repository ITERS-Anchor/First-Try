using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC
{
    /// <summary>
    /// Summary description for Index
    /// 单一入口
    /// </summary>
    public class Index1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var controllerName = context.Request["c"];
            IController controller = null;
            ////switch 形式找控制器对象 
            switch (controllerName.ToLower())
            {
                case "home":
                    controller = new HomeController();
                    break;
                case "product":
                    controller = new ProductController();
                    break;
            }
            if (controller == null)
            {
                throw new HttpException(404,"Not Found ");
            }
            controller.Execute(context);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
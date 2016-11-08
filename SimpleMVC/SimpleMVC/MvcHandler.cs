using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC
{
    public class MvcHandler : IHttpHandler
    {
        private Dictionary<string, string> routeValue;

        public MvcHandler(Dictionary<string, string> routeValue)
        {
            this.routeValue = routeValue;
        }

        public bool IsReusable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            //var controllerName = context.Request["c"] ?? string.Empty;
            IController controller = null;
            switch (routeValue["controller"].ToLower())
            {
                case "home":
                    controller = new HomeController();
                    break;
            }
            if (controller == null)
            {
                throw new HttpException(404, "404Error");
            }
            controller.Execute(new RequestContext { Context = context, RouteValues = routeValue });
        }
    }
}
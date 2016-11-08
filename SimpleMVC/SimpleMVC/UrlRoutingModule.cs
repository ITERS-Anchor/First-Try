using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += application_BeginRequest;

        }

        void application_BeginRequest(object sender, EventArgs e)
        {
            //先拿到HttpApplication
            var application = sender as HttpApplication;
            if (application == null)
            {
                return;
            }
            var exePath = application.Request.AppRelativeCurrentExecutionFilePath;
            exePath = exePath.Substring(2);
            //Response.Write(exePath);
            //Response.End();
            var tempArr = exePath.Split('/');
            if (tempArr.Length != 2)
            {
                return;
            }
            var controllerName = tempArr[0];
            var actionName = tempArr[1];
            Dictionary<string, string> routeValue = new Dictionary<string, string> { { "controller", controllerName }, { "action", actionName } };
            application.Context.RemapHandler(new MvcHandler(routeValue));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SimpleMVC
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //var exePath = Request.AppRelativeCurrentExecutionFilePath;
            //exePath = exePath.Substring(2);
            ////Response.Write(exePath);
            ////Response.End();
            //var tempArr = exePath.Split('/');
            //if (tempArr.Length != 2)
            //{
            //    return;
            //}
            //var controllerName = tempArr[0];
            //var actionName = tempArr[1];
            //Dictionary<string, string> routeValue = new Dictionary<string, string> { { "controller", controllerName }, { "action", actionName } };
            //Context.RemapHandler(new MvcHandler(routeValue));
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
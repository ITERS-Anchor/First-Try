using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApp
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
            //Response.Write(Request.Url);
            //Response.End();
            //string url = Request.Url.ToString();
            string url = Request.AppRelativeCurrentExecutionFilePath;//http://localhost:8307/list-2-21-3.aspx
            Regex regex = new Regex(@"~/list-(\d+?)-(\d+?)-(\d+?).aspx");//~/list-2-21-3.aspx
            MatchCollection matches = regex.Matches(url);
            if (matches.Count > 0)
            {
                // 当前URL是伪静态url
                string realPath = regex.Replace(url, "~/list.aspx?page=$1&cat=$2&sort=3");//~/list.aspx?page=2&cat=21&sort=3
                // 指定当前请求执行地址
                Context.RewritePath(realPath);
                //Server.Transfer(relPath);
                //Response.Redirect("~/index.aspx");
            }
            //Response.Write(url);
            //Response.End();
            //Context.RewritePath("~/index.aspx");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //var ex = Server.GetLastError();
            //File.AppendAllText("E://error.txt", ex.Message);
            //Response.Clear();
            //Response.Write("ERROR!");
            //Response.End();
            //if (HttpContext.Current != null)
            //{
            //    var url = HttpContext.Current.Request.Url;
            //    var page = HttpContext.Current.Handler as System.Web.UI.Page;
            //}
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
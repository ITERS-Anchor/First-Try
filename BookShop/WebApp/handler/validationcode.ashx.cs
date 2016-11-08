using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WebApp.handler
{
    /// <summary>
    /// Summary description for validationcode
    /// </summary>
    public class validationcode : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            string vcode = BookShop.Utility.CaptchaHelper.CreateRandomCode(4);
            context.Session["user_vcode"] = vcode;
            byte[] b= BookShop.Utility.CaptchaHelper.DrawImage(vcode,20,Color.White);
            context.Response.ContentType = "image/gif";
            context.Response.BinaryWrite(b);
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
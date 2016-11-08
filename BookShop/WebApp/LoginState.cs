using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class LoginState: BasePage
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            if (Session["LoginUser"] == null)
            {
                //Response.Redirect("/account/login.aspx");                
                //Response.Redirect("/account/login.aspx?redirect="+Request.Url);
                Response.Redirect("/account/login.aspx?redirect=" + HttpUtility.UrlEncode(Request.Url.ToString()));
                //HttpUtility.UrlEncode(Request.Url.ToString())//加密
            }
            
        }
        
        
    }
}
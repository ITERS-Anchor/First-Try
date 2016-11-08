using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class login : System.Web.UI.Page
    {
        public string ErrorMsg { get; set; }
        UsersBLL bll = new UsersBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsPostBack())
            {
                Login();
            }
            else
            {
                //1.check cookie
                if (Request.Cookies["ckName"] != null && Request.Cookies["ckPwd"] != null)
                {
                    string name = Request.Cookies["ckName"].Value;
                    string pwd = Request.Cookies["ckPwd"].Value;

                    Users u = bll.QuerySingle(new {LoginId=name});
                    if (u != null)
                    {
                        //if (Encryption.MD5encryption(u.UserPwd)==pwd)
                        if (u.LoginPwd == pwd)
                        {
                            Session["LoginUser"] = u;
                            Response.Redirect("memberInfo.aspx");
                        }
                    }
                    else
                    {
                        Response.Cookies["ckName"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["ckPwd"].Expires = DateTime.Now.AddDays(-1);
                    }
                }
            }
        }
        public void Login()
        {
            //1.
            string name = Request.Form["username"];
            string pwd = Request.Form["password"];
            string vcode = Request.Form["vcode"];           
            string remember = Request.Form["remember_me"];
            //2.
            if (string .IsNullOrEmpty(name)|| string.IsNullOrEmpty(pwd))
            {
                ErrorMsg = "不能为空";
                return;
            }
            var scode = Session["user_vcode"];
            Session["user_vcode"] = null;
            if (scode==null||!scode.ToString().Equals(vcode,StringComparison.InvariantCultureIgnoreCase))//不分大小写
            {
                ErrorMsg = "验证码错误";
                return;
            }

            //3。
            Users user = null;
            LoginResult res=bll.CheckLogin(name,pwd,out user);
            switch (res)
            {
                case LoginResult.InvalidUserName:
                    ErrorMsg = "Invalid UserName or Pwd";
                    break;
                case LoginResult.InvalidPassword:
                    ErrorMsg = "Invalid UserName or Pwd";
                    break;
                case LoginResult.StateError:
                    ErrorMsg = "State Error";
                    break;
                case LoginResult.LoginSuccessful:
                    if (!string .IsNullOrEmpty(remember))
                    {
                        HttpCookie cookieName = new HttpCookie("ckName")
                        {                            
                            Value=name,
                            Expires=DateTime.Now.AddDays(7),
                        };
                        Response.Cookies.Add(cookieName);
                        HttpCookie cookiePwd = new HttpCookie("ckPwd")
                        {
                            Value = pwd,
                            Expires = DateTime.Now.AddDays(7),
                        };
                        Response.Cookies.Add(cookiePwd);
                    }
                    //Session["LoginUser"] = user;
                    //if (Request["redirect"]!=null)
                    //{
                    //    Response.Redirect(Request["redirect"]);
                    //}
                    
                    //Response.Redirect("/index.aspx");
                    
                    string redirect = Request["redirect"] ?? "/index.aspx?AspxAutoDetectCookieSupport=1";
                    //'??'-->redirect= Request["redirect"] if Request["redirect"] not null, if null go to home page                 
                    Session["LoginUser"] = user;
                    Response.Redirect(redirect);
                   // Response.Redirect("/index.aspx");
                    break;
            }

        }

    }
}
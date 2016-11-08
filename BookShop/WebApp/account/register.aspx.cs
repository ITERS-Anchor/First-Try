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
    public partial class register : System.Web.UI.Page
    {
        public string ErrorMsg { get; set; }
        UsersBLL bll = new UsersBLL();
        protected void Page_Load(object sender, EventArgs e)
        {  //if is post back
            if (Request.IsPostBack())
            {
                //1.采集表单
                string name = Request.Form["username"];
                string pwd = Request.Form["password"];
                string confirm = Request.Form["confirm"];
                string vcode = Request.Form["vcode"];
                string is_checked = Request.Form["is_checked"];
                //2.数据校验
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(vcode) || string.IsNullOrEmpty(is_checked))
                {
                    ErrorMsg = "不能为空";                  
                    //Response.End();
                    return;
                }
                var sCode = Session["user_vcode"];
                Session["user_vcode"] = null;
                if (sCode == null || !sCode.ToString().Equals(vcode, StringComparison.InvariantCultureIgnoreCase))
                {
                    ErrorMsg = "验证码错误";
                    //Response.End();
                    return;
                }
                if (pwd !=confirm)
                {
                    ErrorMsg = "密码不匹配";
                    //Response.End();
                    return;
                }
                //3.调用BLL方法
                int m = bll.Register(name,pwd);
                //4.根据业务结果给出客户端响应
                string msg=string .Empty ;
                switch (m)
                {
                    case 0: msg="ok";
                        Response.Redirect("login.aspx");
                        break;
                    case 1: msg = "exit user";
                        break;
                    case 2: msg = "failed";
                        break;
                }
                ErrorMsg = msg;
                //Response.End();
            }


        }
    }
}
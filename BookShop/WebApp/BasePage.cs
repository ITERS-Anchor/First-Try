using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApp
{
    public class BasePage:Page
    {
        public Users CurrentUser { get; set; }
        //onPreInit第一个事件
        protected override void OnPreInit(EventArgs e)
        {
            CurrentUser = Session["LoginUser"] as Users;
            base.OnPreInit(e);
        }
        protected bool IsSignIn
        {
            get
            {
                return CurrentUser != null;
            }
        }
    }
}
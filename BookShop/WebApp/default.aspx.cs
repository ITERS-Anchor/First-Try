using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShop.BLL;

namespace WebApp
{
    public partial class test : System.Web.UI.Page
    {
        UsersBLL bll = new UsersBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Repeater1.DataSource=bll.QueryList(1,5,new{Id=2},"Id");
            Repeater1.DataBind();

        }
    }
}
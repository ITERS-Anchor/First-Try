using BookShop.Utility.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class sessiontest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = MySession.Get<string>("sname");
            Label1.Text=SessionHelper.Get<string>("sname");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var txt = TextBox1.Text;
            SessionHelper.Set("sname",txt);
        }
    }
}
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using LTP.Common;
namespace BookShop.Web.UserInfoRole
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserInfo_ID.Text))
			{
				strErr+="UserInfo_ID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtRole_ID.Text))
			{
				strErr+="Role_ID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserInfo_ID=int.Parse(this.txtUserInfo_ID.Text);
			int Role_ID=int.Parse(this.txtRole_ID.Text);

			BookShop.Model.UserInfoRole model=new BookShop.Model.UserInfoRole();
			model.UserInfo_ID=UserInfo_ID;
			model.Role_ID=Role_ID;

			BookShop.BLL.UserInfoRoleService bll=new BookShop.BLL.UserInfoRoleService();
			bll.Add(model);

		}

    }
}

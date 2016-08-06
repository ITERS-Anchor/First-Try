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
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(UserInfo_ID,Role_ID);
				}
			}
		}
			
	private void ShowInfo(int UserInfo_ID,int Role_ID)
	{
		BookShop.BLL.UserInfoRoleService bll=new BookShop.BLL.UserInfoRoleService();
		BookShop.Model.UserInfoRole model=bll.GetModel(UserInfo_ID,Role_ID);
		this.lblUserInfo_ID.Text=model.UserInfo_ID.ToString();
		this.lblRole_ID.Text=model.Role_ID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}


			BookShop.Model.UserInfoRole model=new BookShop.Model.UserInfoRole();

			BookShop.BLL.UserInfoRoleService bll=new BookShop.BLL.UserInfoRoleService();
			bll.Update(model);

		}

    }
}

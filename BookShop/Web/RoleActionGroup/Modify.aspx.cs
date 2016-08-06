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
namespace BookShop.Web.RoleActionGroup
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
					//ShowInfo(Role_ID,ActionGroup_ID);
				}
			}
		}
			
	private void ShowInfo(int Role_ID,int ActionGroup_ID)
	{
		BookShop.BLL.RoleActionGroupService bll=new BookShop.BLL.RoleActionGroupService();
		BookShop.Model.RoleActionGroup model=bll.GetModel(Role_ID,ActionGroup_ID);
		this.lblRole_ID.Text=model.Role_ID.ToString();
		this.lblActionGroup_ID.Text=model.ActionGroup_ID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}


			BookShop.Model.RoleActionGroup model=new BookShop.Model.RoleActionGroup();

			BookShop.BLL.RoleActionGroupService bll=new BookShop.BLL.RoleActionGroupService();
			bll.Update(model);

		}

    }
}

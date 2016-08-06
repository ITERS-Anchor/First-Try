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
namespace BookShop.Web.R_UserInfo_ActionInfo
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
					//ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		BookShop.BLL.R_UserInfo_ActionInfoService bll=new BookShop.BLL.R_UserInfo_ActionInfoService();
		BookShop.Model.R_UserInfo_ActionInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtIsPass.Text=model.IsPass.ToString();
		this.txtActionInfoID.Text=model.ActionInfoID.ToString();
		this.txtUserInfoID.Text=model.UserInfoID.ToString();
		this.txtActionInfo_ID.Text=model.ActionInfo_ID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtIsPass.Text))
			{
				strErr+="IsPass不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfoID.Text))
			{
				strErr+="ActionInfoID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserInfoID.Text))
			{
				strErr+="UserInfoID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfo_ID.Text))
			{
				strErr+="ActionInfo_ID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int IsPass=int.Parse(this.txtIsPass.Text);
			int ActionInfoID=int.Parse(this.txtActionInfoID.Text);
			int UserInfoID=int.Parse(this.txtUserInfoID.Text);
			int ActionInfo_ID=int.Parse(this.txtActionInfo_ID.Text);


			BookShop.Model.R_UserInfo_ActionInfo model=new BookShop.Model.R_UserInfo_ActionInfo();
			model.IsPass=IsPass;
			model.ActionInfoID=ActionInfoID;
			model.UserInfoID=UserInfoID;
			model.ActionInfo_ID=ActionInfo_ID;

			BookShop.BLL.R_UserInfo_ActionInfoService bll=new BookShop.BLL.R_UserInfo_ActionInfoService();
			bll.Update(model);

		}

    }
}

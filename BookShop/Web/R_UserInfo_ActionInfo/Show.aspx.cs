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
namespace BookShop.Web.R_UserInfo_ActionInfo
{
    public partial class Show : System.Web.UI.Page
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
		this.lblIsPass.Text=model.IsPass.ToString();
		this.lblActionInfoID.Text=model.ActionInfoID.ToString();
		this.lblUserInfoID.Text=model.UserInfoID.ToString();
		this.lblActionInfo_ID.Text=model.ActionInfo_ID.ToString();

	}


    }
}

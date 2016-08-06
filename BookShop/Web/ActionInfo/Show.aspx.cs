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
namespace BookShop.Web.ActionInfo
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
		BookShop.BLL.ActionInfoService bll=new BookShop.BLL.ActionInfoService();
		BookShop.Model.ActionInfo model=bll.GetModel(ID);
		this.lblActionInfoName.Text=model.ActionInfoName;
		this.lblUrl.Text=model.Url;
		this.lblHttpMethod.Text=model.HttpMethod.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblDelFalg.Text=model.DelFalg.ToString();
		this.lblSubTime.Text=model.SubTime.ToString();
		this.chkIsMenu.Checked=model.IsMenu;
		this.lblR_UserInfo_ActionInfoID.Text=model.R_UserInfo_ActionInfoID.ToString();

	}


    }
}

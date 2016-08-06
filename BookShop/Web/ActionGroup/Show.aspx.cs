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
namespace BookShop.Web.ActionGroup
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
		BookShop.BLL.ActionGroupService bll=new BookShop.BLL.ActionGroupService();
		BookShop.Model.ActionGroup model=bll.GetModel(ID);
		this.lblGroupName.Text=model.GroupName;
		this.lblGroupType.Text=model.GroupType.ToString();
		this.lblDelFlag.Text=model.DelFlag;
		this.lblSort.Text=model.Sort.ToString();

	}


    }
}

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
namespace BookShop.Web.Role
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
		BookShop.BLL.RoleService bll=new BookShop.BLL.RoleService();
		BookShop.Model.Role model=bll.GetModel(ID);
		this.lblRoleName.Text=model.RoleName;
		this.lblDelFlag.Text=model.DelFlag.ToString();
		this.lblRoleType.Text=model.RoleType.ToString();
		this.lblSubTime.Text=model.SubTime.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}

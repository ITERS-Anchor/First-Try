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
namespace BookShop.Web.RoleDepartment
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
					//ShowInfo(Role_ID,Department_ID);
				}
			}
		}
		
	private void ShowInfo(int Role_ID,int Department_ID)
	{
		BookShop.BLL.RoleDepartmentService bll=new BookShop.BLL.RoleDepartmentService();
		BookShop.Model.RoleDepartment model=bll.GetModel(Role_ID,Department_ID);

	}


    }
}

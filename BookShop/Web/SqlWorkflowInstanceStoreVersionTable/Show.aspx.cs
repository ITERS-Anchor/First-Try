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
namespace BookShop.Web.SqlWorkflowInstanceStoreVersionTable
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
					ShowInfo();
				}
			}
		}
		
	private void ShowInfo()
	{
		BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService bll=new BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService();
		BookShop.Model.SqlWorkflowInstanceStoreVersionTable model=bll.GetModel();
		this.lblMajor.Text=model.Major;
		this.lblMinor.Text=model.Minor;
		this.lblBuild.Text=model.Build;
		this.lblRevision.Text=model.Revision;
		this.lblLastUpdated.Text=model.LastUpdated.ToString();

	}


    }
}

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
namespace BookShop.Web.ServiceDeploymentsTable
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
					//ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(long Id)
	{
		BookShop.BLL.ServiceDeploymentsTableService bll=new BookShop.BLL.ServiceDeploymentsTableService();
		BookShop.Model.ServiceDeploymentsTable model=bll.GetModel(Id);
		this.lblServiceDeploymentHash.Text=model.ServiceDeploymentHash;
		this.lblSiteName.Text=model.SiteName;
		this.lblRelativeServicePath.Text=model.RelativeServicePath;
		this.lblRelativeApplicationPath.Text=model.RelativeApplicationPath;
		this.lblServiceName.Text=model.ServiceName;
		this.lblServiceNamespace.Text=model.ServiceNamespace;

	}


    }
}

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
namespace BookShop.Web.RunnableInstancesTable
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
		BookShop.BLL.RunnableInstancesTableService bll=new BookShop.BLL.RunnableInstancesTableService();
		BookShop.Model.RunnableInstancesTable model=bll.GetModel();
		this.lblSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.lblWorkflowHostType.Text=model.WorkflowHostType;
		this.lblServiceDeploymentId.Text=model.ServiceDeploymentId;
		this.lblRunnableTime.Text=model.RunnableTime.ToString();

	}


    }
}

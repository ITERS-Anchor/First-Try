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
namespace BookShop.Web.InstancesTable
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
					//ShowInfo(SurrogateInstanceId);
				}
			}
		}
		
	private void ShowInfo(long SurrogateInstanceId)
	{
		BookShop.BLL.InstancesTableService bll=new BookShop.BLL.InstancesTableService();
		BookShop.Model.InstancesTable model=bll.GetModel(SurrogateInstanceId);
		this.lblId.Text=model.Id;
		this.lblSurrogateLockOwnerId.Text=model.SurrogateLockOwnerId;
		this.lblPrimitiveDataProperties.Text=model.PrimitiveDataProperties.ToString();
		this.lblComplexDataProperties.Text=model.ComplexDataProperties.ToString();
		this.lblWriteOnlyPrimitiveDataProperties.Text=model.WriteOnlyPrimitiveDataProperties.ToString();
		this.lblWriteOnlyComplexDataProperties.Text=model.WriteOnlyComplexDataProperties.ToString();
		this.lblMetadataProperties.Text=model.MetadataProperties.ToString();
		this.lblDataEncodingOption.Text=model.DataEncodingOption.ToString();
		this.lblMetadataEncodingOption.Text=model.MetadataEncodingOption.ToString();
		this.lblVersion.Text=model.Version;
		this.lblPendingTimer.Text=model.PendingTimer.ToString();
		this.lblCreationTime.Text=model.CreationTime.ToString();
		this.lblLastUpdated.Text=model.LastUpdated.ToString();
		this.lblWorkflowHostType.Text=model.WorkflowHostType;
		this.lblServiceDeploymentId.Text=model.ServiceDeploymentId;
		this.lblSuspensionExceptionName.Text=model.SuspensionExceptionName;
		this.lblSuspensionReason.Text=model.SuspensionReason;
		this.lblBlockingBookmarks.Text=model.BlockingBookmarks;
		this.lblLastMachineRunOn.Text=model.LastMachineRunOn;
		this.lblExecutionStatus.Text=model.ExecutionStatus;
		this.chkIsInitialized.Checked=model.IsInitialized;
		this.chkIsSuspended.Checked=model.IsSuspended;
		this.chkIsReadyToRun.Checked=model.IsReadyToRun;
		this.chkIsCompleted.Checked=model.IsCompleted;

	}


    }
}

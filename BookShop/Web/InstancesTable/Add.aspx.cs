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
namespace BookShop.Web.InstancesTable
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text =="")
			{
				strErr+="Id不能为空！\\n";	
			}
			if(this.txtSurrogateLockOwnerId.Text =="")
			{
				strErr+="SurrogateLockOwnerId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDataEncodingOption.Text))
			{
				strErr+="DataEncodingOption不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtMetadataEncodingOption.Text))
			{
				strErr+="MetadataEncodingOption不是数字！\\n";	
			}
			if(this.txtVersion.Text =="")
			{
				strErr+="Version不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPendingTimer.Text))
			{
				strErr+="PendingTimer不是时间格式！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreationTime.Text))
			{
				strErr+="CreationTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastUpdated.Text))
			{
				strErr+="LastUpdated不是时间格式！\\n";	
			}
			if(this.txtWorkflowHostType.Text =="")
			{
				strErr+="WorkflowHostType不能为空！\\n";	
			}
			if(this.txtServiceDeploymentId.Text =="")
			{
				strErr+="ServiceDeploymentId不能为空！\\n";	
			}
			if(this.txtSuspensionExceptionName.Text =="")
			{
				strErr+="SuspensionExceptionName不能为空！\\n";	
			}
			if(this.txtSuspensionReason.Text =="")
			{
				strErr+="SuspensionReason不能为空！\\n";	
			}
			if(this.txtBlockingBookmarks.Text =="")
			{
				strErr+="BlockingBookmarks不能为空！\\n";	
			}
			if(this.txtLastMachineRunOn.Text =="")
			{
				strErr+="LastMachineRunOn不能为空！\\n";	
			}
			if(this.txtExecutionStatus.Text =="")
			{
				strErr+="ExecutionStatus不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Id=this.txtId.Text;
			string SurrogateLockOwnerId=this.txtSurrogateLockOwnerId.Text;
			byte[] PrimitiveDataProperties= new UnicodeEncoding().GetBytes(this.txtPrimitiveDataProperties.Text);
			byte[] ComplexDataProperties= new UnicodeEncoding().GetBytes(this.txtComplexDataProperties.Text);
			byte[] WriteOnlyPrimitiveDataProperties= new UnicodeEncoding().GetBytes(this.txtWriteOnlyPrimitiveDataProperties.Text);
			byte[] WriteOnlyComplexDataProperties= new UnicodeEncoding().GetBytes(this.txtWriteOnlyComplexDataProperties.Text);
			byte[] MetadataProperties= new UnicodeEncoding().GetBytes(this.txtMetadataProperties.Text);
			int DataEncodingOption=int.Parse(this.txtDataEncodingOption.Text);
			int MetadataEncodingOption=int.Parse(this.txtMetadataEncodingOption.Text);
			string Version=this.txtVersion.Text;
			DateTime PendingTimer=DateTime.Parse(this.txtPendingTimer.Text);
			DateTime CreationTime=DateTime.Parse(this.txtCreationTime.Text);
			DateTime LastUpdated=DateTime.Parse(this.txtLastUpdated.Text);
			string WorkflowHostType=this.txtWorkflowHostType.Text;
			string ServiceDeploymentId=this.txtServiceDeploymentId.Text;
			string SuspensionExceptionName=this.txtSuspensionExceptionName.Text;
			string SuspensionReason=this.txtSuspensionReason.Text;
			string BlockingBookmarks=this.txtBlockingBookmarks.Text;
			string LastMachineRunOn=this.txtLastMachineRunOn.Text;
			string ExecutionStatus=this.txtExecutionStatus.Text;
			bool IsInitialized=this.chkIsInitialized.Checked;
			bool IsSuspended=this.chkIsSuspended.Checked;
			bool IsReadyToRun=this.chkIsReadyToRun.Checked;
			bool IsCompleted=this.chkIsCompleted.Checked;

			BookShop.Model.InstancesTable model=new BookShop.Model.InstancesTable();
			model.Id=Id;
			model.SurrogateLockOwnerId=SurrogateLockOwnerId;
			model.PrimitiveDataProperties=PrimitiveDataProperties;
			model.ComplexDataProperties=ComplexDataProperties;
			model.WriteOnlyPrimitiveDataProperties=WriteOnlyPrimitiveDataProperties;
			model.WriteOnlyComplexDataProperties=WriteOnlyComplexDataProperties;
			model.MetadataProperties=MetadataProperties;
			model.DataEncodingOption=DataEncodingOption;
			model.MetadataEncodingOption=MetadataEncodingOption;
			model.Version=Version;
			model.PendingTimer=PendingTimer;
			model.CreationTime=CreationTime;
			model.LastUpdated=LastUpdated;
			model.WorkflowHostType=WorkflowHostType;
			model.ServiceDeploymentId=ServiceDeploymentId;
			model.SuspensionExceptionName=SuspensionExceptionName;
			model.SuspensionReason=SuspensionReason;
			model.BlockingBookmarks=BlockingBookmarks;
			model.LastMachineRunOn=LastMachineRunOn;
			model.ExecutionStatus=ExecutionStatus;
			model.IsInitialized=IsInitialized;
			model.IsSuspended=IsSuspended;
			model.IsReadyToRun=IsReadyToRun;
			model.IsCompleted=IsCompleted;

			BookShop.BLL.InstancesTableService bll=new BookShop.BLL.InstancesTableService();
			bll.Add(model);

		}

    }
}

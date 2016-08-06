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
namespace BookShop.Web.LockOwnersTable
{
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(SurrogateLockOwnerId);
				}
			}
		}
			
	private void ShowInfo(long SurrogateLockOwnerId)
	{
		BookShop.BLL.LockOwnersTableService bll=new BookShop.BLL.LockOwnersTableService();
		BookShop.Model.LockOwnersTable model=bll.GetModel(SurrogateLockOwnerId);
		this.txtId.Text=model.Id;
		this.lblSurrogateLockOwnerId.Text=model.SurrogateLockOwnerId;
		this.txtLockExpiration.Text=model.LockExpiration.ToString();
		this.txtWorkflowHostType.Text=model.WorkflowHostType;
		this.txtMachineName.Text=model.MachineName;
		this.chkEnqueueCommand.Checked=model.EnqueueCommand;
		this.chkDeletesInstanceOnCompletion.Checked=model.DeletesInstanceOnCompletion;
		this.txtPrimitiveLockOwnerData.Text=model.PrimitiveLockOwnerData.ToString();
		this.txtComplexLockOwnerData.Text=model.ComplexLockOwnerData.ToString();
		this.txtWriteOnlyPrimitiveLockOwnerData.Text=model.WriteOnlyPrimitiveLockOwnerData.ToString();
		this.txtWriteOnlyComplexLockOwnerData.Text=model.WriteOnlyComplexLockOwnerData.ToString();
		this.txtEncodingOption.Text=model.EncodingOption.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text =="")
			{
				strErr+="Id不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLockExpiration.Text))
			{
				strErr+="LockExpiration不是时间格式！\\n";	
			}
			if(this.txtWorkflowHostType.Text =="")
			{
				strErr+="WorkflowHostType不能为空！\\n";	
			}
			if(this.txtMachineName.Text =="")
			{
				strErr+="MachineName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEncodingOption.Text))
			{
				strErr+="EncodingOption不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Id=this.txtId.Text;
			DateTime LockExpiration=DateTime.Parse(this.txtLockExpiration.Text);
			string WorkflowHostType=this.txtWorkflowHostType.Text;
			string MachineName=this.txtMachineName.Text;
			bool EnqueueCommand=this.chkEnqueueCommand.Checked;
			bool DeletesInstanceOnCompletion=this.chkDeletesInstanceOnCompletion.Checked;
			byte[] PrimitiveLockOwnerData= new UnicodeEncoding().GetBytes(this.txtPrimitiveLockOwnerData.Text);
			byte[] ComplexLockOwnerData= new UnicodeEncoding().GetBytes(this.txtComplexLockOwnerData.Text);
			byte[] WriteOnlyPrimitiveLockOwnerData= new UnicodeEncoding().GetBytes(this.txtWriteOnlyPrimitiveLockOwnerData.Text);
			byte[] WriteOnlyComplexLockOwnerData= new UnicodeEncoding().GetBytes(this.txtWriteOnlyComplexLockOwnerData.Text);
			int EncodingOption=int.Parse(this.txtEncodingOption.Text);


			BookShop.Model.LockOwnersTable model=new BookShop.Model.LockOwnersTable();
			model.Id=Id;
			model.LockExpiration=LockExpiration;
			model.WorkflowHostType=WorkflowHostType;
			model.MachineName=MachineName;
			model.EnqueueCommand=EnqueueCommand;
			model.DeletesInstanceOnCompletion=DeletesInstanceOnCompletion;
			model.PrimitiveLockOwnerData=PrimitiveLockOwnerData;
			model.ComplexLockOwnerData=ComplexLockOwnerData;
			model.WriteOnlyPrimitiveLockOwnerData=WriteOnlyPrimitiveLockOwnerData;
			model.WriteOnlyComplexLockOwnerData=WriteOnlyComplexLockOwnerData;
			model.EncodingOption=EncodingOption;

			BookShop.BLL.LockOwnersTableService bll=new BookShop.BLL.LockOwnersTableService();
			bll.Update(model);

		}

    }
}

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
namespace BookShop.Web.LockOwnersTable
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
					//ShowInfo(SurrogateLockOwnerId);
				}
			}
		}
		
	private void ShowInfo(long SurrogateLockOwnerId)
	{
		BookShop.BLL.LockOwnersTableService bll=new BookShop.BLL.LockOwnersTableService();
		BookShop.Model.LockOwnersTable model=bll.GetModel(SurrogateLockOwnerId);
		this.lblId.Text=model.Id;
		this.lblLockExpiration.Text=model.LockExpiration.ToString();
		this.lblWorkflowHostType.Text=model.WorkflowHostType;
		this.lblMachineName.Text=model.MachineName;
		this.chkEnqueueCommand.Checked=model.EnqueueCommand;
		this.chkDeletesInstanceOnCompletion.Checked=model.DeletesInstanceOnCompletion;
		this.lblPrimitiveLockOwnerData.Text=model.PrimitiveLockOwnerData.ToString();
		this.lblComplexLockOwnerData.Text=model.ComplexLockOwnerData.ToString();
		this.lblWriteOnlyPrimitiveLockOwnerData.Text=model.WriteOnlyPrimitiveLockOwnerData.ToString();
		this.lblWriteOnlyComplexLockOwnerData.Text=model.WriteOnlyComplexLockOwnerData.ToString();
		this.lblEncodingOption.Text=model.EncodingOption.ToString();

	}


    }
}

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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text =="")
			{
				strErr+="Id����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtLockExpiration.Text))
			{
				strErr+="LockExpiration����ʱ���ʽ��\\n";	
			}
			if(this.txtWorkflowHostType.Text =="")
			{
				strErr+="WorkflowHostType����Ϊ�գ�\\n";	
			}
			if(this.txtMachineName.Text =="")
			{
				strErr+="MachineName����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtEncodingOption.Text))
			{
				strErr+="EncodingOption�������֣�\\n";	
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
			bll.Add(model);

		}

    }
}

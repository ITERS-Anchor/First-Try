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
namespace BookShop.Web.WF_Step
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
			if(!PageValidate.IsDateTime(txtsubTime.Text))
			{
				strErr+="subTime����ʱ���ʽ��\\n";	
			}
			if(!PageValidate.IsDateTime(txtProcessTime.Text))
			{
				strErr+="ProcessTime����ʱ���ʽ��\\n";	
			}
			if(!PageValidate.IsNumber(txtProcessBy.Text))
			{
				strErr+="ProcessBy�������֣�\\n";	
			}
			if(this.txtStepName.Text =="")
			{
				strErr+="StepName����Ϊ�գ�\\n";	
			}
			if(this.txtComment.Text =="")
			{
				strErr+="Comment����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtFlowTo.Text))
			{
				strErr+="FlowTo�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="State�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtParentStepId.Text))
			{
				strErr+="ParentStepId�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtSort.Text))
			{
				strErr+="Sort�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_InstanceID.Text))
			{
				strErr+="WF_InstanceID�������֣�\\n";	
			}
			if(this.txtInstanceId.Text =="")
			{
				strErr+="InstanceId����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime subTime=DateTime.Parse(this.txtsubTime.Text);
			DateTime ProcessTime=DateTime.Parse(this.txtProcessTime.Text);
			int ProcessBy=int.Parse(this.txtProcessBy.Text);
			string StepName=this.txtStepName.Text;
			string Comment=this.txtComment.Text;
			int FlowTo=int.Parse(this.txtFlowTo.Text);
			bool IsStart=this.chkIsStart.Checked;
			bool IsEnd=this.chkIsEnd.Checked;
			int State=int.Parse(this.txtState.Text);
			int ParentStepId=int.Parse(this.txtParentStepId.Text);
			int Sort=int.Parse(this.txtSort.Text);
			int WF_InstanceID=int.Parse(this.txtWF_InstanceID.Text);
			string InstanceId=this.txtInstanceId.Text;
			bool IsProcessed=this.chkIsProcessed.Checked;

			BookShop.Model.WF_Step model=new BookShop.Model.WF_Step();
			model.subTime=subTime;
			model.ProcessTime=ProcessTime;
			model.ProcessBy=ProcessBy;
			model.StepName=StepName;
			model.Comment=Comment;
			model.FlowTo=FlowTo;
			model.IsStart=IsStart;
			model.IsEnd=IsEnd;
			model.State=State;
			model.ParentStepId=ParentStepId;
			model.Sort=Sort;
			model.WF_InstanceID=WF_InstanceID;
			model.InstanceId=InstanceId;
			model.IsProcessed=IsProcessed;

			BookShop.BLL.WF_StepService bll=new BookShop.BLL.WF_StepService();
			bll.Add(model);

		}

    }
}

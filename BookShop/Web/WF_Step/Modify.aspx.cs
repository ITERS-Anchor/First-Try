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
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		BookShop.BLL.WF_StepService bll=new BookShop.BLL.WF_StepService();
		BookShop.Model.WF_Step model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtsubTime.Text=model.subTime.ToString();
		this.txtProcessTime.Text=model.ProcessTime.ToString();
		this.txtProcessBy.Text=model.ProcessBy.ToString();
		this.txtStepName.Text=model.StepName;
		this.txtComment.Text=model.Comment;
		this.txtFlowTo.Text=model.FlowTo.ToString();
		this.chkIsStart.Checked=model.IsStart;
		this.chkIsEnd.Checked=model.IsEnd;
		this.txtState.Text=model.State.ToString();
		this.txtParentStepId.Text=model.ParentStepId.ToString();
		this.txtSort.Text=model.Sort.ToString();
		this.txtWF_InstanceID.Text=model.WF_InstanceID.ToString();
		this.txtInstanceId.Text=model.InstanceId;
		this.chkIsProcessed.Checked=model.IsProcessed;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtsubTime.Text))
			{
				strErr+="subTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsDateTime(txtProcessTime.Text))
			{
				strErr+="ProcessTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsNumber(txtProcessBy.Text))
			{
				strErr+="ProcessBy不是数字！\\n";	
			}
			if(this.txtStepName.Text =="")
			{
				strErr+="StepName不能为空！\\n";	
			}
			if(this.txtComment.Text =="")
			{
				strErr+="Comment不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlowTo.Text))
			{
				strErr+="FlowTo不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="State不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtParentStepId.Text))
			{
				strErr+="ParentStepId不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtSort.Text))
			{
				strErr+="Sort不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_InstanceID.Text))
			{
				strErr+="WF_InstanceID不是数字！\\n";	
			}
			if(this.txtInstanceId.Text =="")
			{
				strErr+="InstanceId不能为空！\\n";	
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
			bll.Update(model);

		}

    }
}

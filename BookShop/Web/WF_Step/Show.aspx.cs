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
namespace BookShop.Web.WF_Step
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
					//ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		BookShop.BLL.WF_StepService bll=new BookShop.BLL.WF_StepService();
		BookShop.Model.WF_Step model=bll.GetModel(ID);
		this.lblsubTime.Text=model.subTime.ToString();
		this.lblProcessTime.Text=model.ProcessTime.ToString();
		this.lblProcessBy.Text=model.ProcessBy.ToString();
		this.lblStepName.Text=model.StepName;
		this.lblComment.Text=model.Comment;
		this.lblFlowTo.Text=model.FlowTo.ToString();
		this.chkIsStart.Checked=model.IsStart;
		this.chkIsEnd.Checked=model.IsEnd;
		this.lblState.Text=model.State.ToString();
		this.lblParentStepId.Text=model.ParentStepId.ToString();
		this.lblSort.Text=model.Sort.ToString();
		this.lblWF_InstanceID.Text=model.WF_InstanceID.ToString();
		this.lblInstanceId.Text=model.InstanceId;
		this.chkIsProcessed.Checked=model.IsProcessed;

	}


    }
}

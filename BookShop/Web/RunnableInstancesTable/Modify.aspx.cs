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
namespace BookShop.Web.RunnableInstancesTable
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
					ShowInfo();
				}
			}
		}
			
	private void ShowInfo()
	{
		BookShop.BLL.RunnableInstancesTableService bll=new BookShop.BLL.RunnableInstancesTableService();
		BookShop.Model.RunnableInstancesTable model=bll.GetModel();
		this.txtSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.txtWorkflowHostType.Text=model.WorkflowHostType;
		this.txtServiceDeploymentId.Text=model.ServiceDeploymentId;
		this.txtRunnableTime.Text=model.RunnableTime.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId不能为空！\\n";	
			}
			if(this.txtWorkflowHostType.Text =="")
			{
				strErr+="WorkflowHostType不能为空！\\n";	
			}
			if(this.txtServiceDeploymentId.Text =="")
			{
				strErr+="ServiceDeploymentId不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRunnableTime.Text))
			{
				strErr+="RunnableTime不是时间格式！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			string WorkflowHostType=this.txtWorkflowHostType.Text;
			string ServiceDeploymentId=this.txtServiceDeploymentId.Text;
			DateTime RunnableTime=DateTime.Parse(this.txtRunnableTime.Text);


			BookShop.Model.RunnableInstancesTable model=new BookShop.Model.RunnableInstancesTable();
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.WorkflowHostType=WorkflowHostType;
			model.ServiceDeploymentId=ServiceDeploymentId;
			model.RunnableTime=RunnableTime;

			BookShop.BLL.RunnableInstancesTableService bll=new BookShop.BLL.RunnableInstancesTableService();
			bll.Update(model);

		}

    }
}

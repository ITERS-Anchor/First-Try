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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId����Ϊ�գ�\\n";	
			}
			if(this.txtWorkflowHostType.Text =="")
			{
				strErr+="WorkflowHostType����Ϊ�գ�\\n";	
			}
			if(this.txtServiceDeploymentId.Text =="")
			{
				strErr+="ServiceDeploymentId����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtRunnableTime.Text))
			{
				strErr+="RunnableTime����ʱ���ʽ��\\n";	
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
			bll.Add(model);

		}

    }
}

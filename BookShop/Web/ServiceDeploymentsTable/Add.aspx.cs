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
namespace BookShop.Web.ServiceDeploymentsTable
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
			if(this.txtServiceDeploymentHash.Text =="")
			{
				strErr+="ServiceDeploymentHash不能为空！\\n";	
			}
			if(this.txtSiteName.Text =="")
			{
				strErr+="SiteName不能为空！\\n";	
			}
			if(this.txtRelativeServicePath.Text =="")
			{
				strErr+="RelativeServicePath不能为空！\\n";	
			}
			if(this.txtRelativeApplicationPath.Text =="")
			{
				strErr+="RelativeApplicationPath不能为空！\\n";	
			}
			if(this.txtServiceName.Text =="")
			{
				strErr+="ServiceName不能为空！\\n";	
			}
			if(this.txtServiceNamespace.Text =="")
			{
				strErr+="ServiceNamespace不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ServiceDeploymentHash=this.txtServiceDeploymentHash.Text;
			string SiteName=this.txtSiteName.Text;
			string RelativeServicePath=this.txtRelativeServicePath.Text;
			string RelativeApplicationPath=this.txtRelativeApplicationPath.Text;
			string ServiceName=this.txtServiceName.Text;
			string ServiceNamespace=this.txtServiceNamespace.Text;

			BookShop.Model.ServiceDeploymentsTable model=new BookShop.Model.ServiceDeploymentsTable();
			model.ServiceDeploymentHash=ServiceDeploymentHash;
			model.SiteName=SiteName;
			model.RelativeServicePath=RelativeServicePath;
			model.RelativeApplicationPath=RelativeApplicationPath;
			model.ServiceName=ServiceName;
			model.ServiceNamespace=ServiceNamespace;

			BookShop.BLL.ServiceDeploymentsTableService bll=new BookShop.BLL.ServiceDeploymentsTableService();
			bll.Add(model);

		}

    }
}

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
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtServiceDeploymentHash.Text =="")
			{
				strErr+="ServiceDeploymentHash����Ϊ�գ�\\n";	
			}
			if(this.txtSiteName.Text =="")
			{
				strErr+="SiteName����Ϊ�գ�\\n";	
			}
			if(this.txtRelativeServicePath.Text =="")
			{
				strErr+="RelativeServicePath����Ϊ�գ�\\n";	
			}
			if(this.txtRelativeApplicationPath.Text =="")
			{
				strErr+="RelativeApplicationPath����Ϊ�գ�\\n";	
			}
			if(this.txtServiceName.Text =="")
			{
				strErr+="ServiceName����Ϊ�գ�\\n";	
			}
			if(this.txtServiceNamespace.Text =="")
			{
				strErr+="ServiceNamespace����Ϊ�գ�\\n";	
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

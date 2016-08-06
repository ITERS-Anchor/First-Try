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
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(long Id)
	{
		BookShop.BLL.ServiceDeploymentsTableService bll=new BookShop.BLL.ServiceDeploymentsTableService();
		BookShop.Model.ServiceDeploymentsTable model=bll.GetModel(Id);
		this.lblId.Text=model.Id;
		this.txtServiceDeploymentHash.Text=model.ServiceDeploymentHash;
		this.txtSiteName.Text=model.SiteName;
		this.txtRelativeServicePath.Text=model.RelativeServicePath;
		this.txtRelativeApplicationPath.Text=model.RelativeApplicationPath;
		this.txtServiceName.Text=model.ServiceName;
		this.txtServiceNamespace.Text=model.ServiceNamespace;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
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
			bll.Update(model);

		}

    }
}

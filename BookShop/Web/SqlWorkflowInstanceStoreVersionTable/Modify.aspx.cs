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
namespace BookShop.Web.SqlWorkflowInstanceStoreVersionTable
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
		BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService bll=new BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService();
		BookShop.Model.SqlWorkflowInstanceStoreVersionTable model=bll.GetModel();
		this.txtMajor.Text=model.Major;
		this.txtMinor.Text=model.Minor;
		this.txtBuild.Text=model.Build;
		this.txtRevision.Text=model.Revision;
		this.txtLastUpdated.Text=model.LastUpdated.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMajor.Text =="")
			{
				strErr+="Major不能为空！\\n";	
			}
			if(this.txtMinor.Text =="")
			{
				strErr+="Minor不能为空！\\n";	
			}
			if(this.txtBuild.Text =="")
			{
				strErr+="Build不能为空！\\n";	
			}
			if(this.txtRevision.Text =="")
			{
				strErr+="Revision不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastUpdated.Text))
			{
				strErr+="LastUpdated不是时间格式！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Major=this.txtMajor.Text;
			string Minor=this.txtMinor.Text;
			string Build=this.txtBuild.Text;
			string Revision=this.txtRevision.Text;
			DateTime LastUpdated=DateTime.Parse(this.txtLastUpdated.Text);


			BookShop.Model.SqlWorkflowInstanceStoreVersionTable model=new BookShop.Model.SqlWorkflowInstanceStoreVersionTable();
			model.Major=Major;
			model.Minor=Minor;
			model.Build=Build;
			model.Revision=Revision;
			model.LastUpdated=LastUpdated;

			BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService bll=new BookShop.BLL.SqlWorkflowInstanceStoreVersionTableService();
			bll.Update(model);

		}

    }
}

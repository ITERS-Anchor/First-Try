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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="��Ϣ���ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMajor.Text =="")
			{
				strErr+="Major����Ϊ�գ�\\n";	
			}
			if(this.txtMinor.Text =="")
			{
				strErr+="Minor����Ϊ�գ�\\n";	
			}
			if(this.txtBuild.Text =="")
			{
				strErr+="Build����Ϊ�գ�\\n";	
			}
			if(this.txtRevision.Text =="")
			{
				strErr+="Revision����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastUpdated.Text))
			{
				strErr+="LastUpdated����ʱ���ʽ��\\n";	
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
			bll.Add(model);

		}

    }
}
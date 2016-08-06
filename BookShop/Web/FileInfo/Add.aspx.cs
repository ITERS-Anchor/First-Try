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
namespace BookShop.Web.FileInfo
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
			if(this.txtAlt.Text =="")
			{
				strErr+="Alt不能为空！\\n";	
			}
			if(this.txtUrl.Text =="")
			{
				strErr+="Url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsize.Text))
			{
				strErr+="size不是数字！\\n";	
			}
			if(this.txtFileType.Text =="")
			{
				strErr+="FileType不能为空！\\n";	
			}
			if(this.txtFileName.Text =="")
			{
				strErr+="FileName不能为空！\\n";	
			}
			if(this.txtExt.Text =="")
			{
				strErr+="Ext不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_InstanceID.Text))
			{
				strErr+="WF_InstanceID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Alt=this.txtAlt.Text;
			string Url=this.txtUrl.Text;
			int size=int.Parse(this.txtsize.Text);
			string FileType=this.txtFileType.Text;
			string FileName=this.txtFileName.Text;
			string Ext=this.txtExt.Text;
			int WF_InstanceID=int.Parse(this.txtWF_InstanceID.Text);

			BookShop.Model.FileInfo model=new BookShop.Model.FileInfo();
			model.Alt=Alt;
			model.Url=Url;
			model.size=size;
			model.FileType=FileType;
			model.FileName=FileName;
			model.Ext=Ext;
			model.WF_InstanceID=WF_InstanceID;

			BookShop.BLL.FileInfoService bll=new BookShop.BLL.FileInfoService();
			bll.Add(model);

		}

    }
}

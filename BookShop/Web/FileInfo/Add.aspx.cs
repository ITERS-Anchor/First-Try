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
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtAlt.Text =="")
			{
				strErr+="Alt����Ϊ�գ�\\n";	
			}
			if(this.txtUrl.Text =="")
			{
				strErr+="Url����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtsize.Text))
			{
				strErr+="size�������֣�\\n";	
			}
			if(this.txtFileType.Text =="")
			{
				strErr+="FileType����Ϊ�գ�\\n";	
			}
			if(this.txtFileName.Text =="")
			{
				strErr+="FileName����Ϊ�գ�\\n";	
			}
			if(this.txtExt.Text =="")
			{
				strErr+="Ext����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_InstanceID.Text))
			{
				strErr+="WF_InstanceID�������֣�\\n";	
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

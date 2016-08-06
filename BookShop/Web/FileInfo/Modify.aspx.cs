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
    public partial class Modify : System.Web.UI.Page
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
		BookShop.BLL.FileInfoService bll=new BookShop.BLL.FileInfoService();
		BookShop.Model.FileInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtAlt.Text=model.Alt;
		this.txtUrl.Text=model.Url;
		this.txtsize.Text=model.size.ToString();
		this.txtFileType.Text=model.FileType;
		this.txtFileName.Text=model.FileName;
		this.txtExt.Text=model.Ext;
		this.txtWF_InstanceID.Text=model.WF_InstanceID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
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
			bll.Update(model);

		}

    }
}

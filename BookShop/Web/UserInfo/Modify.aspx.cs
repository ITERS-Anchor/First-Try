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
namespace BookShop.Web.UserInfo
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
		BookShop.BLL.UserInfoService bll=new BookShop.BLL.UserInfoService();
		BookShop.Model.UserInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtUserName.Text=model.UserName;
		this.txtUserPass.Text=model.UserPass;
		this.txtRegTime.Text=model.RegTime.ToString();
		this.txtEmail.Text=model.Email;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserName.Text =="")
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtUserPass.Text =="")
			{
				strErr+="UserPass不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRegTime.Text))
			{
				strErr+="RegTime不是时间格式！\\n";	
			}
			if(this.txtEmail.Text =="")
			{
				strErr+="Email不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserName=this.txtUserName.Text;
			string UserPass=this.txtUserPass.Text;
			DateTime RegTime=DateTime.Parse(this.txtRegTime.Text);
			string Email=this.txtEmail.Text;


			BookShop.Model.UserInfo model=new BookShop.Model.UserInfo();
			model.UserName=UserName;
			model.UserPass=UserPass;
			model.RegTime=RegTime;
			model.Email=Email;

			BookShop.BLL.UserInfoService bll=new BookShop.BLL.UserInfoService();
			bll.Update(model);

		}

    }
}

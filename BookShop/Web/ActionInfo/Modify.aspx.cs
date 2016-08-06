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
namespace BookShop.Web.ActionInfo
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
		BookShop.BLL.ActionInfoService bll=new BookShop.BLL.ActionInfoService();
		BookShop.Model.ActionInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtActionInfoName.Text=model.ActionInfoName;
		this.txtUrl.Text=model.Url;
		this.txtHttpMethod.Text=model.HttpMethod.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtDelFalg.Text=model.DelFalg.ToString();
		this.txtSubTime.Text=model.SubTime.ToString();
		this.chkIsMenu.Checked=model.IsMenu;
		this.txtR_UserInfo_ActionInfoID.Text=model.R_UserInfo_ActionInfoID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtActionInfoName.Text =="")
			{
				strErr+="ActionInfoName不能为空！\\n";	
			}
			if(this.txtUrl.Text =="")
			{
				strErr+="Url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtHttpMethod.Text))
			{
				strErr+="HttpMethod不是数字！\\n";	
			}
			if(this.txtRemark.Text =="")
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDelFalg.Text))
			{
				strErr+="DelFalg不是数字！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsNumber(txtR_UserInfo_ActionInfoID.Text))
			{
				strErr+="R_UserInfo_ActionInfoID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ActionInfoName=this.txtActionInfoName.Text;
			string Url=this.txtUrl.Text;
			int HttpMethod=int.Parse(this.txtHttpMethod.Text);
			string Remark=this.txtRemark.Text;
			int DelFalg=int.Parse(this.txtDelFalg.Text);
			DateTime SubTime=DateTime.Parse(this.txtSubTime.Text);
			bool IsMenu=this.chkIsMenu.Checked;
			int R_UserInfo_ActionInfoID=int.Parse(this.txtR_UserInfo_ActionInfoID.Text);


			BookShop.Model.ActionInfo model=new BookShop.Model.ActionInfo();
			model.ActionInfoName=ActionInfoName;
			model.Url=Url;
			model.HttpMethod=HttpMethod;
			model.Remark=Remark;
			model.DelFalg=DelFalg;
			model.SubTime=SubTime;
			model.IsMenu=IsMenu;
			model.R_UserInfo_ActionInfoID=R_UserInfo_ActionInfoID;

			BookShop.BLL.ActionInfoService bll=new BookShop.BLL.ActionInfoService();
			bll.Update(model);

		}

    }
}

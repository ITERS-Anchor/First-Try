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
namespace BookShop.Web.R_UserInfo_ActionInfo
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
			if(!PageValidate.IsNumber(txtIsPass.Text))
			{
				strErr+="IsPass不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfoID.Text))
			{
				strErr+="ActionInfoID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserInfoID.Text))
			{
				strErr+="UserInfoID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfo_ID.Text))
			{
				strErr+="ActionInfo_ID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int IsPass=int.Parse(this.txtIsPass.Text);
			int ActionInfoID=int.Parse(this.txtActionInfoID.Text);
			int UserInfoID=int.Parse(this.txtUserInfoID.Text);
			int ActionInfo_ID=int.Parse(this.txtActionInfo_ID.Text);

			BookShop.Model.R_UserInfo_ActionInfo model=new BookShop.Model.R_UserInfo_ActionInfo();
			model.IsPass=IsPass;
			model.ActionInfoID=ActionInfoID;
			model.UserInfoID=UserInfoID;
			model.ActionInfo_ID=ActionInfo_ID;

			BookShop.BLL.R_UserInfo_ActionInfoService bll=new BookShop.BLL.R_UserInfo_ActionInfoService();
			bll.Add(model);

		}

    }
}

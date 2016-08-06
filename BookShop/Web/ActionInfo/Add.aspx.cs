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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
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
			bll.Add(model);

		}

    }
}

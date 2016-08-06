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
namespace BookShop.Web.Role
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
			if(this.txtRoleName.Text =="")
			{
				strErr+="RoleName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDelFlag.Text))
			{
				strErr+="DelFlag不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleType.Text))
			{
				strErr+="RoleType不是数字！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime不是时间格式！\\n";	
			}
			if(this.txtRemark.Text =="")
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string RoleName=this.txtRoleName.Text;
			int DelFlag=int.Parse(this.txtDelFlag.Text);
			int RoleType=int.Parse(this.txtRoleType.Text);
			DateTime SubTime=DateTime.Parse(this.txtSubTime.Text);
			string Remark=this.txtRemark.Text;

			BookShop.Model.Role model=new BookShop.Model.Role();
			model.RoleName=RoleName;
			model.DelFlag=DelFlag;
			model.RoleType=RoleType;
			model.SubTime=SubTime;
			model.Remark=Remark;

			BookShop.BLL.RoleService bll=new BookShop.BLL.RoleService();
			bll.Add(model);

		}

    }
}

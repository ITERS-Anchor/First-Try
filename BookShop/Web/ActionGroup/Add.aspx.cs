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
namespace BookShop.Web.ActionGroup
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
			if(this.txtGroupName.Text =="")
			{
				strErr+="GroupName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupType.Text))
			{
				strErr+="GroupType不是数字！\\n";	
			}
			if(this.txtDelFlag.Text =="")
			{
				strErr+="DelFlag不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSort.Text))
			{
				strErr+="Sort不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string GroupName=this.txtGroupName.Text;
			int GroupType=int.Parse(this.txtGroupType.Text);
			string DelFlag=this.txtDelFlag.Text;
			int Sort=int.Parse(this.txtSort.Text);

			BookShop.Model.ActionGroup model=new BookShop.Model.ActionGroup();
			model.GroupName=GroupName;
			model.GroupType=GroupType;
			model.DelFlag=DelFlag;
			model.Sort=Sort;

			BookShop.BLL.ActionGroupService bll=new BookShop.BLL.ActionGroupService();
			bll.Add(model);

		}

    }
}

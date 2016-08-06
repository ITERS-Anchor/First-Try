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
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGroupName.Text =="")
			{
				strErr+="GroupName����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupType.Text))
			{
				strErr+="GroupType�������֣�\\n";	
			}
			if(this.txtDelFlag.Text =="")
			{
				strErr+="DelFlag����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtSort.Text))
			{
				strErr+="Sort�������֣�\\n";	
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

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
namespace BookShop.Web.RoleActionInfo
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
			if(!PageValidate.IsNumber(txtRole_ID.Text))
			{
				strErr+="Role_ID�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfo_ID.Text))
			{
				strErr+="ActionInfo_ID�������֣�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Role_ID=int.Parse(this.txtRole_ID.Text);
			int ActionInfo_ID=int.Parse(this.txtActionInfo_ID.Text);

			BookShop.Model.RoleActionInfo model=new BookShop.Model.RoleActionInfo();
			model.Role_ID=Role_ID;
			model.ActionInfo_ID=ActionInfo_ID;

			BookShop.BLL.RoleActionInfoService bll=new BookShop.BLL.RoleActionInfoService();
			bll.Add(model);

		}

    }
}

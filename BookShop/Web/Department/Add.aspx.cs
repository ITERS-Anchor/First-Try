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
namespace BookShop.Web.Department
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
			if(this.txtDepName.Text =="")
			{
				strErr+="DepName����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID�������֣�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DepName=this.txtDepName.Text;
			int RoleID=int.Parse(this.txtRoleID.Text);

			BookShop.Model.Department model=new BookShop.Model.Department();
			model.DepName=DepName;
			model.RoleID=RoleID;

			BookShop.BLL.DepartmentService bll=new BookShop.BLL.DepartmentService();
			bll.Add(model);

		}

    }
}

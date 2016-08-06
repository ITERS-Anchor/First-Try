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
namespace BookShop.Web.RoleDepartment
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
			if(!PageValidate.IsNumber(txtRole_ID.Text))
			{
				strErr+="Role_ID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtDepartment_ID.Text))
			{
				strErr+="Department_ID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Role_ID=int.Parse(this.txtRole_ID.Text);
			int Department_ID=int.Parse(this.txtDepartment_ID.Text);

			BookShop.Model.RoleDepartment model=new BookShop.Model.RoleDepartment();
			model.Role_ID=Role_ID;
			model.Department_ID=Department_ID;

			BookShop.BLL.RoleDepartmentService bll=new BookShop.BLL.RoleDepartmentService();
			bll.Add(model);

		}

    }
}

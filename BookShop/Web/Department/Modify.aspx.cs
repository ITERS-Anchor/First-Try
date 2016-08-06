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
		BookShop.BLL.DepartmentService bll=new BookShop.BLL.DepartmentService();
		BookShop.Model.Department model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtDepName.Text=model.DepName;
		this.txtRoleID.Text=model.RoleID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDepName.Text =="")
			{
				strErr+="DepName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID不是数字！\\n";	
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
			bll.Update(model);

		}

    }
}

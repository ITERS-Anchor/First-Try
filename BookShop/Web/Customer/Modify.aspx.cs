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
namespace BookShop.Web.Customer
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
		BookShop.BLL.CustomerService bll=new BookShop.BLL.CustomerService();
		BookShop.Model.Customer model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtCustomerName.Text=model.CustomerName;
		this.txtRegTime.Text=model.RegTime.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCustomerName.Text =="")
			{
				strErr+="CustomerName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRegTime.Text))
			{
				strErr+="RegTime不是时间格式！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CustomerName=this.txtCustomerName.Text;
			DateTime RegTime=DateTime.Parse(this.txtRegTime.Text);


			BookShop.Model.Customer model=new BookShop.Model.Customer();
			model.CustomerName=CustomerName;
			model.RegTime=RegTime;

			BookShop.BLL.CustomerService bll=new BookShop.BLL.CustomerService();
			bll.Update(model);

		}

    }
}

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
namespace BookShop.Web.Order
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
			
	private void ShowInfo(uniqueidentifier ID)
	{
		BookShop.BLL.OrderService bll=new BookShop.BLL.OrderService();
		BookShop.Model.Order model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.txtOrderNum.Text=model.OrderNum;
		this.txtSubDateTime.Text=model.SubDateTime.ToString();
		this.txtCustomerID.Text=model.CustomerID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOrderNum.Text =="")
			{
				strErr+="OrderNum不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubDateTime.Text))
			{
				strErr+="SubDateTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsNumber(txtCustomerID.Text))
			{
				strErr+="CustomerID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OrderNum=this.txtOrderNum.Text;
			DateTime SubDateTime=DateTime.Parse(this.txtSubDateTime.Text);
			int CustomerID=int.Parse(this.txtCustomerID.Text);


			BookShop.Model.Order model=new BookShop.Model.Order();
			model.OrderNum=OrderNum;
			model.SubDateTime=SubDateTime;
			model.CustomerID=CustomerID;

			BookShop.BLL.OrderService bll=new BookShop.BLL.OrderService();
			bll.Update(model);

		}

    }
}

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
namespace BookShop.Web.Order
{
    public partial class Show : System.Web.UI.Page
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
		this.lblOrderNum.Text=model.OrderNum;
		this.lblSubDateTime.Text=model.SubDateTime.ToString();
		this.lblCustomerID.Text=model.CustomerID.ToString();

	}


    }
}

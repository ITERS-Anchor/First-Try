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
namespace BookShop.Web.ActionGroupActionInfo
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
					//ShowInfo(ActionGroup_ID,ActionInfo_ID);
				}
			}
		}
			
	private void ShowInfo(int ActionGroup_ID,int ActionInfo_ID)
	{
		BookShop.BLL.ActionGroupActionInfoService bll=new BookShop.BLL.ActionGroupActionInfoService();
		BookShop.Model.ActionGroupActionInfo model=bll.GetModel(ActionGroup_ID,ActionInfo_ID);
		this.lblActionGroup_ID.Text=model.ActionGroup_ID.ToString();
		this.lblActionInfo_ID.Text=model.ActionInfo_ID.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}


			BookShop.Model.ActionGroupActionInfo model=new BookShop.Model.ActionGroupActionInfo();

			BookShop.BLL.ActionGroupActionInfoService bll=new BookShop.BLL.ActionGroupActionInfoService();
			bll.Update(model);

		}

    }
}

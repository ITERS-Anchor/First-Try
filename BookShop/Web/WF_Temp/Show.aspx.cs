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
namespace BookShop.Web.WF_Temp
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
		
	private void ShowInfo(int ID)
	{
		BookShop.BLL.WF_TempService bll=new BookShop.BLL.WF_TempService();
		BookShop.Model.WF_Temp model=bll.GetModel(ID);
		this.lblTempName.Text=model.TempName;
		this.lblSubTime.Text=model.SubTime.ToString();
		this.lblActiveType.Text=model.ActiveType;
		this.lblDescription.Text=model.Description;
		this.lblFormTemp.Text=model.FormTemp;
		this.lblstate.Text=model.state.ToString();

	}


    }
}

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
namespace BookShop.Web.WF_Instance
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
		BookShop.BLL.WF_InstanceService bll=new BookShop.BLL.WF_InstanceService();
		BookShop.Model.WF_Instance model=bll.GetModel(ID);
		this.lblTitle.Text=model.Title;
		this.lblSubBy.Text=model.SubBy.ToString();
		this.lblSubTime.Text=model.SubTime.ToString();
		this.lblOutTime.Text=model.OutTime.ToString();
		this.lblstate.Text=model.state.ToString();
		this.lblResult.Text=model.Result.ToString();
		this.lblContent.Text=model.Content;
		this.lblLevel.Text=model.Level.ToString();
		this.lblWF_TempID.Text=model.WF_TempID.ToString();
		this.lblInstanceId.Text=model.InstanceId;

	}


    }
}

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
namespace BookShop.Web.InstanceMetadataChangesTable
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
					//ShowInfo(ChangeTime);
				}
			}
		}
		
	private void ShowInfo(long ChangeTime)
	{
		BookShop.BLL.InstanceMetadataChangesTableService bll=new BookShop.BLL.InstanceMetadataChangesTableService();
		BookShop.Model.InstanceMetadataChangesTable model=bll.GetModel(ChangeTime);
		this.lblSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.lblEncodingOption.Text=model.EncodingOption.ToString();
		this.lblChange.Text=model.Change.ToString();

	}


    }
}

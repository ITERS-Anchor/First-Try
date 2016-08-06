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
namespace BookShop.Web.KeysTable
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
					//ShowInfo(SurrogateKeyId);
				}
			}
		}
		
	private void ShowInfo(long SurrogateKeyId)
	{
		BookShop.BLL.KeysTableService bll=new BookShop.BLL.KeysTableService();
		BookShop.Model.KeysTable model=bll.GetModel(SurrogateKeyId);
		this.lblId.Text=model.Id;
		this.lblSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.lblEncodingOption.Text=model.EncodingOption.ToString();
		this.lblProperties.Text=model.Properties.ToString();
		this.chkIsAssociated.Checked=model.IsAssociated;

	}


    }
}

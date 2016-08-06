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
namespace BookShop.Web.FileInfo
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
		BookShop.BLL.FileInfoService bll=new BookShop.BLL.FileInfoService();
		BookShop.Model.FileInfo model=bll.GetModel(ID);
		this.lblAlt.Text=model.Alt;
		this.lblUrl.Text=model.Url;
		this.lblsize.Text=model.size.ToString();
		this.lblFileType.Text=model.FileType;
		this.lblFileName.Text=model.FileName;
		this.lblExt.Text=model.Ext;
		this.lblWF_InstanceID.Text=model.WF_InstanceID.ToString();

	}


    }
}

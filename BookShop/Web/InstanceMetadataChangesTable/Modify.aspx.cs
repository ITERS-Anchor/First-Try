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
namespace BookShop.Web.InstanceMetadataChangesTable
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
					//ShowInfo(ChangeTime);
				}
			}
		}
			
	private void ShowInfo(long ChangeTime)
	{
		BookShop.BLL.InstanceMetadataChangesTableService bll=new BookShop.BLL.InstanceMetadataChangesTableService();
		BookShop.Model.InstanceMetadataChangesTable model=bll.GetModel(ChangeTime);
		this.txtSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.lblChangeTime.Text=model.ChangeTime;
		this.txtEncodingOption.Text=model.EncodingOption.ToString();
		this.txtChange.Text=model.Change.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEncodingOption.Text))
			{
				strErr+="EncodingOption不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			int EncodingOption=int.Parse(this.txtEncodingOption.Text);
			byte[] Change= new UnicodeEncoding().GetBytes(this.txtChange.Text);


			BookShop.Model.InstanceMetadataChangesTable model=new BookShop.Model.InstanceMetadataChangesTable();
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.EncodingOption=EncodingOption;
			model.Change=Change;

			BookShop.BLL.InstanceMetadataChangesTableService bll=new BookShop.BLL.InstanceMetadataChangesTableService();
			bll.Update(model);

		}

    }
}

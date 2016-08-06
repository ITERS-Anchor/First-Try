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
namespace BookShop.Web.KeysTable
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
					//ShowInfo(SurrogateKeyId);
				}
			}
		}
			
	private void ShowInfo(long SurrogateKeyId)
	{
		BookShop.BLL.KeysTableService bll=new BookShop.BLL.KeysTableService();
		BookShop.Model.KeysTable model=bll.GetModel(SurrogateKeyId);
		this.txtId.Text=model.Id;
		this.lblSurrogateKeyId.Text=model.SurrogateKeyId;
		this.txtSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.txtEncodingOption.Text=model.EncodingOption.ToString();
		this.txtProperties.Text=model.Properties.ToString();
		this.chkIsAssociated.Checked=model.IsAssociated;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text =="")
			{
				strErr+="Id不能为空！\\n";	
			}
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
			string Id=this.txtId.Text;
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			int EncodingOption=int.Parse(this.txtEncodingOption.Text);
			byte[] Properties= new UnicodeEncoding().GetBytes(this.txtProperties.Text);
			bool IsAssociated=this.chkIsAssociated.Checked;


			BookShop.Model.KeysTable model=new BookShop.Model.KeysTable();
			model.Id=Id;
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.EncodingOption=EncodingOption;
			model.Properties=Properties;
			model.IsAssociated=IsAssociated;

			BookShop.BLL.KeysTableService bll=new BookShop.BLL.KeysTableService();
			bll.Update(model);

		}

    }
}

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
namespace BookShop.Web.WF_Temp
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
			
	private void ShowInfo(int ID)
	{
		BookShop.BLL.WF_TempService bll=new BookShop.BLL.WF_TempService();
		BookShop.Model.WF_Temp model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTempName.Text=model.TempName;
		this.txtSubTime.Text=model.SubTime.ToString();
		this.txtActiveType.Text=model.ActiveType;
		this.txtDescription.Text=model.Description;
		this.txtFormTemp.Text=model.FormTemp;
		this.txtstate.Text=model.state.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTempName.Text =="")
			{
				strErr+="TempName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime不是时间格式！\\n";	
			}
			if(this.txtActiveType.Text =="")
			{
				strErr+="ActiveType不能为空！\\n";	
			}
			if(this.txtDescription.Text =="")
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtFormTemp.Text =="")
			{
				strErr+="FormTemp不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string TempName=this.txtTempName.Text;
			DateTime SubTime=DateTime.Parse(this.txtSubTime.Text);
			string ActiveType=this.txtActiveType.Text;
			string Description=this.txtDescription.Text;
			string FormTemp=this.txtFormTemp.Text;
			int state=int.Parse(this.txtstate.Text);


			BookShop.Model.WF_Temp model=new BookShop.Model.WF_Temp();
			model.TempName=TempName;
			model.SubTime=SubTime;
			model.ActiveType=ActiveType;
			model.Description=Description;
			model.FormTemp=FormTemp;
			model.state=state;

			BookShop.BLL.WF_TempService bll=new BookShop.BLL.WF_TempService();
			bll.Update(model);

		}

    }
}
